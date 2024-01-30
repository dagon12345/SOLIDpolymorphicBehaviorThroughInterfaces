using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDpolymorphicBehaviorThroughInterfaces
{
    public class TaxCalculatorForUS : ICountryTaxCalculator
    {
        public decimal CalculateTaxAmount()
        {
            return 10000m;
        }
    }
}
