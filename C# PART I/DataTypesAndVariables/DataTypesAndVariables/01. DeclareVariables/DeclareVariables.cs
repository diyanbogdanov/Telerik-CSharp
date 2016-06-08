/*
Task 01. :
Declare five variables choosing for each of them the most appropriate of the types 
byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
52130, -115, 4825932, 97, -10000.
*/
using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstVariable = 52130; //ushort MinValue:0, MaxValue:65535
        sbyte secondVariable = -115; //sbyte MinValue:-128, MaxValue:127
        uint thirdVariable = 4825932; //uint MinValue:0, MaxValue:4294967295
        byte fourVariable = 97; //byte MinValue:0, MaxValue:255
        short fifthVariable = -10000; //short MinValue:-32768, MaxValue:32767
        Console.WriteLine("Print the variables: {0} {1} {2} {3} {4}", firstVariable, secondVariable, thirdVariable, fourVariable, fifthVariable);
    }
}