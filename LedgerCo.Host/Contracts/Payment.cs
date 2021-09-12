namespace geektrust_family_demo.Contracts
{
    public class Payment
    {
        public Payment(string bank_Name, string borrower_Name, decimal lump_Sum_Amount, int emi_No)
        {
            Bank_Name = bank_Name;
            Borrower_Name = borrower_Name;
            Lump_Sum_Amount = lump_Sum_Amount;
            Emi_No = emi_No;
        }

        public string Bank_Name { get; set; }
        public string Borrower_Name { get; set; }
        public decimal Lump_Sum_Amount { get; set; }
        public int Emi_No { get; set; }
    }
}
