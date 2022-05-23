// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int [] array = new int [10];

void FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(99,999);
    }
}
FillArray (array);
Console.WriteLine("массив:");
void PrintArray(int[] array)
{
    for (int j=0; j<array.Length; j++)
    {
        Console.Write($" {array[j]} ");
    }
}
PrintArray(array);

int even_count = 0;
for (int x=0; x<array.Length; x++)
{
    if (array[x]%2==0) even_count = even_count + 1;
}
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива равна {even_count}");

int uneven_count = 0;
for (int y=0; y<array.Length; y++)
{
    if (array[y]%2>0) uneven_count = uneven_count + 1;
}
Console.WriteLine($"Количество нечетных элементов массива равна {uneven_count}");
