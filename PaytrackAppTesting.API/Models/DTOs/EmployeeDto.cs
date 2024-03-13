namespace PaytrackAppTesting.API.Models.DTOs
{
    public class EmployeeDto : User
    {
        public Department Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDate { get; set; }
        public Organisation Organisation { get; set; }
    }
}
