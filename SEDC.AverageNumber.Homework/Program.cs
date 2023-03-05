// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello There!");

Console.Write("Enter first number: ");
int num1;
bool num1Parse=int.TryParse(Console.ReadLine(), out num1);


Console.Write("Enter second number: ");
int num2;
bool num2Parse=int.TryParse(Console.ReadLine(),out num2);


Console.Write("Enter third number: ");
int num3;
bool num3Parse = int.TryParse(Console.ReadLine(), out num3);


Console.Write("Enter fourth number: ");
int num4;
bool num4Parse = int.TryParse(Console.ReadLine(), out num4);

if (num1Parse&&num2Parse&&num3Parse&&num4Parse)
{
     Console.WriteLine((num1+num2+num3+num4)/4);
}
else
{
    Console.WriteLine("Invalid input!");
}



