﻿using System;
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

        Sort(names);    

        int currentYear = DateTime.Now.Year;
        Console.WriteLine(currentYear);

        int currentMonth = DateTime.Now.Month;
        Console.WriteLine(currentMonth);

        int currentDay = DateTime.Now.Day;
        Console.WriteLine(currentDay);

        int currentHour = DateTime.Now.Hour;
        Console.WriteLine(currentHour);

        int currentMinute = DateTime.Now.Minute;
        Console.WriteLine(currentMinute);

        Console.WriteLine($"The current year, month, day, hour (in 24hr format), and minutes are: \n {currentYear} \n {currentMonth} \n {currentDay} \n {currentHour} \n {currentMinute}");

    }

    private static void Sort(string[] names) // YOU NEED TO LEARN WHY YOU DID NOT UNDERSTAND THAT THIS NEEDS TO BE A METHOD FOR SORT TO WORK
    {
        Array.Sort(names); // Also need to understand why this "names" does not obtain any reference from the above "names" - like shouldent this one be different?
        Console.WriteLine($"The sorted array is: {names}"); // GOT THIS FROM INTELLISENSE. NEED TO FIGURE OUT. WHY? + HOW ARE THEY SORTED?
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[3]);
        Console.WriteLine(names[4]);
    }
    //{
    //    Sort(names); // YOu need to figure out what is going on here. Leads to some kind of overflow.
    //}
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
