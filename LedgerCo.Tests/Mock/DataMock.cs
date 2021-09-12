namespace LedgerCo.Tests.Mock
{
    public static class DataMock
    {
        public static geektrust_family_demo.Contracts.Data GetInput()
        {
            return new geektrust_family_demo.Contracts.Data(new System.Collections.Generic.List<geektrust_family_demo.Contracts.Loan>() { new geektrust_family_demo.Contracts.Loan("IBIBI", "Harry", 10222.5M, 5, 3) }, new System.Collections.Generic.List<geektrust_family_demo.Contracts.Balance>() { new geektrust_family_demo.Contracts.Balance("IBIBI", "Harry", 5) }, new System.Collections.Generic.List<geektrust_family_demo.Contracts.Payment>() { new geektrust_family_demo.Contracts.Payment("IBIBI", "Harry", 1000, 6) });
        }
        public static geektrust_family_demo.Contracts.Data GetNegativeInput()
        {
            return new geektrust_family_demo.Contracts.Data(new System.Collections.Generic.List<geektrust_family_demo.Contracts.Loan>() { new geektrust_family_demo.Contracts.Loan("IBIBI", "Harry", 10222.5M, 0, 3) }, new System.Collections.Generic.List<geektrust_family_demo.Contracts.Balance>() { new geektrust_family_demo.Contracts.Balance("IBIBI", "Harry", 5) }, new System.Collections.Generic.List<geektrust_family_demo.Contracts.Payment>() { new geektrust_family_demo.Contracts.Payment("IBIBI", "Harry", 1000, 6) });
        }
    }
}
