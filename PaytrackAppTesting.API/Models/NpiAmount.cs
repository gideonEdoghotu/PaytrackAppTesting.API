namespace PaytrackAppTesting.API.Models
{
    public class NpiAmount : BaseEntity
    {
        public string Currency { get; set; }

        public decimal Value { get; set; }
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
