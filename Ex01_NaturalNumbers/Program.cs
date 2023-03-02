// Показать натуральные числа от 1 до N, N задано
Console.Clear();

void NaturalNumber(int n)
{
  if (n > 0)
  {
    for (int i = 1; i <= n; i++)
    {
      Console.Write(i + "  ");
    }
  }
  else
  {
    Console.Write($"Введеное число {n} не является натуральным!");
  }
}

Console.WriteLine("Введите натуральное число N: ");
int Number = int.Parse(Console.ReadLine());
NaturalNumber(Number);