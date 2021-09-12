namespace geektrust_family_demo.Contracts
{
    public class Balance
    {
        public Balance(string bank_Name, string borrower_Name, int emi_No)
        {
            Bank_Name = bank_Name;
            Borrower_Name = borrower_Name;
            Emi_No = emi_No;
        }

        public string Bank_Name { get; set; }
        public string Borrower_Name { get; set; }
        public int Emi_No { get; set; }
    }
}
