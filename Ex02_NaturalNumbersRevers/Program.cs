// Показать натуральные числа от N до 1, N задано
Console.Clear();

void NaturalNumber(int n)
{
  if (n > 0)
  {
    Console.WriteLine($"Натуральные числа от {n} до 1:");
    for (int i = 1; i <= n; i++)
    {
      Console.Write((n + 1) - i + "  ");
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