using System;

namespace MyDonut
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, B = 0, s, t;
            var z = new double[7040];
            var b = new char[1920];
            while (true)
            {
                memset(b, ' ', 1920);
                memset(z, 0.0f, 7040);
                for(s=0; 6.28>s; s += 0.04)
                for(t=0; 6.28>t; t += 0.02)
                {
                    double c = Math.Sin(A);
                    double d = Math.Sin(B);
                    double e = Math.Sin(s);
                    double f = Math.Sin(t);
                    double g = Math.Cos(A);
                    double h = Math.Cos(B);
                    double i = Math.Cos(s);
                    double j = Math.Cos(t);
                    double k = 2 + i;
                    double D = 1 / (g*k*f + c*e + 5);
                    int x = (int)(40 + 30 * D * (k*(h*j + c*d*f) - g*d*e));
                    int y = (int)(12 + 15 * D * (k*(j*d - h*c*f) + g*h*e));
                    int o = x + 80 * y;
                    int N = (int)(8 * (j*i*d - g*i*f - c*e + h*(g*e - i*c*f)));
                    if (24>y && y>0 && x>0 && 80>x && D>z[o])
                    {
                        z[o] = D;
                        b[o] = ".,-~:;=!*#$@"[N>0 ? N : 0];
                    }
                }
                Console.Clear();
                nl(b);
                Console.Write(b);
                A += 0.04;
                B += 0.03;
            }
        }
        static void memset<T>(T[] buf, T val, int bufsz)
        {
            if (buf == null)
                buf = new T[bufsz];
            for (int i=0; i<bufsz; i++)
                buf [i] = val;
        }
        static void nl(char[] b)
        {
            for (int i=80; 1920>i; i += 80)
            {
                b[i] = '\n';
            }
        }
    }
}
