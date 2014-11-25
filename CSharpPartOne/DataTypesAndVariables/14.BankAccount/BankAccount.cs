using System;
class BankAccount
{
    static void Main()
    {
        /*A bank account has a holder name (first name, middle name and last name), 
         * available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers 
         * associated with the account. Declare the variables needed to keep the information for a single bank account 
         * using the appropriate data types and descriptive names.
         * */
        string firstName = "Teodor";
        string middleName = "Cvetozarov";
        string lastName = "Varbanov";
        float balance = 123456789;
        string bankName = "Banka DSK";
        string IBAN = "BG 789 649 8GF";
        string BIC = "BIC123456789";
        ulong creditCard1 = 809786489;
        ulong creditCard2 = 161461321;
        ulong creditCard3 = 954654126;
    }
}
