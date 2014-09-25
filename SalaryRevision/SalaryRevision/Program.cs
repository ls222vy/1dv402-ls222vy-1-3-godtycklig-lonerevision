using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfSalaries = 0;
            do
            {
                Console.Clear();

                noOfSalaries = ReadInt("Ange antal löner att mata in : ");
                Console.WriteLine();

                if (noOfSalaries >= 2)
                {
                    ProcessSalaries(noOfSalaries);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("Du måste mata in minst Två löner");
                    Console.ResetColor();
                }

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Tryck tangent för ny beräkning - Esc avslutar,");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
        static void ProcessSalaries(int count)
        {
            int medianSalary;
            int salarySpread;
            double averageSalary;
            int[] salaries = new int[count];
            int[] salariesLength = new int[count];
            //int [] SalariesSorted;

            salaries = new int[count];

            // Läs i lönerna från användaren -------------------------------------------------------------------------
            for (int i = 0; i < count; i++)
            {
                salaries[i] = ReadInt(string.Format("Ange lön nummer {0}: ", i + 1));
            }
            Console.WriteLine("..................................");
            Array.Copy(salaries, salariesLength, count);
            Array.Sort(salaries);

            // Medianlön
            // Avgör om det är ett jämnt antal löner -------------------
            if (count % 2 == 0)
            {
                // Jämnt antal löner. Slå ihop de två mittersta lönerna och dela med 2
                medianSalary = (salaries[(count / 2) - 1] + salaries[(count / 2)]) / 2;
            }
            else
            {
                // Udda antal löner
                medianSalary = salaries[(count - 1) / 2];
            }
            Console.WriteLine("Medianlön :        {0:c0}", medianSalary);

            // Medellön
            averageSalary = salaries.Average();
            Console.WriteLine("Medellön :         {0:c0}", averageSalary);

            // Lönespridning
            salarySpread = salaries.Max() - salaries.Min();
            Console.WriteLine("Lönespridning :    {0:c0}", salarySpread);
            Console.Write("...................................");
            Console.WriteLine();
            // Skriv ut lönerna i den ordning de matats in

            for (int i = 1; i <= count; i++)
            {
                Console.Write(" {0, 5} ", salaries[i - 1]);

                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

        }  // End ProcessSalaries Method

        static int ReadInt(string prompt)
        {
            string tempvar = null;

            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    tempvar = Console.ReadLine();
                    return int.Parse(tempvar);
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("Fel !'{0}, tyvärr kan inte tolkas som ett heltal", tempvar);
                    Console.ResetColor();
                }
            }
        }
    }
}
