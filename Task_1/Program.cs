// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = GetRandomArray(5, 100, 999);

PrintArray(array);
FindHonestNumber(array);

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

void PrintArray (int[] array)
{
    for (int i= 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int FindHonestNumber (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }System.Console.Write($"Количество четных чисел в массиве = {sum}.");
    return sum;
}

