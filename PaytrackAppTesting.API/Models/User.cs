using PaytrackAppTesting.API.Enums;

namespace PaytrackAppTesting.API.Models
{
    public class User : BaseEntity
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

    /*
     public async Task<Result<Guid>> CreateReservoirAsync(CreateReservoirCommand command)
        {
            var reservoir = await _dbContext.Reservoirs.FirstOrDefaultAsync(reservoir => reservoir.Name.ToLower() == command.Name.ToLower());
            if (reservoir != null)
            {
                return Failed<Guid>("Reservoir is already existing.");
            }
            reservoir = new Reservoir
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                FieldId = command.FieldId
            };

            _dbContext.Reservoirs.Add(reservoir);
            var response = await _dbContext.SaveChangesAsync();
            if (response > 0)
            {
                return Succeeded(reservoir.Id);
            }

            return Failed<Guid>($"Failed to create reservoir.");
        }
     */

}
