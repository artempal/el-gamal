using System;

namespace ElGamal
{
    class GenPrimes
    {
        static bool IsPrime(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static int Gen()
        {
            Random rnd = new Random();
            bool prime = false;
            int number = 0;
            while (prime != true) // пока число не станет простым
            {
                number = rnd.Next(4, 50); //генерируем число
                prime = IsPrime(number); // проверка на простоту
            }
            
            return number;
        }
    }
}
