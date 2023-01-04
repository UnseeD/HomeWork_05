// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




int[] array = GetRandomArray(5, 0, 99);

PrintArray(array);
FindDiffMinNMaxN(array);

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int [length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
void FindDiffMinNMaxN(int[] array)
{
    int minN = array[0];
    int maxN = 0;
       for (int i =0; i < array.Length; i++ )
    { 
        
        if (array[i] < minN )
        {
            minN = array[i];
        }
        if (array[i] > maxN)
        {
            maxN = array[i];
        }
    }
    int diff = maxN - minN;
    System.Console.WriteLine($"min {minN}, max {maxN}; ");
    System.Console.WriteLine($"Different = {diff} ");
}

void PrintArray (int[] array)
{
    for (int i= 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}
