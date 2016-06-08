using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _9GagNumbers
{
    class Program
    {
        static string ConvertStringToInt(string digit) 
        {
            string answer = "";
            string num = "";
            for (int i = 0; i < digit.Length; i++)
            {
                num += Convert.ToString(digit[i]);
                switch (num)
                {
                    case "-!":
                        answer += "0";
                        num = "";
                        break;
                    case "**":
                        answer += "1";
                        num = "";
                        break;
                    case "!!!":
                        answer += "2";
                        num = "";
                        break;
                    case "&&":
                        answer += "3";
                        num = "";
                        break;
                    case "&-":
                        answer += "4";
                        num = "";
                        break;
                    case "!-":
                        answer += "5";
                        num = "";
                        break;
                    case "*!!!":
                        answer += "6";
                        num = "";
                        break;
                    case "&*!":
                        answer += "7";
                        num = "";
                        break;
                    case "!!**!-":
                        answer += "8";
                        num = "";
                        break;
                }
            }
            return answer;
        }

        static BigInteger CalculateNumber(string value) 
        {
            BigInteger answer = 0;
            for (int i = (value.Length - 1); i >= 0; i--)
            {
                answer += BigInteger.Parse(Convert.ToString(value[i])) * BigInteger.Pow(9, (value.Length - (i + 1)));
            }
            return answer;
        }
        static void Main()
        {
            string value = Console.ReadLine();
            Console.WriteLine(CalculateNumber(ConvertStringToInt(value)));
        }
    }
}
