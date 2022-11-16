
/* Написать программу, которая из имеющегося массива строк формирует массив из строк,     
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */


string[] array1 = FillArray();
string[] array2 = GetNewArray(array1, 3);
Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");

string[] FillArray()
{
    Console.Write("Введите 5 значений через пробел (длиной от 1 до 10 символов): ");
    return Console.ReadLine().Split();
}

string[] GetNewArray(string[] array1, int n)
{
    string[] array2 = new string[FindLessThreeSim(array1, n)];

    for (int i = 0, j = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= n)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}

int FindLessThreeSim(string[] array1, int n)
{
    int count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

