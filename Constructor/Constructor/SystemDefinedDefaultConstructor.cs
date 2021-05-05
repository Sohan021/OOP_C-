using System;

namespace Constructor
{
    class SystemDefinedDefaultConstructor
    {
        int eid = 01, eage = 20;
        String eaddress = "Dhaka", ename = "C#";
        public void Display()
        {

            Console.WriteLine("Id is:  " + eid);
            Console.WriteLine("Name is:  " + this.ename);
            Console.WriteLine("Age is:  " + this.eage);
            Console.WriteLine("Address is:  " + eaddress);
        }
    }
}
