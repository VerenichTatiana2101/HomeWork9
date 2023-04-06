// Задача 68: 
// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Вводим первое число M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим второе число N:");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM >= 0 && numN >= 0)
{
    Console.WriteLine($"Значения функции Аккермана для чисел {numM}, {numN} -> {AckermanFunction(numM, numN)}");
}
else System.Console.WriteLine("Функция принимает только неотрицательные целые числа");

int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AckermanFunction(n - 1, 1);
    else return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}




