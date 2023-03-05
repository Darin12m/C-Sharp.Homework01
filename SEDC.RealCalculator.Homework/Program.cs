// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");


//Console.Write("Enter first number: ");
//double a=Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter second number: ");
//double b=Convert.ToDouble(Console.ReadLine());

//Console.Write("Chose operation ( +, - , * , / ): ");
//char c=Convert.ToChar(Console.ReadLine());
////bool isCParsed = char.TryParse(Console.ReadLine(), out char c);



//double result = 0;
//if (c=='+')
//{ 
//result=a+b;
//}
//else if (c=='-')
//{
//    result=a-b;
//}
//else if (c=='*') 
//{
//    result=a*b;
//}
//else 
//{
//    result=a/b;
//}

//Console.WriteLine(result);



Console.WriteLine("Enter first number: ");
double num1;
bool a = Double.TryParse(Console.ReadLine(),out num1);


Console.WriteLine("Enter second number: ");
double num2;
bool b = Double.TryParse(Console.ReadLine(), out num2);

Console.WriteLine("Chose opration ( +, - , * , / ): ");
string c= Console.ReadLine(); 

double result = 0;

if (a&&b) {


    switch (c) {

        case "+":
            result=num1+num2;
            Console.WriteLine("The result is:" + result);
            break;
           
        case "-":
            result=num1-num2;
            Console.WriteLine("The result is:" + result);
            break;

        case "*":
            result=num1*num2;
            Console.WriteLine("The result is:" + result);
            break;


        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine("The result is: " + result);
            }
            break;
            }

    }else
{
    Console.WriteLine("Invalid input!");
}





