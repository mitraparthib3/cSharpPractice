using System;

namespace operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // operators are very similar to other languages

            //exceptions operators

            //incremental 

            int a = 2;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = ++a;
            Console.WriteLine(a);
            Console.WriteLine(c);

            //addition assignment 

            a += 3; //similar to a = a + 3;

            Console.WriteLine(a);
        }
    }
}
