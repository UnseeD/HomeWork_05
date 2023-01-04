// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(5, 0, 99);

PrintArray(array);
SumOfHonestNumber (array);

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
void SumOfHonestNumber (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    System.Console.WriteLine($"Сумма четных чисел = {sum} ");
}