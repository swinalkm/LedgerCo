namespace geektrust_family_demo.Contracts
{
    public class Loan
    {
        public Loan(string bank_Name, string borrower_Name, decimal principal_Amount, decimal no_Of_Years, decimal rate_Of_Interest)
        {
            Bank_Name = bank_Name;
            Borrower_Name = borrower_Name;
            Principal_Amount = principal_Amount;
            No_Of_Years = no_Of_Years;
            Rate_Of_Interest = rate_Of_Interest;
        }

        public string Bank_Name { get; set; }
        public string Borrower_Name { get; set; }
        public decimal Principal_Amount { get; set; }
        public decimal No_Of_Years { get; set; }
        public decimal Rate_Of_Interest { get; set; }
    }
}
