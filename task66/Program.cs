// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter number M : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N : ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = M;

if (M > N)
{
    Console.WriteLine("It's impossible");
    return;
}

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Sum of elements = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
PrintSumm(M, N, temp=0);