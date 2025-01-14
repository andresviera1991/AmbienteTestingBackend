using AutoMapper;
using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using MGP.MisTramites.Client.Interface.Authentication;
using MGP.MisTramites.Client.Interface.Discapacidad;
using MGP.MisTramites.CrossCutting.Exceptions;
using MGP.MisTramites.Domain.DTOs;
using MGP.MisTramites.Domain.Interfaces;
using MGP.MisTramites.Domain.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace MGP.MisTramites.Domain.Service;

public class TicketService : ITicketService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IDiscapacidadClient _discapacidadClient;
    private readonly IAuthenticationClient _authenticationClient;
    private readonly IMapper _mapper;

    private readonly GetTicketEndpoints _ticketEndpoints;
    private readonly ListTicketEndpoints _listTicketEndpoints;

    public TicketService(IHttpClientFactory httpClientFactory,
                         IOptions<GetTicketEndpoints> ticketEndpoints,
                         IOptions<ListTicketEndpoints> listTicketEndpoints,
                         IDiscapacidadClient discapacidadClient,
                         IAuthenticationClient authenticationClient,
                         IMapper mapper)
    {
        _httpClientFactory = httpClientFactory;
        _ticketEndpoints = ticketEndpoints.Value;
        _listTicketEndpoints = listTicketEndpoints.Value;
        _discapacidadClient = discapacidadClient;
        _authenticationClient = authenticationClient;
        _mapper = mapper;
    }

    #region GET TICKET USER
    public async Task<object> GetTicketUserAsync(string serviceName, int ticketTypeId, Guid ticketId, Guid userId)
    {
        string endpoint = GetEndpointUser(serviceName, ticketTypeId);
        return await _discapacidadClient.GetTicketUserAsync(ticketId, userId, endpoint);
    }

    #endregion

    #region GET TICKET AGENT
    public async Task<object> GetTicketAgentAsync(string serviceName, int ticketTypeId, Guid ticketId)
    {
        string endpoint = GetEndpointAgent(serviceName, ticketTypeId);
        return await _discapacidadClient.GetTicketAgentAsync(ticketId, endpoint);
    }

    #endregion

    #region LIST TICKETS USER
    public async Task<TicketDataModel> ListTicketsUserAsync(FiltersUserDto filtersUserDto)
    {
        var urls = _listTicketEndpoints.ListTicketUser;

        var tasks = urls.Select(async url =>
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("userId", filtersUserDto.UserId.ToString());

            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<JObject>(responseData);

            var tickets = jsonObject["data"].ToObject<List<TicketData>>();

            return tickets ?? [];
        });

        var results = await Task.WhenAll(tasks);

        var listTicketData = results.SelectMany(t => t).ToList();

        return await FilterAndPaginate(listTicketData, filtersUserDto);
    }

    private static async Task<TicketDataModel> FilterAndPaginate(List<TicketData> listTicketData, FiltersUserDto filtersUserDto)
    {
        var filteredTickets = listTicketData;

        if (!string.IsNullOrEmpty(filtersUserDto.TicketCode))
        {
            filteredTickets = filteredTickets
                .Where(t => t.TicketCode == filtersUserDto.TicketCode)
                .ToList();
        }

        if (filtersUserDto.TicketTypeId.HasValue)
        {
            filteredTickets = filteredTickets
                .Where(t => t.TicketType.Id == filtersUserDto.TicketTypeId.Value)
                .ToList();
        }

        filteredTickets = filteredTickets
            .OrderByDescending(t => t.CreationDate)
            .ToList();

        int skip = (filtersUserDto.PageNumber - 1) * filtersUserDto.PageSize;
        var paginatedTickets = filteredTickets
            .Skip(skip)
            .Take(filtersUserDto.PageSize)
            .ToList();

        TicketDataModel response = new ()
        {
            CountTickets = filteredTickets.Count,
            PageNumber = filtersUserDto.PageNumber,
            ListTicketData = paginatedTickets
        };

        return await Task.FromResult(response);
    }

    #endregion

    #region LIST TICKETS AGENT

    public async Task<TicketDataModel> ListTicketsAgentAsync(FiltersAgentRequestModel filtersAgentDto)
    {

        string baseUrl = GetEndpointListTicketAgent(filtersAgentDto);
        filtersAgentDto.UserIds = await GetUserIdsByFilter(filtersAgentDto);
        return await _discapacidadClient.ListTicketAgentAsync(filtersAgentDto, baseUrl);
    }

    private async Task<List<Guid>> GetUserIdsByFilter(FiltersAgentRequestModel filtersAgentDto)
    {

        if (!filtersAgentDto.FullName.IsNullOrEmpty() || !filtersAgentDto.DocumentNumber.IsNullOrEmpty())
        {
            return await _authenticationClient.ListUserIdsByFiltersAsync(filtersAgentDto.FullName, filtersAgentDto.DocumentNumber);
        }
        return [];
    }

    private string GetEndpointListTicketAgent(FiltersAgentRequestModel filtersAgentDto)
    {
        if (!_listTicketEndpoints.ListTicketAgent.TryGetValue(filtersAgentDto.ServiceName, out var urls) || urls.Count == 0)
        {
            throw new EndpointNotFoundException();
        }

        var baseUrl = urls.FirstOrDefault();
        return baseUrl;
    }

    #endregion

    #region PRIVATE METHODS
    private string GetEndpointUser(string serviceName, int ticketTypeId)
    {
        if (_ticketEndpoints.Endpoints.TryGetValue(serviceName, out var serviceEndpoints) && serviceEndpoints.USER
                                      .TryGetValue(ticketTypeId.ToString(), out var endpoint))
        {
            return endpoint;
        }

        throw new EndpointNotFoundException();
    }
    private string GetEndpointAgent(string serviceName, int ticketTypeId)
    {
        if (_ticketEndpoints.Endpoints.TryGetValue(serviceName, out var serviceEndpoints) && serviceEndpoints.AGENT
                                      .TryGetValue(ticketTypeId.ToString(), out var endpoint))
        {
            return endpoint;
        }

        throw new EndpointNotFoundException();
    }

    #endregion
}
