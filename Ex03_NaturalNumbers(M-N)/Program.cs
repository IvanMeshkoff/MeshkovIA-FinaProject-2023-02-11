// Показать натуральные числа от M до N, N и M заданы
Console.Clear();

void NaturalNumber(int m, int n)
{
  if (m <= 0 && n <= 0)
  {
    Console.Write($"Введеные числа {m} и {n} не являются натуральными!");
  }
  else if (m <= 0 && n > 0)
  {
    Console.Write($"Введеное число {m} не является натуральным!");
  }
  else if (m > 0 && n <= 0)
  {
    Console.Write($"Введеное число {n} не является натуральным!");
  }
  else if (m <= n)
  {
    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    for (int i = m; i <= n; i++)
    {
      Console.Write(i + "  ");
    }
  }
  else
  {
    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    for (int i = 0; i <= (m - n); i++)
    {
      Console.Write(m - i + "  ");
    }
  }
}

Console.WriteLine("Введите натуральное число M: ");
int NumberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int NumberN = int.Parse(Console.ReadLine());
NaturalNumber(NumberM, NumberN);