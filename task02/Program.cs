// Найти сумму положительных/отрицательных элементов массива

int [] array = new int [10];

void FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(-10,10);
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
int sum = 0;
for (int x=0; x<array.Length; x++)
{
    if (array[x]<0) sum = sum+array[x];
}
Console.WriteLine();
Console.WriteLine($"Cумма отрицательных элементов массива равна {sum}");

int sumsum = 0;
for (int y=0; y<array.Length; y++)
{
    if (array[y]>0) sumsum = sumsum+array[y];
}
Console.WriteLine($"Cумма положительных элементов массива равна {sumsum}");
