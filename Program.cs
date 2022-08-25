using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Parent
    {
        public void print()
        {
            Console.WriteLine("Parent class");
        }
    }

    class Child:Parent
    {
        public void print()
        {
            Console.WriteLine("Child class");//parent print method is overridden
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.print();
            Console.ReadLine();
        }
    }
}
