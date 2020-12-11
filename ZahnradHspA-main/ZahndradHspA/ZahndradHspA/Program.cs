using System;

namespace ZahndradHspA
{
    class Program
    {

        class Zahnrad
        {
            static void Main(string[] args)
            {
                Double a, b, c, d, e, h, f, g, i, j, k, n;//Es sind sechs Variablen vom Typ Bouble definiert.
                Console.WriteLine("a=Modul,b=Zaehnezahl,c=Teilkreisdurchmesser,d=Breite,");//Deklariere a=Model,，b=Zaehnezahl,c=Teilkreisdurchmesser,d=Breite.
                a = Convert.ToDouble(Console.ReadLine());//Geben Sie den Wert von a über die Tastatur ein.
                b = Convert.ToDouble(Console.ReadLine());//Geben Sie den Wert von b über die Tastatur ein.
                c = Convert.ToDouble(Console.ReadLine());//Geben Sie den Wert von c über die Tastatur ein.
                d = Convert.ToDouble(Console.ReadLine());//Geben Sie den Wert von d über die Tastatur ein.
                Console.WriteLine("e=Kopfspiel,f=zahnfusshoehe,g=zahnkopfhoehe");//Deklariere e=Kopfspiel,f=zahnfusshoehe,g=zahnkopfhoehe.
                e = 0.167 * a;//Definieren e=0,167*a.
                h = 2 * a + e;//Definieren h=2*a+e.
                f = a + e;//Definieren f=a+e.
                g = a;//Definieren g=a.
                Console.WriteLine("e={0}", e);//Geben Sie den Wert von e aus.{0} ist ein Platzhalter.

                Console.WriteLine("f={0}", f);//Geben Sie den Wert von f aus.{0} ist ein Platzhalter.

                Console.WriteLine("g={0}", g);//Geben Sie den Wert von g aus.{0} ist ein Platzhalter.


                Console.WriteLine("i=Teilung");//Deklariere i=Teilung.
                i = Math.PI * a;//Definieren i=PI*a，Math.PI ist Kreiszahl.
                Console.WriteLine("i={0}", i);//Geben Sie den Wert von i aus.{0} ist ein Platzhalter.


                Console.WriteLine("j=Fusskreisdurchmesser1,n=Fusskreisdurchmesser2");//Deklariere j=Fusskreisdurchmesser1,n=Fusskreisdurchmesser2.
                j = c - 2 * (a + e);//Definieren j=c - 2 * (a + e).
                n = c + 2 * (a + e);//Definieren n=c + 2 * (a + e).
                Console.WriteLine("j={0}", j);//Geben Sie den Wert von j aus.{0} ist ein Platzhalter.

                Console.WriteLine("n={0}", n);//Geben Sie den Wert von n aus.{0} ist ein Platzhalter.

                Console.WriteLine("k=Grundkreisdurchmesser");//Deklariere k=Grundkreisdurchmesser
                k = a * b * Math.Cos(20 * Math.PI / 180);//Definieren=a * b * Cos(20 * PI / 180),Math.PI ist Kreiszahl,Math.Cos ist Cos();

                Console.WriteLine("k={0}", k);//Geben Sie den Wert von k aus.{0} ist ein Platzhalter.

                Console.ReadKey();//Pause und Ansicht.

            }
        }
    }
}

