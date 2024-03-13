namespace PaytrackAppTesting.API.Models
{
    public class Organisation : BaseEntity
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Address { get; set; }
        public PolicyTemplate Policy { get; set; }
    }
}
