namespace PaytrackAppTesting.API.Models
{
    public class PolicyTemplate : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Npi> Npis { get; set; }
    }
}
