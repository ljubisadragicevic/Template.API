using Template.Logic.Interface;
using Template.Logic.Model;

namespace Template.Logic
{
    public class ClientLogic : IClientLogic
    {
        public ClientResponse GetClient(int id)
        {
            return new ClientResponse { Id = id, Code = "Code " + id.ToString(), Name = "Name " + id.ToString() };
        }
    }
}
