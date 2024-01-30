using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDpolymorphicBehaviorThroughInterfaces
{
    public class TaxCalculatorForIN : ICountryTaxCalculator
    {
        public decimal CalculateTaxAmount()
        {
            return 5000m;
        }
    }
}
