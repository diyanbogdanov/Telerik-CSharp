using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math11Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberInRow = new List<int>();

            for (int index = 1; index <= 8; index++)
            {
                numberInRow.Add((index * index) -17 * index);
                Console.WriteLine(numberInRow[index - 1]);
            }
        }
    }
}
