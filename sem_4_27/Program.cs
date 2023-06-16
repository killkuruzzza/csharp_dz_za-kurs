// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());
Console.ReadLine(SumElNumbers(a));
int SumElNumbers(int numbers)
{
    int res = 0;
    int b = 0;
    //-10 < n < 10   n / 10 = 0
    while (numbers > 0)
    {
        //Прибавляем последнюю цифру
        res += numbers % 10;// <=>res = res + numbers%10
        //Уменьшяем numbers на один разряд,
        //откидываем последнюю цифру(которую прибавили в res)
        numbers /= 10;// <=> numbers = numbers /10


    }
    return res;
}


Console.WriteLine(res);