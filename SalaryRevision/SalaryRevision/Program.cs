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
            int [] Salaries = new int  [count];
            int [] SalariesLength = new int [count];

            Salaries = new int [count];
           
            for (int i = 0; i < count; i++) 
            { 
            Salaries[i] =ReadInt(string.Format("Ange lön nummer {0}:", i+ 1));

             }
                   Console.Write("\n..................................");
                   Array.Copy(Salaries,SalariesLength,count);
                   Array.Sort(Salaries);
           
            if (count %2 == 0) 
             {
                int medianFirst = Salaries[Salaries.Length /2];
             }

          }
        
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

            //return ReadInt;
        }
    }
}
   