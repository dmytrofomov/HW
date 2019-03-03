using System;
using System.Collections.Generic;
using System.Text;

namespace Variation
{
    class Interfases
    {
        public void Example()
        {
            var myClass = new MyClass();

            //можна привести до інтерфейсу закритого більш конкретним типом
            //, але ніяких проблем не виникає так як методу який раніше приймав обджект тепер просто прийде стрінг
            IInterface<string, object> contrvariant = new MyClass();
            //так само метод який повертав стрінг може легко повернути і обджект

           object result = contrvariant.Method("a");
        }
    }

    interface IInterface<in TIn, out TOut>
    {
        TOut Method(TIn a);

        // Навпаки не можна
       // TIn Method(TOut a);
    }


    class MyClass : IInterface<object, string>
    {
        public string Method(object a)
        {
            throw new NotImplementedException();
        }
    }
}
