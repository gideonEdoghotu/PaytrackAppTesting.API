using Microsoft.EntityFrameworkCore;

namespace PaytrackAppTesting.API.Models.DTOs
{
    public class NpiAmountDto : BaseEntity
    {
        public string Currency { get; set; }

        [Precision(18, 2)]
        //[Column(TypeName = "decimal(28, 6)")]
        public decimal Value { get; set; }
    }
}
