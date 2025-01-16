namespace Application.Contracts.DigitalAccount.Dto
{
    public class UpdateDigitalAccount(float Amount)
    {
        public float Amount { get; set; } = Amount;
    }
}
