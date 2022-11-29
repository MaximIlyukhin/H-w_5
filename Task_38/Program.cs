// Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using static System.Console;
Clear();

int GetintFromConsole(string message)
{
Write(message);
return int.Parse(ReadLine());
}

double[] FillArray(int L, int Min, int Max)
{
double[] result = new double[L];
for (int i = 0; i < L; i++)
{
result[i] = Math.Round(new Random().NextDouble() * (Max - Min) + Min, 2);
}
return result;
}

void PrintArray(double[] Array)
{
for (int i = 0; i < Array.Length; i++)
{
if (i == Array.Length - 1)
Write($"{Array[i]} ");
else
Write($"{Array[i]}, ");
}
}
double FindMin(double Max, double[] Array)
{
double min = Max;
for (int i = 0; i < Array.Length; i++)
{
if (Array[i] < min)
min = Array[i];
}
return min;
}
double FindMax(double Min, double[] Array)
{
double max = Min;
for (int i = 0; i < Array.Length; i++)
{
if (Array[i] > max)
max = Array[i];
}
return max;
}

void PrintMaxMinusMin(double a, double b)
{
double Minus = a - b;
Write(Minus);
}


int message1 = GetintFromConsole("Enter array's length = ");
int message2 = GetintFromConsole("Enter array's min value = ");
int message3 = GetintFromConsole("Enter array's max value = ");
double[] Arr = FillArray(message1, message2, message3);
PrintArray(Arr);
double Res1 = FindMin(message3, Arr);
double Res2 = FindMax(message2, Arr);
WriteLine();
PrintMaxMinusMin(Res2,Res1);
