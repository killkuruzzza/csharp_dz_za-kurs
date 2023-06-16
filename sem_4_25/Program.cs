// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("введите число A(основание)");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B(степень)");

int B = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(A, B));

int Pow(int number, int rank)
{
    int comp = 1;
    for (int i = 1; i <= rank; i++)
    {
        comp = comp * number;
    }
    return comp;
}
