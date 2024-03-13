namespace PaytrackAppTesting.API.Models.DTOs
{
    public class PolicyTemplateDto : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Npi> Npis { get; set; }
    }
}
