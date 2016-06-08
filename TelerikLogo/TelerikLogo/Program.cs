using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string N = Console.ReadLine();

        int form7To10 = 0;

        for (int i = N.Length - 1, j = 0; i >= 0; i--, j++)
        {
            form7To10 += int.Parse((N[i]).ToString()) * (int)Math.Pow(7, j);
        }

        form7To10 = form7To10 + 1;

        string from10To7 = "";

        while (form7To10 > 0)
        {
            from10To7 = from10To7 + (form7To10 % 7);
            form7To10 = form7To10 / 7;
        }

        char[] numberChar = from10To7.ToCharArray();
        Array.Reverse(numberChar);
        from10To7 = new string(numberChar);

        Console.WriteLine(from10To7);
    }
}
