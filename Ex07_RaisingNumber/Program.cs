// Написать программу возведения числа А в целую стень B
Console.Clear();

Double exponentiation(Double arg1, Double arg2)
{
    Double result = 0;
    result = Math.Pow(arg1, arg2);
    return result;
}

Console.Write("Введите число возмодимое в степень: ");
Double num1 = int.Parse(Console.ReadLine());
Console.Write("Введите степень числа: ");
Double num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Результат возведения в степень: "+ exponentiation(num1, num2));