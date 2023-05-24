// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

// функция ввода числа и возврата в числовом формате
int GetNumberInt(string text)
{
    Console.Write(text);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

//Генерация массива целыми числами
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    //Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        //Console.Write($"{res[i]} ");
    }
    //Console.WriteLine(" ] ");
    return res;
}

//Вывод массива
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Генерация массива из 8 элементов в заданном диапазоне и вывод на экран");
int minValue = GetNumberInt("Введите нижний диапазон - ");
int maxValue = GetNumberInt("Введите верхний диапазон - ");
int[] massiv = GetArray(8, minValue, maxValue); // 8 - размер массива
PrintArray(massiv);
