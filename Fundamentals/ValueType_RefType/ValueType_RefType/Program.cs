using System;
/// <summary>
/// '==' is ref type
/// 'isEqual() is value type. Sometimes need override isEqual to true value type where ref type false
/// </summary>
namespace ValueType_RefType
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.FirstName = "A";
            C1.LastName = "B";

            ////Ref type false
            Customer C2 = new Customer();
            C2.FirstName = "A";
            C2.LastName = "B";

            ////Ref type True 
            //Customer C2 = C1;

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
            Console.ReadKey();
        }

        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
