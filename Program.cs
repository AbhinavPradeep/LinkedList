using System;

namespace LnkdList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Person P1 = new Person();
            P1.Name = "Abhinav";

            list.Add(P1);

            
            Person P2 = new Person();
            P2.Name = "Ashwini";

            Person P3 = new Person();
            P3.Name = "Pradeep";

            Person P4 = new Person();
            P4.Name = "Aadi";


            list.Add(P2);
            list.Add(P3);
            list.Add(P4);

            list.Print();

            list.Remove("Pradeep");
        }
    }
}
