using System;
using System.Linq;

namespace geektrust_family_demo
{
    public static class Calculator
    {
        public static bool CalculateBalance(Contracts.Data data)
        {
            if (data != null && data.Balances != null && data.Balances.Count > 0 && data.Loans != null && data.Loans.Count > 0)
            {
                try
                {
                    foreach (var balance in data.Balances)
                    {
                        var loanForBalance = data.Loans.FirstOrDefault(loan => loan.Bank_Name.Equals(balance.Bank_Name, StringComparison.InvariantCultureIgnoreCase) && loan.Borrower_Name.Equals(balance.Borrower_Name, StringComparison.InvariantCultureIgnoreCase));
                        var paymentForBalance = data.Payments.FirstOrDefault(loan => loan.Bank_Name.Equals(balance.Bank_Name, StringComparison.InvariantCultureIgnoreCase) && loan.Borrower_Name.Equals(balance.Borrower_Name, StringComparison.InvariantCultureIgnoreCase));

                        decimal interestAmount = GetInterestAmount(loanForBalance);
                        decimal emiPerMonth = GetEmiPerMonth(loanForBalance, interestAmount);

                        int amountPaidTillNow = GetTotalAmountPaid(balance, paymentForBalance, emiPerMonth);
                        int numberOfEmiLeft = GetTotalNumberOfEMILeft(loanForBalance, interestAmount, emiPerMonth, amountPaidTillNow);

                        Console.WriteLine(balance.Bank_Name + " " + balance.Borrower_Name + " " + amountPaidTillNow + " " + numberOfEmiLeft);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("!!! EXCEPTION !!!");
                    Console.WriteLine("ERROR MESSAGE : " + ex);
                    return false;
                }
            }
            else
                return false;
        }

        private static decimal GetEmiPerMonth(Contracts.Loan loanForBalance, decimal interestAmount)
        {
            return Decimal.Ceiling(((interestAmount + loanForBalance.Principal_Amount) / (loanForBalance.No_Of_Years * 12)));
        }

        private static decimal GetInterestAmount(Contracts.Loan loanForBalance)
        {
            return ((loanForBalance.Rate_Of_Interest / 100) * loanForBalance.Principal_Amount) * loanForBalance.No_Of_Years;
        }

        private static int GetTotalNumberOfEMILeft(Contracts.Loan loanForBalance, decimal interestAmount, decimal emiPerMonth, int amountPaidTillNow)
        {
            return (int)Decimal.Ceiling(((loanForBalance.Principal_Amount + interestAmount) - amountPaidTillNow) / emiPerMonth);
        }

        private static int GetTotalAmountPaid(Contracts.Balance balance, Contracts.Payment paymentForBalance, decimal emiPerMonth)
        {
            var amountPaidTillNow = 0;
            if (paymentForBalance != null && paymentForBalance.Emi_No <= balance.Emi_No)
                amountPaidTillNow = (int)Decimal.Ceiling((emiPerMonth * balance.Emi_No) + paymentForBalance.Lump_Sum_Amount);
            else
                amountPaidTillNow = (int)Decimal.Ceiling(emiPerMonth * balance.Emi_No);
            return amountPaidTillNow;
        }
    }
}
