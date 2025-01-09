using System;
using System.Reflection.Metadata.Ecma335;


class Program
{

    
        
    static void Main()
       



    {
        string[] names = new string[5];
        names[0] = "John";
        names[1] = "James";
        names[2] = "Jane";
        names[3] = "Jill";
        names[4] = "Jack";
        

        Console.WriteLine($"The array is: {names}");
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[3]);
        Console.WriteLine(names[4]);

        int currentYear = DateTime.Now.Year;
        Console.WriteLine(currentYear);

        int currentMonth = DateTime.Now.Month;
        Console.WriteLine(currentMonth);

        int currentDay = DateTime.Now.Day;
        Console.WriteLine(currentDay);

        int currentHour = DateTime.Now.Hour;
        Console.WriteLine(currentHour);
    }
}

//Console.WriteLine("Enter the monthly amount?");
//string monthlyAmount = Console.ReadLine();
//int monthlyAmountInt = Convert.ToInt32(monthlyAmount);
//string formattedAmount = monthlyAmountInt.ToString("f");

//Console.WriteLine($"The formatted amount is:{formattedAmount}");   

//string[] names = new string[5];
//names[0] = "John";
//names[1] = "James";
//names[2] = "Jane";
//names[3] = "Jill";
//names[4] = "Jack";
//MessageBox.Show(names[0]);  

//Console.WriteLine($"The array is: {names}");
