using AutoMapper;

namespace Template.Mapper
{
    public class Service2LogicMapping : Profile
    {
        public Service2LogicMapping()
        {
            CreateMap<Template.Service.Model.ClientResponse, Template.Logic.Model.ClientResponse>();
        }
    }
}
