/* Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами. */


Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());
string[] array = new string[n]; 
for (int i = 0; i < n; i++)     
{
    Console.Write($"Введите строку {i + 1}: ");
    array[i] = Console.ReadLine();
}
string[] newArray = GetShortStrings(array);
Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
foreach (string str in newArray)
{
    Console.WriteLine(str);
}
static string[] GetShortStrings(string[] array)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int index = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            newArray[index] = str;
            index++;
        }
    }

    return newArray;
}