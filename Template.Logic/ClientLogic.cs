using AutoMapper;
using Template.Logic.Interface;
using Template.Logic.Model;
using Template.Service.Interface;

namespace Template.Logic
{
    public class ClientLogic : IClientLogic
    {
        private readonly IMapper _mapper;
        private readonly IClientService _clientService;

        public ClientLogic(
            IMapper mapper,
            IClientService clientService)
        {
            _mapper = mapper;
            _clientService = clientService;
        }

        public ClientResponse GetClient(int id)
        {
            var serviceResponse = _clientService.GetClient(id);

            var response = _mapper.Map<ClientResponse>(serviceResponse);
  
            return response;
        }
    }
}
