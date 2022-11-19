//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

var Array = CreateArrayWithRealNumbers();
FindMaxAndMinDiff(Array);

double[] CreateArrayWithRealNumbers()
{

    Console.Write("Введите количество элементов массива: ");
    int ElementsCount = int.Parse(Console.ReadLine()!);
    double[] Array = new double[ElementsCount];

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        Array[i] = double.Parse(Console.ReadLine()!);
    }

    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }

    return Array;
}

void FindMaxAndMinDiff(double[] Array)
{
    double minNumber = Array[0];
    double maxNumber = Array[0];
    double Diff = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < minNumber)
        {
            minNumber = Array[i];
        }
        if (Array[i] > maxNumber)
        {
            maxNumber = Array[i];
        }
        Diff = maxNumber - minNumber;
    }
    Console.WriteLine("Минимальное число: " + minNumber);
    Console.WriteLine("Максимальное число: " + maxNumber);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + Diff);

}
