// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

// функция вывода числа
void WriteNumber( int value)
{
    Console.WriteLine(" " + value);
    return;
}

// функция вычисления степени числа
// int GetDegreeNumber( int number, int stepen)
// {
//     int numStepen = Convert.ToInt32(Math.Pow(number,stepen)); 
//     return numStepen;
// }

// функция вычисления степени числа чере цикл
int GetDegreeNumberCycle( int number, int stepen)
{
    //int numStepen = Convert.ToInt32(Math.Pow(number,stepen)); 
    int numStepen = 1;
    for (int degreeNum = 0; degreeNum < stepen; degreeNum++)
    {
            //Console.Write($"{numStepen} . {degreeNum}");
            numStepen = numStepen * number;   
            //Console.WriteLine($" || {numStepen} . {degreeNum}"); 
    }
    return numStepen;
}

//Приветствие
Console.WriteLine("Возведение числа A в натуральную степень B");
int numberA = GetNumberInt("Введите число А - ");
int numberB = GetNumberInt("Введите степень В числа - ");
//WriteNumber(GetDegreeNumber(numberA,numberB));
WriteNumber(GetDegreeNumberCycle(numberA, numberB));
