using AutoMapper;

namespace Template.Mapper
{
    public class Service2LogicMapping : Profile
    {
        public Service2LogicMapping()
        {
            CreateMap<Service.Model.ClientResponse, Logic.Model.ClientResponse>();
        }
    }
}
