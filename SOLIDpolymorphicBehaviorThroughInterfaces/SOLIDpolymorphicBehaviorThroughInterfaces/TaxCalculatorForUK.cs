using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDpolymorphicBehaviorThroughInterfaces
{
    public class TaxCalculatorForUK : ICountryTaxCalculator
    {
        public decimal CalculateTaxAmount()
        {
            return 20000m;
        }
    }
}
