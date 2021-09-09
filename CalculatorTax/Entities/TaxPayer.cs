﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CalculatorTax
{
    abstract class TaxPayer
    {

        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxPaid();

        public override string ToString()
        {
            return Name
                + ": $ "
                + TaxPaid().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
