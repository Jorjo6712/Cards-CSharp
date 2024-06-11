namespace ConsoleApp1.Classes;

public abstract class Card
{
    public string CardHolderName { get; set; }
    public string CardNumber { get; set; }
    public string ExpiryDate { get; set; }
    public string AccountNumber { get; set; }

    public Card(string cardHolderName, string cardNumber, string expiryDate, string accountNumber)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        ExpiryDate = expiryDate;
        AccountNumber = accountNumber;
    }

    public abstract void ShowCardDetails();
}