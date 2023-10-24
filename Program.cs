
using System;

namespace PrimeNumbers
{
    class Program
    {
        void CheckPrime(int num)
        {
            // blah blah blah
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to check:")
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;

            for (int i =1; i <=number; i++){
                if (number % i == 0) {
                    divisors++;
                }
            }

            if (divisors == 2)
            {
                Console.WriteLine("The entered number is prime");
            }
            else{
                Console.WriteLine("The entered number is not prime")
            }
        }
    }
}

// using System;

// namespace PrimeNumbers
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a prime number");
//             int number;
//             int divisors = 0;
//             number = Convert.ToInt32(Console.ReadLine());
//             for (let i =0; i<=number; i++)
//             {
//                 if (number % i == 0)
//                 {
//                     divisors++
//                 }
//             }
//         }
//     }
// }