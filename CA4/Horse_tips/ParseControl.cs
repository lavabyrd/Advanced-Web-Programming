using System;
namespace Horse_tips
{
    public class ParseControl
    {
        public static string DateParse(string DateRan)
        {
            DateTime ParsedDate = DateTime.Parse(DateRan);
            return ParsedDate.ToShortDateString();
        }


        public static decimal AmountParse(string amount)
        {

            try
            {
                amount = amount.Replace("m", "");
                decimal AmountOut = Decimal.Parse(amount);
                return AmountOut;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Amount entered: " + amount);
                Console.WriteLine("Try again");
                return 0;
            }

        }



        public static bool resultBoolCheck(string Result)
        {
            if (Result == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
