//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

///[345, 897, 568, 234] -> 2

//1. Задать массив

var Array = CreateArrayWithRandomNumbers();
Print(Array);
CountEvenNumbers(Array);


int[] CreateArrayWithRandomNumbers(int numbers = 4, int Min = 100, int Max = 999)
{

    int[] Array = new int[numbers];

    Random random = new Random();

    for (int i = 0; i < numbers; i++)
    {

        Array[i] = random.Next(Min, Max);

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

int CountEvenNumbers(int[] Array)
{

    int Evens = 0;

    for (int i = 0; i < Array.Length; i++)
    {

        if (Array[i] % 2 == 0) Evens++;
    }
    Console.WriteLine("Количество четных чисел: " + Evens);
    return Evens;
}

//2. Посчитать числа, к-ые делятся на 2 без остатка
