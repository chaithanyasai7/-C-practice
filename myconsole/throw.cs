using System;

public static class Throw
{
    public static void CheckEligibilityToVote(int age)
    {
       
        if (age < 18)
        {
            
            throw new InvalidOperationException("Person is not eligible to vote.");
        }

        Console.WriteLine("Person is eligible to vote.");
    }
}
