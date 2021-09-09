using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculatorTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> listTaxPayers = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listTaxPayers.Add(new Individual(name, anualIncome, healthExp));

                }
                if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmp = int.Parse(Console.ReadLine());
                    listTaxPayers.Add(new Company(name, anualIncome, numberEmp));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach(TaxPayer tp in listTaxPayers)
            {
                Console.WriteLine(tp); 
            }
        }
    }
}
