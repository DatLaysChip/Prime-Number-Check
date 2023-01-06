using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMENUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false; //used for doing multiple prime number tests
            do
            {
                List<int> PrimeNumbers = new List<int>();
                int primeCount = 0;
                Console.WriteLine("What number do you wish to see all the prime numbers between?");
                Console.WriteLine("First number: ");
                int trueFirstNumber = Convert.ToInt32(Console.ReadLine());
                int firstNumber = trueFirstNumber;
                if (firstNumber <= 2)
                {
                    firstNumber = 2;
                    PrimeNumbers.Add(2);
                    primeCount++;
                }
                Console.WriteLine("Second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                

                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    bool isPrime = true;
                    int j = 2;
                    do
                    {
                        int check = i % j;
                        if (check == 0)
                        {
                            isPrime = false;
                        }
                        j++;
                    } while (j <= 7 && j < i && isPrime == true);
                    if (isPrime)
                    {
                        primeCount++;
                        PrimeNumbers.Add(i);
                    }
                }

                Console.WriteLine($"There are {primeCount} prime numbers between {trueFirstNumber} and {secondNumber}");
                Console.WriteLine("Do you wish to see all of them?");
                string userAnswer = Console.ReadLine();
                userAnswer = userAnswer.ToUpper();

                if (userAnswer.Substring(0) == "Y")
                {
                    Console.WriteLine("--------------------------");
                    foreach (int i in PrimeNumbers)
                    {
                        if (PrimeNumbers[PrimeNumbers.Count()-1] == i)
                        {
                            Console.Write($"{i}.\n\n");
                        }
                        else
                        {
                            Console.Write($"{i}, ");
                        }
                    }
                }
                Console.WriteLine();
                if (!done)
                {
                    Console.WriteLine("Do you want to run another test? (Yes or no)");
                    string reTest = Console.ReadLine();
                    reTest = reTest.ToUpper();
                    if (reTest.Substring(0) == "N")
                    {
                        done = true;
                    }
                }
            } while (!done);
            
            
            





            Console.ReadKey();
        }
    }
}
