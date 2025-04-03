// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

// ------------------------------------------------------------------ число та його проценти --------------------------------------------------- //
Console.Write("введіть число  ");
double number = Convert.ToDouble(Console.ReadLine());

Console.Write("введіть відсоток  ");
double percent = Convert.ToDouble(Console.ReadLine());

double result = (number * percent) / 100;

Console.WriteLine(percent + "% від " + number + " = " + result);



// --------------------------------------------------------------------- числа в число ------------------------------------------------------- //
Console.Write("введіть першу цифру  ");
string num1 = Console.ReadLine();

Console.Write("введіть другу цифру  ");
string num2 = Console.ReadLine();

Console.Write("введіть третю цифру  ");
string num3 = Console.ReadLine();

Console.Write("введіть четверту цифру  ");
string num4 = Console.ReadLine();

string result1 = num1 + num2 + num3 + num4;
int number1 = Convert.ToInt32(result); 

Console.WriteLine("сформоване число " + number);

//Convert.ToInt32();                //---- перетворює "number" у number
//Convert.ToDouble();               //---- перетворює "double" у double
//змінна(наприклад int).ToString(); //---- перетворює "int" у int



