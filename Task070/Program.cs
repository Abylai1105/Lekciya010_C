// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество чисел s");
int s = Convert.ToInt32(Console.ReadLine());
void FibonacciModified(int n, int m,int s)
{
    if (s==2)
        Console.Write($"{n} {m}");
    else
    {
        Console.Write(n + " " );
        FibonacciModified(m, m+n, s-1);
    }
}

FibonacciModified(n,m,s);
  

