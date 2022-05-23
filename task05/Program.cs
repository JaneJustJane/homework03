// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int [] array = new int [11];

void FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0,10);
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
Console.WriteLine();
int result = 0;
for (int x=0; x<(array.Length)/2; x++)
{
    result = array[x]*array[array.Length-1-x];
    Console.WriteLine($"произведение пар {x} чисел в одномерном массиве равно {result}");
}
