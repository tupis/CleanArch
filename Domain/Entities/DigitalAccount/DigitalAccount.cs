using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.DigitalAccount
{
    public class DigitalAccount(double Amount) : BaseEntity
    {
        [Required]
        public double Amount { get; set; } = Amount;
    }
}
