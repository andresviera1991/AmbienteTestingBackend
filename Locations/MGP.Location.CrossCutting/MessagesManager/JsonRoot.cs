using System.Collections.Generic;

namespace MGP.Location.CrossCutting.MessagesManager
{
    public class JsonRoot
    {
        public string Language { get; set; }
        public List<ErrorMessage> Messages { get; set; }
    }
}
