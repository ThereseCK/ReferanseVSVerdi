using System;
using System.Runtime.CompilerServices;
using ReferanseVSVerdi;


namespace objekter
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# : x =  {Width: 50, Height: 30};
            // Javascript : x = new {Width = 50, Height = 30};
            // Console.WriteLine("Bredden er: " + x.Width + " og Høyden er: " + x.Height);
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
        }

        private static void Test1()
        {
            /*
             Det er 2 typer i C#:
             Referansetyper -> Objekter
             Verdityper -> int, bool, double, char, float
             */
            var a = new Box
            {
                Height = 20,
                Width = 30
            };
            var b = new Box
            {
                Height = 40,
                Width = 80
            };
            var c = a;

            c.Height = 99;
            Console.WriteLine(a.Height);
        }

        private static void Test2()
        {
            var a = new Box
            {
                Height = 20,
                Width = 30
            };
            var b = new Box
            {
                Height = 20,
                Width = 30
            };
            if (a == b) Console.WriteLine(" A og B er helt like!!");
            else Console.WriteLine("A og B er desverre ikke like!  ;(");
            if (a.Height == b.Height) Console.WriteLine("A. og B. Er like;)");
            else Console.WriteLine("A og B er ikke like!");
        }

        private static void Test3()
        {
            string a = "A";
            string b = "B";
            if (a == b) Console.WriteLine("A og B er like de");
            else Console.WriteLine("A og B er like nå heller");
        }

        private static void Test4()
        {
            var a = new Box
            {
                Height = 20,
                Width = 30
            };
            var b = new Box
            {
                Height = 40,
                Width = 80
            };
            a = b;

        }

        private static void Test5()
        {
            var box = new Box
            {
                Height = 20,
                Width = 30
            };
            int i = 7;
            Console.WriteLine("Før:   " + i);
            Console.WriteLine("Før:   " + box.Height);
            DoSomethingTest(box, i);
            Console.WriteLine("Etter:   " + box.Height);
        }

        private static void DoSomethingTest(Box b, int i)
        {
            i += 10;
            b.Height += 10;
            Console.WriteLine(b.Height);
        }
    }
}



