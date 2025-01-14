using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Province.Response
{
    public class GetAllProvincesResponseModelExample
    {
        /// <example>200</example>
        [SwaggerSchema("Codigo de respuesta")]
        public int Code { get; set; }


        public GetAllProvincesResponseModelList Data { get; set; }

        /// <example>null</example>
        [SwaggerSchema("Lista de mensajes de error")]
        public string ErrorMessage { get; set; }
    }
}
