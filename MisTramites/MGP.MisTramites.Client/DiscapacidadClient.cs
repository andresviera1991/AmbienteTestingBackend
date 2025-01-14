using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using MGP.MisTramites.Client.Interface.Authentication;
using MGP.MisTramites.Client.Interface.Discapacidad;
using Newtonsoft.Json;
using Refit;

namespace MGP.MisTramites.Client;

public class DiscapacidadClient : IDiscapacidadClient
{

    public async Task<object> GetTicketAgentAsync(Guid ticketId, string endpoint)
    {
        var httpClient = new HttpClient { BaseAddress = new Uri(endpoint) };
        var apiClient = RestService.For<IDiscapacidadApi>(httpClient);
        try
        {
            var ticketData = await apiClient.GetTicketAgentAsync(ticketId);
            var jsonString = ticketData?.Content.ToString();
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);
            return jsonObject?.data;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<object> GetTicketUserAsync(Guid ticketId, Guid userId, string endpoint)
    {
        var httpClient = new HttpClient { BaseAddress = new Uri(endpoint) };
        var apiClient = RestService.For<IDiscapacidadApi>(httpClient);
        try
        {
            var ticketData = await apiClient.GetTicketUserAsync(userId, ticketId);
            var jsonString = ticketData?.Content.ToString();
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);
            return jsonObject?.data;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task<TicketDataModel> ListTicketAgentAsync(FiltersAgentRequestModel filtersAgentDto, string baseUrl)
    {
        var httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
        var apiClient = RestService.For<IDiscapacidadApi>(httpClient);

        try
        {
            var listTicketResponse = await apiClient.ListTicketAgentAsync(filtersAgentDto);

            if (listTicketResponse.IsSuccessStatusCode)
            {
                return listTicketResponse.Content.Data;
            }
            return null;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
