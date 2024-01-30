using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDpolymorphicBehaviorThroughInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculatorForUS t1 =  new TaxCalculatorForUS();
            TaxCalculatorForUK t2 = new TaxCalculatorForUK();
            TaxCalculatorForIN t3 = new TaxCalculatorForIN();

            ShowDetails(t1);
            ShowDetails(t2);
            ShowDetails(t3);
        }

        public static void ShowDetails(ICountryTaxCalculator t)
        {
            decimal tax = t.CalculateTaxAmount();
            Console.WriteLine("Tax Amount : " + tax);
            Console.ReadLine();
        }
    }
}
