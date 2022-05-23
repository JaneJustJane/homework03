// Задать массив из 12 элементов, заполненных числами из [0,9]. 
            // Найти сумму положительных/отрицательных элементов массива

int [] array = new int [12];

void FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0,10);
    }
}
FillArray (array);
Console.WriteLine("массив из 12 элементов, заполненный числами от 0 до 9:");
void PrintArray(int[] array)
{
    for (int j=0; j<array.Length; j++)
    {
        Console.Write($" {array[j]} ");
    }
}
PrintArray(array);

