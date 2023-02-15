// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int SumArray(int[] sum)
{
    int result = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if(i % 2 != 0) 
        {
            result += sum[i];
        }
    }
    return result;
}

int[] array = GetArray(6, 0, 200);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");
int res = SumArray(array);
Console.WriteLine($" -> {res}");