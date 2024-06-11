namespace ConsoleApp1.Classes;

public class DebitCard : Card
{
    public DebitCard(string cardHolderName, string cardNumber, string accountNumber) : base(cardHolderName, cardNumber, "N/A", accountNumber)
    {
        
    }
    public override void ShowCardDetails()
    {
        Console.WriteLine($"Debit Card:\nCard Holder: {CardHolderName}\nCard Number: {CardNumber}\nAccount Number: {AccountNumber}\nExpiry Date: {ExpiryDate}" + "\n");
    }
}