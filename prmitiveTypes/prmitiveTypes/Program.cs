using System;

namespace prmitiveTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        { //primitives data types:  
            byte number = 100;
            int count = 1345;
            float decNumber = 23345.454f;
            double largerDecNumber = 1212321312.475643726732463762;
            bool isWorking = false;

            //var keyword decides data type in runtype
            var firstName = "Parthib";

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(decNumber);
            Console.WriteLine(number.GetType());
        }
    }
}
