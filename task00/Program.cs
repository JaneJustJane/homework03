// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int [] array = new int [8];
FillArray (array);
void FillArray(int[] a)
{
    int Length = a.Length;
    int index=0;
    while (index<Length)
    {
        a[index]=new Random().Next(0,2);
        index++;
    }
}
PrintArray (array);
void PrintArray(int[] b)
{
    int len1 = b.Length;
    int index1=0;
    while (index1<len1)
    {
        Console.Write(b[index1]+" ");
        index1++;
    }
}
