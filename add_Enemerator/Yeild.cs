using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace add_Enemerator
{
    public class Yeild
    {
        public IEnumerable GetEmumerable()
        {
            yield return "Hi";
        }

        public IEnumerator GetEmumerator()
        {
            yield return "Hi";
        }

    }
}
