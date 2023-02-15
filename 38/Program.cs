// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



Console.Clear();


double[] GetArray(int size, int min, int max)
{
    double[] result = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = min + (max - min) * rand.NextDouble();
    }
    return result;
}
double DifArray(double[] dif)
{
    double min = dif[0];
    double max = 0;
    double resultDif = 0;
    for (int i = 1; i < dif.Length; i++)
    {
        if (dif[i] > max)
        {
            max = dif[i];
        }
        if (min > dif[i])
        {
            min = dif[i];
        }
        resultDif = max - min;
    }
    return resultDif;
}


double[] array = GetArray(4, 0, 999);
Console.Write("[");
Console.Write(String.Join(" ", array));
Console.Write("]");
double dif = DifArray(array);
Console.WriteLine($" -> {dif}");