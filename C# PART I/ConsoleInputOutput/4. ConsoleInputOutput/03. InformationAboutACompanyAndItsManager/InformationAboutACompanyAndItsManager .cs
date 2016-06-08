/*
Task 03.
A company has name, address, phone number, fax number, web site and manager.
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints them on the console.
*/
using System;

class InformationAboutACompanyAndItsManager 
{
    static void Main()
    {
        Console.Title = "Information about a company and its manager";//Title
        Console.WriteLine("Please fill all empty places.");
        Console.Write("Company name: ");
        string companyName = Console.ReadLine(); //read company name from console
        Console.Write("Company adress: ");
        string companyAdress = Console.ReadLine();//read company adress from console
        Console.Write("Company phone number: ");
        long companyPhoneNumber = long.Parse(Console.ReadLine());//read company phone number from console
        Console.Write("Company fax: ");
        long companyFax = long.Parse(Console.ReadLine());//read company fax number from console
        Console.Write("Company website: ");
        string companyWebSite = Console.ReadLine();//read company web site from console
        Console.Write("Company manager: ");
        string companyManager = Console.ReadLine();//read company manager from console
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();//read manager first name from console
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();// read manager last name from console
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());//read manager age from console
        Console.Write("Manager phone number: ");
        long managerPhoneNumber = long.Parse(Console.ReadLine());// read manager phone number from console
        Console.WriteLine();//new line
        Console.WriteLine(new string('=', 50));//write 50 '='
        Console.WriteLine();//new line
        Console.WriteLine("Company \nName: {0} \nAdress: {1} \nPhone number: {2} \nFax number: {3} \nWebsite: {4} \nManager: {5}\n",companyName ,companyAdress, companyPhoneNumber ,companyFax, companyWebSite ,companyManager);
        Console.WriteLine(new string('-', 50));//write 50 = '-'
        Console.WriteLine();//new line
        Console.WriteLine("Manager \nFirst name: {0} \nLast name: {1} \nAge: {2} \nPhone number: {3}", managerFirstName ,managerLastName, managerAge, managerPhoneNumber);
        Console.WriteLine();//new line
        Console.WriteLine(new string('=', 50));//write 50 '='
    }
}

