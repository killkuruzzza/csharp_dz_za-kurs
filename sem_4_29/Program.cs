// Задать массив из 8 элементов и вывести их на экран


//int num = int.Parse(Console.ReadLine());

//Каждый элемент на новой строке
int[] ReadElArray(int size)
{
    Console.WriteLine("введите элементы массива");
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = int.Parse(Console.ReadLine()); ;
    }
}


void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}