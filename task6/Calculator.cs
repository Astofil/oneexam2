public class Calculator
{
    public long Factorial(long N)
    {
        int p=1;
        for(int i=1;i<=N;i++)
        {
            p*=i;
        }
        return p;
    }
    public double Multiple(double a,double b)
    {
        return a*b;
    }
    public double Division(int c,int d)
    {
        return c/d;
    }
}
