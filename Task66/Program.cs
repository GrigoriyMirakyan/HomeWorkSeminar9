/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();
int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number = 0;
    while (isInputInt)
    {
        Console.Write(text);
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if (numberInt <= 0) Console.WriteLine("Введите число больше нуля");
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

int SumNumber(int numberN, int numberM, int sum)
{
    if (numberM <= numberN)
    {
        sum = sum + numberM;
        numberM++;
        return sum = SumNumber(numberN, numberM, sum);

    }
    else return sum;
}

int M = NumberInput("число M: ");
int N = NumberInput("число N: ");
int sum = 0;
int result = SumNumber(N, M, sum);
Console.WriteLine($"M = {M}, N = {N} -> {result}");