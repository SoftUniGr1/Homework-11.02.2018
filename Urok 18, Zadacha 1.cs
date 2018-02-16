using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_na_susedni_ednakvi_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i + 1] = nums[i] + nums[i + 1];
                    nums.RemoveAt(i);
                    i = - 1;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
