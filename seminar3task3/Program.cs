// Напишите программу ,которая принимает на вход число (N) и выдает таблицу кубв чисел от 1 до N

int InputInt (string message)
{
    System.Console.WriteLine(message+ ">");
    string?InputValue = Console.ReadLine();
    int result = Convert.ToInt32(InputValue);
    return result;
}
int number = InputInt ("Введите число N");
System.Console.WriteLine("Кубы чисел от 1 до N:");
for (int index=1; index<=number; index++)
{
    int result = index* index* index;
    System.Console.WriteLine($"{result};");
}

