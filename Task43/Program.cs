//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double k1 = GetNumberFromUser("Введите k1 : ", "Ошибка ввода!");
double b1 = GetNumberFromUser("Введите b1 : ", "Ошибка ввода!");
double k2 = GetNumberFromUser("Введите k2 : ", "Ошибка ввода!");
double b2 = GetNumberFromUser("Введите b2 : ", "Ошибка ввода!");
double x = FindX(k1, k2, b1, b2);
double y = FindY(k1, k2, b1, b2, x);
Console.WriteLine($"k1={k1}, b1={b1}, k2={k2}, b2={b2} -> ({x};{y})");


double FindX(double k1, double k2, double b1, double b2)
{
    double result = (b2 - b1) / (k1 - k2);
    return result;
}

double FindY(double k1, double k2, double b1, double b2, double x)
{
    double result = k1 * (b2 - b1) / (k1 - k2) + b1;
    return result;
}

double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}