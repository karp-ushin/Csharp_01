using System;

public class HelloWorld
{
    static int A(int m, int n)
        {
            if((m<0)||(n<0)) 
                throw new Exception("negative number(s)");
            if(m==0) return n+1;
            if(n==0) return A(m-1,1);
            return A(m-1,A(m,n-1));
        }
    public static void Main(string[] args)
    {
        const int M=3, N=2;
        Console.WriteLine (A(M,N));
    }
}
