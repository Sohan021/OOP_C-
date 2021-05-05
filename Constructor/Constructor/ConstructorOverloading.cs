using System;

namespace Constructor
{
    class ConstructorOverloading
    {
        int x;
        public ConstructorOverloading()
        {
            this.x = 10;
        }
        public ConstructorOverloading(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine("the value of x:{0}", x);
        }
    }
}
