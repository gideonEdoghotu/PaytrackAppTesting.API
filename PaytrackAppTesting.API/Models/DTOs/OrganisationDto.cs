namespace PaytrackAppTesting.API.Models.DTOs
{
    public class OrganisationDto : BaseEntity
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Address { get; set; }
        public PolicyTemplate Policy { get; set; }
    }
}
