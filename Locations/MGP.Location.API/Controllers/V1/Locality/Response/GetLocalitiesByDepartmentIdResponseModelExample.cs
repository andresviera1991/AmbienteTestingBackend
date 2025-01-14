using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Locality.Response
{
    public class GetLocalitiesByDepartmentIdResponseModelExample
    {
        /// <example>200</example>
        [SwaggerSchema("Codigo de respuesta")]
        public int Code { get; set; }


        public GetLocalitiesByDepartmentIdResponseModelList Data { get; set; }

        /// <example>null</example>
        [SwaggerSchema("Lista de mensajes de error")]
        public string ErrorMessage { get; set; }
    }
}
