using System.Runtime.InteropServices;

int a, b;
Console.WriteLine("Input number from 1 to 5");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number from 5 to 10");
b = Convert.ToInt32(Console.ReadLine());
for (int i = a; i <= b; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 1; i <= 100; i++)
{
    string text = "";
    if (i % 3 == 0)
    {
         text+= "Fizz";
    }
    if (i % 5 == 0)
    {
        text += "Buzz";
    }
    if (text.Length == 0)
    {
        text = i.ToString();
    }
    Console.WriteLine(text);

}
