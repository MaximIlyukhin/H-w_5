// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static System.Console;
Clear();

int GetIntFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}

int[] FillArray(int L)
{
    int[] result = new int[L];
    for (int i = 0; i < L; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
            Write($"{Array[i]} ");
        else
            Write($"{Array[i]}, ");
    }
}

int CountPositiveNumbers(int L, int[] Array)
{
    int count = 0;
    for (int i = 0; i < L; i++)
    {
        if(Array[i]%2==0)
            count++;          
    }
    return count;
}

int message = GetIntFromConsole("Enter array's length = ");
int[] Arr = FillArray(message);
PrintArray(Arr);
int Res = CountPositiveNumbers(message, Arr);
WriteLine();
WriteLine(Res);
