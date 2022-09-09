// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int[] ConvertMas(string inputNumbers)
{
    inputNumbers = inputNumbers.Replace(" ", "");
    string[] mas1 = inputNumbers.Split(",");
    int[] mas = new int[mas1.Length];
    for (int i = 0; i < mas1.Length; i++)
    {
        mas[i] = Convert.ToInt32(mas1[i]);
    }
    return mas;
}

int Count (int [] mas)
{
    int result = 0;
    for (int i = 0; i <mas.Length; i++)
    {
        if (mas[i]>0) result++;
    }
    return result;
}

System.Console.WriteLine("Введите числа через запятую: ");
string inputData = Console.ReadLine();
System.Console.WriteLine($"Больше 0 введено: {Count(ConvertMas(inputData))} числа(чисел).");


