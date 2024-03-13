using PaytrackAppTesting.API.Enums;

namespace PaytrackAppTesting.API.Models.DTOs
{
    public class UserDto : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? PasswordHash { get; set; }
        public Role Role { get; set; }
        public string? RefreshToken { get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        public DateTime? ResetPasswordLifeSpan { get; set; }
    }
}
