using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahnrad
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, d, e, h, f, g, i, j, k, l, m, n;
            Console.WriteLine("a=Modul,b=Zaehnezahl,c=Teilkreisdurchmesser,d=Breite,");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("e=Kopfspiel,f=zahnfusshoehe,g=zahnkopfhoehe");
            e = 0.167 * a;
            h = 2 * a + e;
            f = a + e;
            g = a;
            Console.WriteLine("e=");
            Console.WriteLine(e);
            Console.WriteLine("f=");
            Console.WriteLine(f);
            Console.WriteLine("g=");
            Console.WriteLine(g);

            Console.WriteLine("i=Teilung");
            i = Math.PI * a;
            Console.WriteLine("i=");
            Console.WriteLine(i);

            Console.WriteLine("j=Fusskreisdurchmesser1,n=Fusskreisdurchmesser2");
            j = c - 2 * (a + e);
            n = c + 2 * (a + e);
            Console.WriteLine("j=");
            Console.WriteLine(j);
            Console.WriteLine("n=");
            Console.WriteLine(n);

            Console.WriteLine("k=Grundkreisdurchmesser1,l=Grundkreisdurchmesser2,m=Grundkreisdurchmesser3");
            k = c + 2 * a;
            l = a * (b + 2);
            m = a * (b - 2);
            Console.WriteLine("k=");
            Console.WriteLine(k);
            Console.WriteLine("l=");
            Console.WriteLine(l);
            Console.WriteLine("m=");
            Console.WriteLine(m);
            Console.ReadKey();








        }
    }
}
