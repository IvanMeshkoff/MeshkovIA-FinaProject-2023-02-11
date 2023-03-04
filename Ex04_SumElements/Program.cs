// Найти сумму элементов от M до N, N и M заданы
Console.Clear();

int NaturalNumber(int m, int n)
{

  if (m == 0 || n == 0) return 0; //Console.Write($"{N} и {M} не натуральные числа");

  if (n == 0) return (m * (m + 1)) / 2;            // Если M равно нулю
  else if (m == 0) return (n * (n + 1)) / 2;       // Если N равно нулю
  else if (n == m) return n;                       // Если M=N
  else if (n < m) return m + NaturalNumber(n, m - 1); // Если M<N
  else return m + NaturalNumber(n, m + 1);            // Если M>N  


}

Console.Write("Введите число M: ");
int NumberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumber(NumberM, NumberN));
