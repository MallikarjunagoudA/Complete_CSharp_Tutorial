using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntro
{
    public class Polymorphism
    {
        public Polymorphism()
        {

        }

        public virtual void show()
        {
            Console.WriteLine("from base class");
        }
    }

    public class ChildClassA : Polymorphism
    {
        public override void show()
        {
            Console.WriteLine("from child class A");
        }
    }

    public class ChildClassB : Polymorphism
    {
        public  void show()
        {
            Console.WriteLine("from child class B");
        }
    }
}
