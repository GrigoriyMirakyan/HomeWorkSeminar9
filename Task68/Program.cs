/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

//m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number = 0;
    while (isInputInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if (numberInt < 0) Console.WriteLine("Введите положительное число");
            else
            {
                number = numberInt;
                isInputInt = false;
            }

        }
        else
            Console.WriteLine("Ввели не число");
    }
    return number;
}

int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akerman(n - 1, 1);
    if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
    else return 0;
}


int M = NumberInput("число m  ");
int N = NumberInput("число n  ");


int A = Akerman(M, N);
Console.WriteLine($"m = {M}, n = {N} -> A({M},{N}) = {A}");

Console.WriteLine($"m = {M}, n = {N} -> A({M},{N}) = {A}");