using System.Collections.Generic;

namespace geektrust_family_demo.Contracts
{
    public class Data
    {
        public Data(List<Loan> loans, List<Balance> balances, List<Payment> payments)
        {
            Loans = loans;
            Balances = balances;
            Payments = payments;
        }

        public List<Loan> Loans { get; set; } = new List<Loan>();
        public List<Balance> Balances { get; set; } = new List<Balance>();
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
