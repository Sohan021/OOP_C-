using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ///System Defined
            Console.WriteLine("\n***** SystemDefinedDefaultConstructor *****\n");
            SystemDefinedDefaultConstructor sd = new SystemDefinedDefaultConstructor();
            sd.Display();

            ///UserDefined
            Console.WriteLine("\n***** UserDefinedDefaultConstructor *****\n");
            UserDefinedDefaultConstructor ud = new UserDefinedDefaultConstructor();
            ud.Display();

            ///Parameterized
            Console.WriteLine("\n***** ParameterizedConstructor *****\n");
            ParameterizedConstructor e1 = new ParameterizedConstructor(101, 30, "C#", "Dhaka");
            ParameterizedConstructor e2 = new ParameterizedConstructor(101, 28, "Avi", "Saad");
            e1.Display();

            ///CopyConstructor
            Console.WriteLine("\n***** CopyConstructor *****\n");
            //CopyConstructor e3 = new CopyConstructor();
            //CopyConstructor e4 = new CopyConstructor(e3);
            //e3.Display();
            //e4.Display();


            //StaticConstructor
            Console.WriteLine("\n***** StaticConstructor *****\n");
            StaticConstructor e5 = new StaticConstructor();
            e5.Display();
            e5.Display();
            StaticConstructor e6 = new StaticConstructor();
            e6.Display();
            e6.Display();

            Console.WriteLine("\n***** PrivareConstructor *****\n");
            //PrivateConstructor p = new PrivateConstructor();


            Console.WriteLine("\n***** ConstructorOverloading *****\n");
            ConstructorOverloading obj1 = new ConstructorOverloading();
            ConstructorOverloading obj2 = new ConstructorOverloading(20);
            obj1.Display();
            obj2.Display();

            Console.ReadKey();
        }
    }
}
