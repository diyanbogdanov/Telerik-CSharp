/*
Task 10. :
A marketing firm wants to keep record of its employees.
Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27 560 000 to 27 569 999).
Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
 */
using System;
using System.Collections.Generic;

class MarketingFirm
{
    static void Main()
    {

        string firstName = "Diqn";
        string familyName = "Todorov";
        int age = 16;
        char gender = 'm';
        long idNumber = 9610221408L; // I use "long", because i know that ID number means your personal number or as we know it PIN(Personal Identification Number).
        int uniqueEmployeeNumber = 27569777;
        Console.WriteLine("First name: {0} \nFamily name: {1} \nAge: {2} \nGender: {3} \nId number: {4} \nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, uniqueEmployeeNumber);
        /*
         Second way to do it.
           Console.WriteLine("Enter your first name:");
           string firstName = String.Concat(Console.ReadLine());
           Console.WriteLine("Enter your family name:");
           string familyName = String.Concat(Console.ReadLine());
           Console.WriteLine("Enter your age:");
           int age = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your gender (male(m) or female(f)):");
           char gender = char.Parse(Console.ReadLine());
           Console.WriteLine("Enter your ID number:");
           long idNumber = long.Parse(Console.ReadLine());
           Console.WriteLine("Enter your unique employee number:");
           int uniqueEmployeeNumber = int.Parse(Console.ReadLine());
           Console.WriteLine("\nFirst name: {0} \nFamily name: {1} \nAge: {2} \nGender: {3} \nId number: {4} \nUnique Employee Number: {5}",firstName, familyName, age, gender, idNumber, uniqueEmployeeNumber);
         */
    }
}
