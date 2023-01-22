/*Задача 1: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
bool Validate (int number)
{
    if (number< 1000 && number>99)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное");
    return false;
}
int number = InputInt (" введите трехзначное число");
if (Validate(number))
{
    number = number/10;
    number = number% 10;
    System.Console.WriteLine($"вторая цифра введенного числа это {number}");
}