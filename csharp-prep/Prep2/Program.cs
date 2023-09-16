using System;

class Program
{
    static void Main(string[] args)
    {
        // How I made!

        /*Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int A = int.Parse(grade);
        int B = int.Parse(grade);
        int C = int.Parse(grade);
        int D = int.Parse(grade);
        int F = int.Parse(grade);
        
        if ( A >= 90 )
        {
            Console.WriteLine("Congratuletion");
        }
        else if ( B >= 80 )
        {
            Console.WriteLine("Congratuletion");
        }
        else if ( C >= 70 )
        {
            Console.WriteLine("Congratuletion");
        }
        else if ( D >= 60 )
        {
            Console.WriteLine("You don´t have a grade to pass");
        }
        else
        {
            Console.WriteLine("You don´t have a grade to pass");
        }
        */

        //Teacher solution
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    

    }
}