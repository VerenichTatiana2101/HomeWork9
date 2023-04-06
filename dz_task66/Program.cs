// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Вводим первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе число:");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumNaturalNumsRange(m, n);

if (NaturalNumberCheck(m, n))
{
    Console.WriteLine($"{result}");
}
else Console.WriteLine("Введённое число не является натуральним или"
                       + " сумму натуральных элементов в промежутке от M до N найти нельзя");

bool NaturalNumberCheck(int num1, int num2)     //метод проверки двух чисел
{                                             
    return num1 != num2
        && num1 > 0                   //либо >= 0, если учитывать для расчёта чисел от 0
        && num2 > 0;
}

int SumNaturalNumsRange(int num1, int num2)                //рекурсивный метод нахождения суммы                                                
{                                                       //натуральных элементов в промежутке от M до N
    if (num1 == num2) return num1;
    else if (num1 < num2) return (num1 + SumNaturalNumsRange(num1 + 1, num2));
    else return (num1 + SumNaturalNumsRange(num1 - 1, num2));
}
