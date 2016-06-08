using System;

class MultiverseCommunication
{
    static void Main()
    {
        string consoleInput = Console.ReadLine();
        string numberIN13 = "";
        string currentNumber = "";
        double finalNumber = 0;
        for (int i = 0; i < consoleInput.Length; i++)
        {
            currentNumber += consoleInput[i];
            if (currentNumber.Length == 3)
            {
                switch (currentNumber)
                {
                    case "CHU":
                        numberIN13 += "0";
                        currentNumber = "";
                        break;
                    case "TEL":
                        numberIN13 += "1";
                        currentNumber = "";
                        break;
                    case "OFT":
                        numberIN13 += "2";
                        currentNumber = "";
                        break;
                    case "IVA":
                        numberIN13 += "3";
                        currentNumber = "";
                        break;
                    case "EMY":
                        numberIN13 += "4";
                        currentNumber = "";
                        break;
                    case "VNB":
                        numberIN13 += "5";
                        currentNumber = "";
                        break;
                    case "POQ":
                        numberIN13 += "6";
                        currentNumber = "";
                        break;
                    case "ERI":
                        numberIN13 += "7";
                        currentNumber = "";
                        break;
                    case "CAD":
                        numberIN13 += "8";
                        currentNumber = "";
                        break;
                    case "K-A":
                        numberIN13 += "9";
                        currentNumber = "";
                        break;
                    case "IIA":
                        numberIN13 += "A";
                        currentNumber = "";
                        break;
                    case "YLO":
                        numberIN13 += "B";
                        currentNumber = "";
                        break;
                    case "PLA":
                        numberIN13 += "C";
                        currentNumber = "";
                        break;
                }
            }
        }
        for (int i = numberIN13.Length - 1; i >= 0; i--)
        {
            if (numberIN13[i] == 'A')
            {
                finalNumber += 10 * Math.Pow(13, (numberIN13.Length - 1) - i);
            }
            else if (numberIN13[i] == 'B')
            {
                finalNumber += 11 * Math.Pow(13, (numberIN13.Length - 1) -i);
            }
            else if (numberIN13[i] == 'C')
            {
                finalNumber += 12 * Math.Pow(13, (numberIN13.Length - 1) - i);
            }
            else
            {
                finalNumber += int.Parse(numberIN13[i].ToString()) * Math.Pow(13, (numberIN13.Length - 1) - i);
            }
        }
        Console.WriteLine(finalNumber);
    }
}
