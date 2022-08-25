// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = createRandomArray(123, -1000, 1000);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("количество элементов: " + countNumbersInArray(arr));

int countNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 99)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] createRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}


