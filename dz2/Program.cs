// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number[0] == '-')
{
    if (number.Length >= 4)
    {
        Console.WriteLine(number[3]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}
else
{
    if (number.Length >= 3)
    {
        Console.WriteLine(number[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}