// See https://aka.ms/new-console-template for more information
int Akkerman(int a, int b)
{
    if (a==0)
        return b+1;
    else
        {
        if(a>0 && b==0)
            return Akkerman((a-1),1);
        else
            return Akkerman(a-1,Akkerman(a,(b-1)));
        }
}
Console.Write("Введите число m: "); 
int m = Convert.ToInt32(Console.ReadLine());  
Console.Write("Введите число n: "); 
int n = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine($"Значение функции Аккермана ({m} , {n}) = {Akkerman(m,n)}");