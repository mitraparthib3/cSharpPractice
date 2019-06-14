using System;

namespace typeConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //implicit type converstion
            byte aNumber = 255;
            int anotherInt = aNumber;

            Console.WriteLine(aNumber.GetType());
            Console.WriteLine(anotherInt.GetType());

            // implicit type conversion can result data loss, complier won't allow this
            //uncommect line to see the errors

            //int highestByte = 256;
            //byte wontCompile = highestByte;


            //explicit type conversion, 

            int highestByte = 256;
            byte typeCasting = (byte)highestByte;
            Console.WriteLine(typeCasting);

            // conversion between non-compatible types

            string foo = "1";
            int convertedFoo = Convert.ToInt32(foo);
            Console.WriteLine(convertedFoo);
            Console.WriteLine(convertedFoo.GetType());
            Console.WriteLine(foo.GetType());

            //another way 

            float parsedFoo = float.Parse(foo);
            Console.WriteLine(parsedFoo);

        }
    }
}
