// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

int m = 0;
int n = 0;

int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

string PrintNumbers(int m, int n)
{
    if (m==n) 
        return m.ToString();
    else
    {
        return (m + "" + PrintNumbers(m + 1, n));
    }
}
if (m<n) Console.Write(PrintNumbers(m, n));
else Console.WriteLine("Не корректный ввод");
