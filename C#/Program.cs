using System;

class Program
{
    static int Sum(ref int A)
    {
        char X;
        int Y;
        X = Convert.ToChar(Console.ReadLine());
        if (X == '+')
        {
            Y = Convert.ToInt32(Console.ReadLine());
            if (Y < 10 && Y >= 0 )
                return A + Sum(ref Y);
            else
                return A;
        }
        else
            return A;
    }

    static void PrimeFactors(int n, int[] pF, int N, ref int count)
    {
        if (count == N)
            return;
        if (n % 2 == 0)
        {
            pF[count] = 2;
            n = n / 2;
            count++;
            PrimeFactors(n, pF, N, ref count);
            return;
        }
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                pF[count] = i;
                n = n / i;
                i += 2;
                count++;
                PrimeFactors(n, pF, N, ref count);
                return;
            }
        }
        if (n > 2)
        {
            pF[count] = n;
        }
    }

    static void Main()
    {
        int A, Numb;
        Numb = Convert.ToInt32(Console.ReadLine());
        switch (Numb)
        {
            case 1:
                {
                    A = Convert.ToInt32(Console.ReadLine());
                    if (A < 10 && A >= 0)
                        Console.WriteLine(Sum(ref A));
                    else
                        Console.WriteLine(0);
                }
                break;
            case 2:
                {
                    int Step = 1;
                    int score = 0;
                    int res = 0;
                    int pict;
                    A = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        int[] fP = new int[A];
                        int count = 0;
                        score = 1;
                        PrimeFactors(Step, fP, A, ref count);
                        for (int i = 0; i < A; i++)
                            score *= fP[i];
                        if (Step == score && fP[0] != fP[A - 1])
                        {
                            pict = fP[0];
                            for (int i = A - 2; i >= 0; i--)
                            {
                                pict *= fP[i];
                                if (score % pict == 0)
                                    res++;
                            }
                            break;
                        }
                        Step++;
                    }
                    Console.WriteLine(res);
                }
                break;
            default:
                break;
        }
    }
}
