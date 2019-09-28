using System;

namespace ElGamal
{
    class GenPrimes
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
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
                number = rnd.Next(0, 5000); //генерируем число
                prime = IsPrime(number); // проверка на простоту
            }
            
            return number;
        }
    }
}
