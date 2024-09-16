namespace LogChallenge
{
public static class Program
{
public static void Main(string[] args)
{

Using the Log


var calculator = new Calculator.Calculator();
Console.WriteLine($"The square root of 2 is
{calculator.SquareRoot(2)}");
}
}
}
namespace LogChallenge.Calculator
{
public class Calculator
{
public int Add(int left, int right)
{
return left + right;
}
public int Subtract(int left, int right)
{
return left - right;
}
public int Multiply(int left, int right)
{
return left * right;
}
public int IntDivision(int left, int right)
{
return left / right;
}
public double Division(double left, double right)
{
return left / right;
}
public int Modulus(int left, int right)
{


return left % right;
}
public double SquareRoot(double x)
{
return Math.Sqrt(x);
}
}
}