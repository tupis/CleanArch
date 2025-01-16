namespace Application.Contracts.DigitalAccount.Dto
{
    public class CreateDigitalAccountDto(float Amount)
    {
        public float Amount { get; set; } = Amount;
    }
}
