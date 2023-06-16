int n = new Random().Next(1, 50);
int[] array = new int[n];
List<int> array1 = new List<int>();
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 10);
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < (n - 1 - i); j++)
    {
        if (array[j] > array[j + 1])
        {
            int R = array[j];
            array[j] = array[j + 1];
            array[j + 1] = R;
        }
    }
}
/*for (int i = 0; i < n; i++)
    Console.Write($"{array[i]}, ");*/ // проверка на сортировку

for (int i = 0; i < n; i++)
{
    if (array[i] != array[i + 1])
    {
        array1.Add(array[i]);
    }

}
for (int i = 0; i < array1.Count; i++)
    Console.Write($"{array1[i]} ;");