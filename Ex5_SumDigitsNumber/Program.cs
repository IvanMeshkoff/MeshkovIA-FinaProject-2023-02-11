// Найти сумму цифр числа
Console.Clear();

int SumNum(int arg)
{
    if(arg<10) return arg;

    int digit = arg %10;
    int nextValue = arg/10;
     return digit+SumNum(nextValue);
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SumNum(number));