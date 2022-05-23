// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] array = new int [123];

void FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0,1000);
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

int count = 0;
for (int x=0; x<array.Length; x++)
{
    if (array[x]>=10 && array[x]<=99) count = count + 1;
}
Console.WriteLine();
Console.WriteLine($"количество элементов из отрезка [10,99] равно {count}");

