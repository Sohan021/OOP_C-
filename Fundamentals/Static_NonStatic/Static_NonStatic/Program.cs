using System;

namespace Static_NonStatic
{
    class Program
    {
        //int x; // Non statuc variable
        //static int y = 200; //Static Variable
        //public Program(int x)
        //{
        //    this.x = x;
        //}
        //static void Main(string[] args)
        //{
        //    //Accessing the static variable using class name
        //    //Before object creation

        //    Console.WriteLine("Static Variable Y = " + Program.y);

        //    //Creating object1
        //    Program obj1 = new Program(50);

        //    //Creating object2
        //    Program obj2 = new Program(100);

        //    Console.WriteLine($"object1 x = {obj1.x}  object2 x = {obj2.x}");
        //    Console.WriteLine("Press any key to exit.");
        //    Console.ReadLine();
        //}


        int x; //Non-static variable
        static int y = 200; //Static Variable
        const float PI = 3.14f; //Const Variable
        readonly bool flag; //Readonly Variable
        public Program(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.y);
            Console.WriteLine(Program.PI);
            Program obj1 = new Program(50, true);
            Program obj2 = new Program(100, false);
            Console.WriteLine(obj1.x + " " + obj1.flag);
            Console.WriteLine(obj2.x + " " + obj2.flag);
            Console.WriteLine("Press any key to exist.");
            Console.ReadLine();
        }
    }
}
