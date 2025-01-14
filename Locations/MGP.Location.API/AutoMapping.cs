using AutoMapper;
using MGP.Location.API.Controllers.V1.Street.Request;
using MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId;
using MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId;
using MGP.Location.Application.UseCase.V1.Locality.GetLocality;
using MGP.Location.Application.UseCase.V1.Province.GetAll;
using MGP.Location.Application.UseCase.V1.Street.GetStreetsByName;
using MGP.Location.Client.DTOs.Department;
using MGP.Location.Client.DTOs.Locality;
using MGP.Location.Client.DTOs.Province;
using MGP.Location.Persistance.Data.Tables;
using MGP.Location.Persistance.DTOs.Department;
using MGP.Location.Persistance.DTOs.Province;
using MGP.Location.Persistance.DTOs.Street;

namespace MGP.LocationAPI
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            ModelToRequest();
            RequestToDTO();
            DTOToEntity();
            EntityToDTO();
            DTOToResponse();
            ClientToDTO();
        }

        #region Request To Database
        private void ModelToRequest()
        {
            CreateMap<GetStreetsByNameRequestModel, GetStreetsByNameRequest>();
        }

        private void RequestToDTO()
        {
            CreateMap<GetAllProvincesRequest, ProvinceData>();
            CreateMap<GetLocalitiesByDepartmentIdRequest, LocalityData>();
            CreateMap<GetDepartmentsByProvinceIdRequest, DepartmentData>();
            CreateMap<GetStreetsByNameRequest, StreetData>();
            CreateMap<GetLocalityRequest, LocalityDetailDto>();
        }

        private void DTOToResponse()
        {
            CreateMap<ProvinceData, GetAllProvincesResponse>();
            CreateMap<LocalityData, GetLocalitiesByDepartmentIdResponse>();
            CreateMap<DepartmentData, GetDepartmentsByProvinceIdResponse>();
            CreateMap<StreetData, GetStreetsByNameResponse>();
            CreateMap<LocalityDetailDto, GetLocalityResponse>();
        }

        private void DTOToEntity()
        {
            CreateMap<ProvinceData, Province>();
            CreateMap<LocalityData, Locality>();
            CreateMap<DepartmentData, Department>();
            CreateMap<StreetData, Street>();
        }

        public void ClientToDTO()
        {
            CreateMap<Provincia, ProvinceData>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));

            CreateMap<Localidad, LocalityData>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));

            CreateMap<Departamento, DepartmentData>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));
        }
        #endregion

        #region Database To Response
        private void EntityToDTO()
        {
            CreateMap<Province, ProvinceData>();
            CreateMap<Locality, LocalityData>();
            CreateMap<Department, DepartmentData>();
            CreateMap<Street, StreetData>();
        }
        #endregion
    }
}
