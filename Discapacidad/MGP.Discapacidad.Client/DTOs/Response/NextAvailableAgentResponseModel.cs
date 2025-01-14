using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.Client.DTOs.Response

{
    public class NextAvailableAgentResponseModel
    {
        public int Code { get; set; }
        public NextAvailableAgentResponse Data { get; set; }
        public List<string> Message { get; set; }
    }

    public class NextAvailableAgentResponse
    {
        public Guid Id { get; set; }
    }
}
