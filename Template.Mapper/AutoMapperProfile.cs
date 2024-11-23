using AutoMapper;

namespace Template.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Template.Logic.Model.ClientResponse, Template.Service.Model.ClientResponse>();
            CreateMap<Template.Service.Model.ClientResponse, Template.Logic.Model.ClientResponse>();
        }
    }
}
