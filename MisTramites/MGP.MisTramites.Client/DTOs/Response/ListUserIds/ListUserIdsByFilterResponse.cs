namespace MGP.MisTramites.Client.DTOs.Response.ListUserIds;
public class ListUserIdsByFilterResponse
{
    public int Code { get; set; }
    public List<Guid> Data { get; set; }
    public List<string> Message { get; set; }
}
