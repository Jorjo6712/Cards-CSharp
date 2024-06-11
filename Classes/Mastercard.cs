namespace ConsoleApp1.Classes;

public class Mastercard : Card
{
    public Mastercard(string cardHolderName, string cardNumber, string expiryDate, string accountNumber) : base(cardHolderName, cardNumber, expiryDate, accountNumber)
    {
        
    }

    public override void ShowCardDetails()
    {
        Console.WriteLine($"Mastercard:\nCard Holder: {CardHolderName}\nCard Number: {CardNumber}\nAccount Number: {AccountNumber}\nExpiry Date: {ExpiryDate}" + "\n");
    }
}