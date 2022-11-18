var Array = CreateArrayWithRandomNumbers();
Print(Array);
CountSumOddPositions(Array);


int[] CreateArrayWithRandomNumbers(int numbers = 4, int Min = -100, int Max = 100)
{

    int[] Array = new int[numbers];

    Random random = new Random();

    for (int i = 0; i < numbers; i++)
    {

        Array[i] = random.Next(Min,Max);
    }

    return Array;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}

void CountSumOddPositions(int[] Array) {
int Sum = 0;
for (int i = 0; i < Array.Length; i+=2)
{
        Sum = Sum + Array [i];
}
Console.WriteLine($"Сумма чисел на нечетных позициях = {Sum}");
}
