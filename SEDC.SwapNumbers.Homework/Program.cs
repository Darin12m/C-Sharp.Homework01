// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Input first Number: ");
double num1;
bool num1Parse=double.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("Input second Number: ");
double num2;
bool num2Parse=double.TryParse(Console.ReadLine(),out num2);

Console.WriteLine("Before swaping");
Console.WriteLine("The first number is: "+num1);
Console.WriteLine("The second number is: " +num2);




if (num1Parse&&num2Parse)
{

    double temp = num1;
    num1 = num2;
    num2 = temp;

    Console.WriteLine("After swaping");
    Console.WriteLine("The first Number : "+num1);
    Console.WriteLine("The second Number : "+num2);
    Console.Read();
}
else
{
    Console.WriteLine("Invalid Input !");
}