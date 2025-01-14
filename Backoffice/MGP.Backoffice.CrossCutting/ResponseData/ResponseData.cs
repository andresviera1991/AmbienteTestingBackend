using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.CrossCutting.ResponseData
{
    [SwaggerSchema("Generic response data")]
    public class ResponseData<TData, TMessage>
    {
        public int Code { get; set; }
        public TData Data { get; set; }
        public TMessage Message { get; set; }

        public ResponseData(int code, TData data, TMessage message)
        {
            Code = code;
            Data = data;
            Message = message;
        }
    }
}
