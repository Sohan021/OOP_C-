using System;

namespace Constructor
{
    class StaticConstructor
    {
        int i;
        static int j;
        public StaticConstructor()
        {
            i = 100;
        }
        static StaticConstructor()
        {
            j = 100;
        }
        public void Display()
        {
            Console.WriteLine("NON STAT value of i : " + i);
            i++;
            Console.WriteLine("STAT value of j : " + j);
            j++;
        }
    }
}
