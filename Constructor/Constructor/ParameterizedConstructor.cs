using System;

namespace Constructor
{
    class ParameterizedConstructor
    {
        int eid, eage;
        String eaddress, ename;
        public ParameterizedConstructor(int id, int age, string name, string address)
        {
            this.eid = id;
            this.eage = age;
            this.ename = name;
            this.eaddress = address;
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
