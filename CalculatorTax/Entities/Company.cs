using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTax
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public Company()
        {
        }

        public override double TaxPaid()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 14.0 / 100.0;
            }
            else
            {
                return AnualIncome * 16.0 / 100.0;
            }
        }
    }
}
