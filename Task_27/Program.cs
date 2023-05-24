// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

int GetSummNumber(int value)
{
    int summ = 0;
    while (value>0)
    {
        summ = summ + (value % 10);
        value = value / 10;
    }
    return summ;
}
//Приветствие
Console.WriteLine("Нахождение суммы цифр в числе");
int numberA = GetNumberInt("Введите число - ");
Console.WriteLine($"Сумма цифр - {GetSummNumber(numberA)}");