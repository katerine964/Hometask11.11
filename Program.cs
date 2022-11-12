// See https://aka.ms/new-console-template for more information
int Sum(int m, int n)
{
    if (n == m) return n;
 
    return n+Sum(m, n-1);
}
Console.Write("Введите число M: "); 
int m = Convert.ToInt32(Console.ReadLine());  
Console.Write("Введите число N: "); 
int n = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine($"Cумма чисел между числами {m} и {n} = {Sum(m,n)}");

