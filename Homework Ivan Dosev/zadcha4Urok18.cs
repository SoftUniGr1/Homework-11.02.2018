using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachiUrok18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersToCheck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> threeNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;
            if (threeNumbers.Count>3 && threeNumbers.Count < 3)
            {
                Console.WriteLine("ERROR: You didn't enter exactly 3 numbers.");
            }
            for (int i = 0; i<numbersToCheck.Count; i++)
            {
                if (threeNumbers[0] == numbersToCheck[i])
                {
                    count++;
                    break;
                }
            }
            for (int i = 0; i < numbersToCheck.Count; i++)
            {
                if (threeNumbers[1] == numbersToCheck[i])
                {
                    count++;
                    break;
                }
            }
            for (int i = 0; i < numbersToCheck.Count; i++)
            {
                if (threeNumbers[1] == numbersToCheck[i])
                {
                    count++;
                    break;
                }
            }
            if (count >= 3)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
