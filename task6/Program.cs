var cal=new Calculator();

int N=Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Factorial of {N}: ");
Console.WriteLine(cal.Factorial(N));

var a=Convert.ToDouble(Console.ReadLine());
var b=Convert.ToDouble(Console.ReadLine());

System.Console.Write("Multiple a and b:" );
System.Console.WriteLine(cal.Multiple(a,b));

var c=Convert.ToInt16(Console.ReadLine());
var d=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Division of c and d: ");
System.Console.WriteLine(cal.Division(c,d));
