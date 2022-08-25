// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

float[] arr = createRandomArray(10, 0, 20);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("разница между максимальным и минимальным элементов массива: " + diffMaxMin(arr));


float diffMaxMin(float[] array)
{
    float max = array[0];
    float min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    float result = max - min;
    return result;
}

float[] createRandomArray(int size, int leftRange, int rightRange)
{
    float[] array = new float[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = (float)(rand.Next(leftRange, rightRange + 1));
    }
    return array;
}
