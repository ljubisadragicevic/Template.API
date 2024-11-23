using Template.Service.Model;

namespace Template.Service.Interface
{
    public interface IClientService
    {
        ClientResponse GetClient(int id);
    }
}
