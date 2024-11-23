using Template.Logic.Interface;
using Template.Logic.Model;
using Template.Service.Interface;

namespace Template.Logic
{
    public class ClientLogic : IClientLogic
    {
        private readonly IClientService _clientService;

        public ClientLogic(IClientService clientService)
        {
            _clientService = clientService;
        }

        public ClientResponse GetClient(int id)
        {
            var response = new ClientResponse();

            var serviceResponse = _clientService.GetClient(id);

            response.Id = serviceResponse.Id;
            response.Name = serviceResponse.Name;
            response.Address = serviceResponse.Address;
            response.Code = serviceResponse.Code;

            return response;
        }
    }
}
