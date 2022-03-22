using System;

namespace Wrox.ProCSharp.Generics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Lab 4!\n");

            var list2 = new LinkedList<int>();

            list2.AddLast(1);
            list2.AddLast(3);
            list2.AddLast(5);

            list2.AddFirst(300);
            list2.AddFirst(200);
            list2.AddFirst(100);

            Console.WriteLine("\nA new list has been created and filled with INTs using AddFirst & Add Last methods!");
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }



            var list3 = new LinkedList<string>();

            list3.AddLast("2");
            list3.AddLast("four");
            list3.AddLast("foo");

            list3.AddFirst("three");
            list3.AddFirst("two");
            list3.AddFirst("one");

            Console.WriteLine("\nYet another list has been created and filled with STRINGs using AddFirst & Add Last methods!");
            foreach (string s in list3)
            {
                Console.WriteLine(s);
            }



            var list1 = new LinkedList<Person>();

            list1.AddLast(new Person("Alex", "Harmaty"));
            list1.AddLast(new Person("Chris", "Ericson"));
            list1.AddLast(new Person("Tom", "Smith"));

            list1.AddFirst(new Person("Joe", "Shmoe"));
            list1.AddFirst(new Person("Timmy", "Daniels"));
            list1.AddFirst(new Person("Eric", "Tomson"));

            Console.WriteLine("\nAn additional list has been created and filled with PERSONs using AddFirst & Add Last methods!");
            foreach (Person p in list1)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Press any key to end program");
            var end = Console.ReadLine();
        }
    }
}