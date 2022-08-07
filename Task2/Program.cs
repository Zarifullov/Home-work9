// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 0;
int n = 0;
int sum = 0;

int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);


if (m > n) 
{
Console.WriteLine("Не корректный ввод");
}
else
{

PrintSum(m, n, sum);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum}");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}
}