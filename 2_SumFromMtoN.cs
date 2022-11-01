using System;

public class HelloWorld
{
    static int Sum(int m, int n)
        {
            if(m>n)
                return 0;
            else
                return m+Sum(m+1,n);
        }
    public static void Main(string[] args)
    {
        const int M = 4, N = 8;
        Console.WriteLine(Sum(M,N));
    }
}
