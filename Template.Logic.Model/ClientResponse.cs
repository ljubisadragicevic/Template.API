namespace Template.Logic.Model
{
    public class ClientResponse
    {
        public required int Id { get; set; }  
        public required string Code { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
