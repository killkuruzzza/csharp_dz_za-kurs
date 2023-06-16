/* Найти точку пересечения двух прямых, заданных уравнением 
 y = k1 * x + b1,      y = k2 * x + b2,            b1 k1 и b2 и k2 заданы
Решение: 
1. приравниваем правые части данных равенств, потому что они обе равны y:
        k1*x+b1=k2*x+b2,  выразим отсюда x: x=(b2-b1)/(k1-k2)
    затем подставим полученное значение х в выражение для у (для любого, например первого) :
        y=k1(b2-b1)/(k1-k2)+b1
2. Ответ: 
        x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1      */



Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

double[] GetPoint(double inb1, double ink1, double inb2, double ink2){
    double[] result = new double[2];
    result[0] = (inb2 - inb1) / (ink1 - ink2);
    result[1] = ink1 * (inb2 - inb1) / (ink1 - ink2) + inb1;
    return result;
}

Console.WriteLine($"Точка пересечения двух прямых X = {x:0.00} , Y = {y:0.000}");
Console.WriteLine(String.Join(", ", GetPoint(b1, k1, b2, k2)));
