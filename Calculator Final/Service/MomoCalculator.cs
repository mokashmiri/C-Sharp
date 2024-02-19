using System;

public class MomoCalculator : ICalculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
    public double Reminder(double a, double b)
    {
        return a % b;
    }
    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }
    public double Sqrt(double a)
    {
        if (a < 0)
        {
            throw new InvalidOperationException("Cannot calculate the square root of a negative number.");
        }
        return Math.Sqrt(a);
    }
}

