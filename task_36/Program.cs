// / Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = createRandomArray(10, 0, 20);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("сумму элементов, стоящих на нечётных позициях: " + sumNumbersOfEvenIndex(arr));


int sumNumbersOfEvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = array[i] + sum;

    }
    return sum;
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

