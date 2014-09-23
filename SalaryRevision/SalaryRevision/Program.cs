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
           int Salaries;
           Salaries = ReadInt("Ange Antal Löner : ");
           ProcessSalaries(Salaries);
        }        

        static int ReadInt(string prompt)
        {
            while (true)
            {
                string tempvar = prompt;
                Console.Write(tempvar);
                string nrofSalaries = Console.ReadLine();
                try
                {
                    int nrofSAlaries = int.Parse(nrofSalaries);
                    if (nrofSAlaries < 2)
                    {
                        throw new OverflowException();
                    }
                    return nrofSAlaries;
                }
                catch (OverflowException)
                {   
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste mata mints två löner för att kuna genom förra");
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste skriva en siffra");
                    Console.ResetColor();
                }
            }
            
        }
        static void ProcessSalaries(int count)
        {
            int[] Salaries = new int[count];

            for (int i = 0; i < count; i++) 
               
            {
            
            }

           // throw new NotImplementedException();
            
        }
    }

}
