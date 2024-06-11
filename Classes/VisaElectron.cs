namespace ConsoleApp1.Classes;

public class VisaElectron : Card
{
    public VisaElectron(string cardHolderName, string cardNumber, string expiryDate, string accountNumber) : base(cardHolderName, cardNumber, expiryDate, accountNumber)
    {
        
    }

    public override void ShowCardDetails()
    {
        Console.WriteLine($"Visa Electron Card:\nCard Holder: {CardHolderName}\nCard Number: {CardNumber}\nAccount Number: {AccountNumber}\nExpiry Date: {ExpiryDate}" + "\n");
    }
}