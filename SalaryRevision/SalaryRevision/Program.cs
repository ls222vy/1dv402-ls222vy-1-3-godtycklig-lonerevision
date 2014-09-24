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
           
            while (true)
            {
                noOfSalaries = ReadInt("Ange antal löner att mata in : ");

                if (noOfSalaries >= 2)
                {
                    break;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("Du måste mata in minst Två löner");
                    Console.ResetColor();
                } 
            }

            ProcessSalaries(noOfSalaries);
            
            {
                Console.WriteLine();
               
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Tryck tangent för ny beräkning - Esc avslutar,");
                
                Console.ResetColor();

                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Escape) 
                {
                    return;
                }
            }
        
        }
        static void ProcessSalaries(int count)
        {
            
            int MedianSalary;
             int SalarySpread;
            double AverageSalary;
            int [] Salaries = new int  [count];
            int [] SalariesLength = new int [count];
            //int [] SalariesSorted;
           
            Salaries = new int [count];
           
            // Läs i lönerna från användaren -------------------------------------------------------------------------
            for (int i = 0; i < count; i++) 
            { 
                Salaries[i] = ReadInt(string.Format("Ange lön nummer {0}: ", i+ 1));
             }
                   Console.WriteLine("..................................");
                   Array.Copy(Salaries,SalariesLength,count);
                   Array.Sort(Salaries);
           
            // Medianlön
            // Avgör om det är ett jämnt antal löner -------------------
            if (count % 2 == 0) 
             {
                // Jämnt antal löner. Slå ihop de två mittersta lönerna och dela med 2
                 MedianSalary = (Salaries[(count / 2)-1] + Salaries[(count / 2)]) / 2;
             }
            else 
            {
                // Udda antal löner
                MedianSalary = Salaries[(count-1) / 2];
            }
            Console.WriteLine("Medianlön :        {0:c0}", MedianSalary );

            // Medellön
            AverageSalary = Salaries.Average();
            Console.WriteLine("Medellön :         {0:c0}", AverageSalary);

            // Lönespridning
            SalarySpread = Salaries.Max() - Salaries.Min();
            Console.WriteLine("Lönespridning :    {0:c0}", SalarySpread);
            Console.Write("...................................");
            Console.WriteLine();
            // Skriv ut lönerna i den ordning de matats in
            
            for  (int i = 1; i<= count;i++)
            {
                Console.Write(" {0, 5} " , Salaries[i-1]);
               
                if (i % 3 == 0) 
                {
                Console.WriteLine();
                }

            }



        }  // End ProcessSalaries Method
        
        static int ReadInt(string prompt)
        {
            string tempvar = null;
            while(true)
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
   