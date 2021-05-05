using System;

namespace Constructor
{
    class UserDefinedDefaultConstructor
    {
        int eid, eage;
        string eaddress, ename;
        public UserDefinedDefaultConstructor()
        {
            this.eid = 100;
            this.eage = 30;
            this.ename = "C#";
            eaddress = "Dhaka";
        }
        public void Display()
        {
            Console.WriteLine("Id is:  " + eid);
            Console.WriteLine("Name is:  " + this.ename);
            Console.WriteLine("Age is:  " + this.eage);
            Console.WriteLine("Address is:  " + eaddress);
        }
    }
}
