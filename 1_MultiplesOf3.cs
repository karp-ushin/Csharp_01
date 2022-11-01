using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        const int M = 13, N = 20;
        
        PrintMultiplesOf3(M,N);
        
    }
    static void PrintMultiplesOf3(int m, int n)
    {
        int start;
        if(m%3 != 0) start = m - m % 3 + 3;
        else start = m;
        print(start,n);
    }
    static void print(int from, int to)
    {
        if(from > to) return;
        Console.WriteLine(from);
        print(from+3,to);
    }
}
