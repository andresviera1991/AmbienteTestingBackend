using MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Discapacidad.API.Controllers.SwaggerExample.Response.Document
{
    public class AddDocumentToTicketResponseModel
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>200</example>
        [SwaggerSchema("Code")]
        public int Code { get; set; }

        /// <summary>
        /// Example Data list containing strings
        /// </summary>
        /// <example></example>
        [SwaggerSchema("List of strings representing data")]
        public AddDocumentResponse Data { get; set; } = new AddDocumentResponse();

        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages")]
        public string ErrorMessage { get; set; }
    }
}
