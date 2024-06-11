namespace ConsoleApp1;

using ConsoleApp1.Classes;

class Program
{
    static void Main(string[] args)
    {
        Card debitCard = new DebitCard("Person1", "2400123456789012", "35201234567890");
        Card maestroCard = new Maestro("Person2", "5018123456789012345", "2029-12", "35201234567891");
        Card visaElectronCard = new VisaElectron("Person3", "4026123456789012", "2025-08", "35201234567892");
        Card visaDankortCard = new Visa("Person4", "4175001234567890", "2026-10", "35201234567893");
        Card mastercard = new Mastercard("Person5", "5112345678901234", "2024-05", "35201234567894");

        debitCard.ShowCardDetails();
        maestroCard.ShowCardDetails();
        visaElectronCard.ShowCardDetails();
        visaDankortCard.ShowCardDetails();
        mastercard.ShowCardDetails();
    }
}
