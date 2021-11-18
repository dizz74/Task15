using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая  прогрессия:");
            ArithProgression ap = new ArithProgression(3, 4);
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ", ap.getNext());
            }


            Console.WriteLine("");
            Console.WriteLine("Геометрическая прогрессия:");
            GeomProgression gp = new GeomProgression(1, 2);
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ", gp.getNext());
            }

            Console.ReadKey();

        }



        interface ISeries
        {
            void setStart(int x);

            int getNext();

            void reset();

        }


        class ArithProgression : ISeries
        {
            int n { get; set; }
            int d { get; set; }
            int a1 { get; set; }
            public ArithProgression(int a1, int d)
            {
                this.a1 = a1;
                this.d = d;
                n = 0;
            }
            public int getNext()
            {
                n++;
                return a1 + (n - 1) * d;
            }

            public void reset()
            {
                n = 0;
            }

            public void setStart(int x)
            {
                n = x;
            }
        }


        class GeomProgression : ISeries
        {
            int b1 { get; set; }
            int q { get; set; }

            int n { get; set; }

            public GeomProgression(int b1, int q)
            {
                this.b1 = b1;
                this.q = q;
            }

            public int getNext()
            {
                n++;
                return (int)(b1 * Math.Pow(q, n - 1));
            }

            public void reset()
            {
                n = 0;
            }

            public void setStart(int x)
            {
                n = x;
            }
        }
    }
}
