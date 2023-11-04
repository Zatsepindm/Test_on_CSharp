// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}е значение массива");
        array[i] = Console.ReadLine()!;
    }
    System.Console.WriteLine();
    return array;
}

void PrintArray(string[] array)
{
    foreach (string item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
    System.Console.WriteLine();
}

int FindSize(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
            count++;
    }
    return count;
}

string[] CreateNewArray(string[] array, int size)
{
    string[] newarray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}


Console.Clear();
Console.WriteLine("Введите размерность одномерного массива");
int n = int.Parse(Console.ReadLine()!);
if (n > 0)
{
    string[] array = new string[n];
    PrintArray(FillArray(array));
    PrintArray(CreateNewArray(array, FindSize(array)));
}
else
    System.Console.WriteLine("Введите значение размерности массива больше 0");



