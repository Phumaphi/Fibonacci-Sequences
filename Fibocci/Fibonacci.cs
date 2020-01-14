using System.Collections.Generic;

namespace Fibocci
{
    public class Fibonacci
    {
        public List<int> EvenSequence = new List<int>();

        public List<int> FiboSequence = new List<int>();

        public void FibonacEngine(int limit =12)
        {

            int number = 0, number1 = 1, number2 = 0;
            int sum = 0;

            while (sum <= limit && sum+number2<5000000)
            {
                number2 = number + number1;

                if (number2 % 2 == 0)
                {
                    sum += number2;

                    EvenSequence.Add(number2);
                }
                FiboSequence.Add((number2));
                number = number1;
                number1 = number2;
            }
        }
    }
}
