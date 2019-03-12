using System;

namespace add_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyClass();
            IDerived b = a;

            b.Dima();
            ////
            ///
            var d = new DateTimeProp();
            var newDate = d.MyProperty.AddDays(2.0);
            Console.WriteLine(d.MyProperty + " old date");
            Console.WriteLine(newDate + " new date");
        }
    }

    interface IBase
    {
        void Dima();
    }

    interface IDerived : IBase
    {
        new void Dima();
    }

    interface IDifferent
    {
        void Dima();
    }
    class MyClass : IDerived, IDifferent
    {
        void IDifferent.Dima()
        {
            Console.WriteLine("IDifferent");
        }

        void IBase.Dima()
        {
            Console.WriteLine("IBase");
        }

        void IDerived.Dima()
        {
            Console.WriteLine("IDerived");
        }
    }
}
