using System;


class OperatorsExample
{
    public static void myOperatorsExamples()
    {
        
        int a = 1;
        int b = 2;
        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int quotient = a / b;
        int remainder = a % b;
        Console.WriteLine($"Arithmetic Operators:");
        Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Reminder: {remainder}");
        Console.WriteLine();
        int x = 5;
        int y =3;        
        x += 3;       
        y -= 2;       
        x *= 4;       
        y /= 2;       
        x %= 3;   
        Console.WriteLine($"Assignment Operators:");
        Console.WriteLine($"x: {x}, y: {y}");
        Console.WriteLine();      
        bool isEqual = a == b;
        bool isNotEqual = a != b;
        bool isGreaterThan = a > b;
        bool isLessThan = a < b;
        bool isGreaterOrEqual = a >= b;
        bool isLessOrEqual = a <= b;
        Console.WriteLine($"Relational Operators:");
        Console.WriteLine($"Equal: {isEqual}, NotEqual: {isNotEqual}, GreaterThan: {isGreaterThan}, LessThan: {isLessThan}, GreaterOrEqual: {isGreaterOrEqual}, LessOrEqual: {isLessOrEqual}");
        Console.WriteLine();     
        bool condition1 = true;
        bool condition2 = false;
        bool andResult = condition1 && condition2;
        bool orResult = condition1 || condition2;
        bool notResult = !condition1;
        Console.WriteLine($"Logical Operators:");
        Console.WriteLine($"AND: {andResult}, OR: {orResult}, NOT: {notResult}");
        Console.WriteLine();    
        int unaryOperand = 7;
        int unaryResult = -unaryOperand;
        Console.WriteLine($"Unary Operator:");
        Console.WriteLine($"Original Value: {unaryOperand}, opposite: {unaryResult}");
        Console.WriteLine();     
        int l = 10;
        int m = 5;
        int max = (l > m) ? l : m;
        Console.WriteLine($"Conditional Operator:");
        Console.WriteLine($"The maximum of {l} and {m} is: {max}");
    }
}
