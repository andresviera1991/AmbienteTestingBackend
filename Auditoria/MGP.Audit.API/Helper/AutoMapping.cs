using AutoMapper;
using MGP.Audit.Persistance.DTOs.Audit;

namespace MGP.Audit.API.Helper
{
    public class AutoMapping : Profile
    {
        const int IN_PROCESS = 1;

        public AutoMapping()
        {
            ModelToRequest();
            RequestToDTO();
            DTOToEntity();
            EntityToDTO();
            DTOToResponse();
        }

        #region Request To Database
        private void ModelToRequest()
        {
            
        }

        private void RequestToDTO()
        {
            
        }

        private void DTOToEntity()
        {
            CreateMap<AuditData, Persistance.Data.Tables.Audit> ();
        }
        #endregion

        #region Database To Response
        private void EntityToDTO()
        {
            CreateMap<Persistance.Data.Tables.Audit, AuditData>();

        }

        private void DTOToResponse()
        {
            
        }
        #endregion
    }
}
