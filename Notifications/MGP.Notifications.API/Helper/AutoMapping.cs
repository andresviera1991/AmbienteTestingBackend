using AutoMapper;
using MGP.Notifications.Persistance.DTOs.Notifications;

namespace MGP.Notifications.API.Helper
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
            CreateMap<NotificationData, Persistance.Data.Tables.Notification> ();
        }
        #endregion

        #region Database To Response
        private void EntityToDTO()
        {
            CreateMap<Persistance.Data.Tables.Notification, NotificationData>();

        }

        private void DTOToResponse()
        {
            
        }
        #endregion
    }
}
