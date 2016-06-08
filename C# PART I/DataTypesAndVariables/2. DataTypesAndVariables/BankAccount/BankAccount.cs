/*
A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
bank name, IBAN, BIC code and 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/
using System;

class BankAccount
{
    static void Main()
    {
        string firstName, middleName, lastName;
        decimal moneyBalance;
        string bankName, IBAN;
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Personal Information:\n");
        firstName = "Diqn";
        middleName = "Todorov";
        lastName = "Bogadnov";
        Console.WriteLine("{0} {1} {2}",firstName ,middleName ,lastName);
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Amount Information:\n");
        moneyBalance = 48.2M;
        bankName = "Alpha Bank";
        IBAN = "BH 56 AAAA 7418 0123 4567 89";
        string bicCode = "FTNKSYE";
        Console.WriteLine("'{0}' has a balance of '{1} billions',\nIBAN '{2}' and BIC code '{3}'", bankName, moneyBalance, IBAN, bicCode);
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Credit Cards:\n");
        long firstCreditCard = 4162378159427672;
        long secondCreditCard = 3948276519487394;
        long thirdCreditCard = 7862439716842573; // or Int64 thirdCreditCard 
        Console.WriteLine("First credit card has '{0}' number.\nSecond credit card has '{1}' number.\nThird credit card has '{2}' number.", firstCreditCard, secondCreditCard, thirdCreditCard);
    }
}