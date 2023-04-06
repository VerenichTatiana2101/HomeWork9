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

int result = AckermanFunction(numM, numN);

if (numN >= 0 && numM >= 0)
{
    Console.WriteLine($"{result}");
}
else Console.WriteLine("В качестве параметров функция принимает два неотрицательных целых числа");

int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AckermanFunction(n - 1, 1);
    else return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}


