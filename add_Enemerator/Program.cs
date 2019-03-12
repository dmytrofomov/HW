using System;
using System.Collections;

namespace add_Enemerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = new Yeild();
            var a = y.GetEmumerable();
            var b = y.GetEmumerator();

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            while (b.MoveNext())
            {
                Console.WriteLine(b.Current);
            }
        }
    }

    class MyEnumerable : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetOddEnumerator()
        {
            return new OddEnumerator();
        }

        public IEnumerator GetNotOddEnumerator()
        {
            return new NotOddEnumerator();
        }
    }

    class OddEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    class NotOddEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
