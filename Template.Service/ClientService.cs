using Template.Service.Interface;
using Template.Service.Model;

namespace Template.Service
{
    public class ClientService : IClientService
    {
        public ClientResponse GetClient(int id)
        {
            return new ClientResponse { Id = id, Code = "service Code " + id.ToString(), Name = "service Name " + id.ToString() };
        }
    }
}
