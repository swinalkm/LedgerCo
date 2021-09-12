using System;

namespace geektrust_family_demo
{
    public static class Parser
    {
        public static int ParseInt(string[] words, int index)
        {
            int integer;
            if (int.TryParse(words[index], out int num) == true)
                integer = num;
            else
                throw new Exception("Invalid Input String Format for line : " + words + " index : " + index);
            return integer;
        }

        public static decimal ParseDecimal(string[] words, int index)
        {
            decimal value;
            if (decimal.TryParse(words[index], out decimal v) == true)
                value = v;
            else
                throw new Exception("Invalid Input String Format for line : " + words + " index : " + index);
            return value;
        }
    }
}
