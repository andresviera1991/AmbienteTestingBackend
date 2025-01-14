using MGP.Backoffice.Application.UseCase.V1.Catalog.ListUserStatus;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.Api.Controllers.Catalog.Response
{
    public class ListUserStatusResponseModelExample
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>200</example>
        [SwaggerSchema("Response Code")]
        public int Code { get; set; }


        public ListUserStatusResponse Data { get; set; }

        /// <summary>
        /// List of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages, if any")]
        public string Message { get; set; }
    }
}
