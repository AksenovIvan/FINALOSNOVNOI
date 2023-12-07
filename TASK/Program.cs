//  Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

void PrintArray(string[] array, int size)
{
    int i = 0;
    System.Console.Write($"[{array[i]}");
    for (i = 1; i < size; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.Write("]");
}

int NewSize(string[] array, int size)
{
    int countLess3 = 0;
    for (int i = 0; i < size-1; i++)
    {
        if (array[i].Length < 3)
        {
            countLess3++;
        }
    }
    return countLess3;
}

System.Console.WriteLine("Введите планируемое количество эллементов");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
string[] massive = new string[size];
for (int i = 0; i < size - 1; i++)
{
    while (count < size)
    {
        Console.Clear();
        System.Console.WriteLine("Введите элемент массива: ");
        massive[i] = Convert.ToString(Console.ReadLine());
        count++;
        i++;
    }
}

PrintArray(massive, size);



