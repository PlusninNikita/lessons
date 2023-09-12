// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double DifferenceMaxMin(double[] arr)
{
    double maxNumber = arr[0];
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber)
        {
            maxNumber = arr[i];
        }
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
        }
    }
    Console.WriteLine($"Минимальное значение {minNumber:F1}");
    Console.WriteLine($"Максимальное значение {maxNumber:F1}");
    return maxNumber - minNumber;
}

void StartDifferenceMaxMin()
{   
    Console.Clear();
    Console.WriteLine("Введите три параметра генерации массива");
    Console.Write("1. Введите размер массива: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. Минимальное значение : ");
    int minNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("3. Максимальное значение: ");
    int maxNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("------------------------");
    Console.WriteLine($"Параметры генерации массива: размер {sizeArray}, диапазон значений {minNum}-{maxNum}");
    Console.WriteLine("------------------------");

    double[] array = CreateArrayRndDouble(sizeArray, minNum, maxNum);
    PrintArrayDouble(array);
    Console.WriteLine();    
    Console.WriteLine();
    double difference = (DifferenceMaxMin(array));
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива {difference:F1}");
}

StartDifferenceMaxMin();