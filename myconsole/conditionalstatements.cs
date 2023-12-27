using System;

class ConditionalStatementsExample
{
    public static void MyConditionalStatementsExamples()
    {      
        int age = 85;
        if (age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }

        Console.WriteLine(); 
        string player = "Virat";

        if (player == "Rohit")
        {
            Console.WriteLine("He is from MI");
        }
        else if (player == "Virat")
        {
            Console.WriteLine("He is from RCB");
        }
        else if (player == "Mahi")
        {
            Console.WriteLine("He is from Csk");
        }
        else
        {
            Console.WriteLine("HE dont play IPL");
        }
        Console.WriteLine();
       
        Console.WriteLine("While Loop Example:");
        int counter = 0;
        while (counter < 5)
        {
            Console.WriteLine($"Counter: {counter}");
            counter++;
        }

        Console.WriteLine();

        
        Console.WriteLine("Do-While Loop Example:");
        int doWhileCounter = 0;
        do
        {
            Console.WriteLine($"Do-While Counter: {doWhileCounter}");
            doWhileCounter++;
        } while (doWhileCounter < 5);
    }
}