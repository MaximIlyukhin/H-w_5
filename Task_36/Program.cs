// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

int GetIntFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}

int[] FillArray(int L, int Min, int Max)
{
    int[] result = new int[L];
    for (int i = 0; i < L; i++)
    {
        result[i] = new Random().Next(Min, Max+1);
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

int SummOddIndex(int L, int[] Array)
{
    int summ = 0;
    for (int i = 1; i < L; i += 2)
    {
        summ += Array[i];
    }
    return summ;
}

int message1 = GetIntFromConsole("Enter array's length = ");
int message2 = GetIntFromConsole("Enter array's min value = ");
int message3 = GetIntFromConsole("Enter array's max value = ");
int[] Arr = FillArray(message1, message2, message3);
PrintArray(Arr);
int Res = SummOddIndex(message1, Arr);
WriteLine();
WriteLine(Res);
