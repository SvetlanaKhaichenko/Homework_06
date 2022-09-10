// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] isk(string a)
{
    a = a.Replace(" ", "");
    string[] mas1 = a.Split(",");
    double[] mas = new double[mas1.Length];
    for (int i = 0; i < mas1.Length; i++)
    {
        mas[i] = Convert.ToInt32(mas1[i]);
    }
    return mas;
}

double[] intersection(double[] mas)
{
    double x = (mas[2] - mas[0]) / (mas[1] - mas[3]);
    double y = mas[1] * x + mas[0];
    double[] coordinates = { x, y };
    return coordinates;
}

void PrintRandomMas(double[] mas)
{
    for (int i = 0; i < 1; i++)
    {
        Console.Write($"({mas[i]}; ");
        for (int j = 1; j < mas.Length; j++)
        {
            Console.Write($"{mas[j]}) ");
        }
    }
}


System.Console.WriteLine("Введите числа через запятую, в следующем порядке: b1, k1, b2, k2");
PrintRandomMas(intersection(isk(Console.ReadLine())));


