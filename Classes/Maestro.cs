namespace ConsoleApp1.Classes;

public class Maestro : Card
{
    public Maestro(string cardHolderName, string cardNumber, string expiryDate, string accountNumber) : base(cardHolderName, cardNumber, expiryDate, accountNumber)
    {
        
    }

    public override void ShowCardDetails()
    {
        Console.WriteLine($"Maestro Card:\nCard Holder: {CardHolderName}\nCard Number: {CardNumber}\nAccount Number: {AccountNumber}\nExpiry Date: {ExpiryDate}" + "\n");
    }
}