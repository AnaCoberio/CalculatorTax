using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTax
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxPaid()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 15.0 / 100.0 - (HealthExpenditures * 50.0 / 100.0);
            }
            else
            {
                return (AnualIncome * 25.0 / 100.0) - (HealthExpenditures * 50.0 / 100.0);
            }

        }




    }
}
