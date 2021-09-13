using geektrust_family_demo.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace geektrust_family_demo
{
    public static class InputReader
    {
        public static Data ReadData(string inputFilePath)
        {
            List<Loan> loans = new List<Loan>();
            List<Balance> balances = new List<Balance>();
            List<Payment> payments = new List<Payment>();
            string line;
            StreamReader file = null;
            try
            {
                file = new StreamReader(inputFilePath);
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (words.Contains("LOAN"))
                        ReadLoan(loans, words);
                    if (words.Contains("BALANCE"))
                        ReadBalance(balances, words);
                    if (words.Contains("PAYMENT"))
                        ReadPayment(payments, words);
                }
                file.Close();
                return new Data(loans, balances, payments);
            }
            catch (Exception ex)
            {
                Console.WriteLine("!!! INVALID INPUT !!!");
                Console.WriteLine("ERROR MESSAGE : " + ex);
            }
            return null;
        }

        private static void ReadLoan(List<Loan> loans, string[] words)
        {
            loans.Add(new Loan(words[1], words[2], Parser.ParseDecimal(words, 3), Parser.ParseDecimal(words, 4), Parser.ParseDecimal(words, 5)));
        }
        private static void ReadBalance(List<Balance> balances, string[] words)
        {
            balances.Add(new Balance(words[1], words[2], Parser.ParseInt(words, 3)));
        }
        private static void ReadPayment(List<Payment> payments, string[] words)
        {
            payments.Add(new Payment(words[1], words[2], Parser.ParseDecimal(words, 3), Parser.ParseInt(words, 4)));
        }
    }
}
