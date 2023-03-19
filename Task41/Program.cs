//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
int userQantity = GetQantityFromUser("Введите количество элементов: ", "Ошибка ввода!");
int[] array = FillArrayFromUser("Введите целое число: ", "Ошибка ввода!", userQantity);
int result = PositiveNumber(array);
Console.WriteLine($"{String.Join(", ", array)} -> {result}");

int GetQantityFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


int[] FillArrayFromUser(string message, string errorMessage, int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = GetNumberFromUser("Введите элемент: ", "Ошибка ввода!");

    }
return array;
}


int PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
