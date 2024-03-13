namespace PaytrackAppTesting.API.Models.DTOs
{
    public class NpiDto : BaseEntity
    {
        public string Title { get; set; }
        public List<NpiPolicyRule> Rules { get; set; }
        public NpiAmount NpiAmount { get; set; }
    }
}
