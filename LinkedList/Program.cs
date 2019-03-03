using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var ll = new LinkedList<int>();

            for (int i = 0; i < 100; i++)
            {
                ll.AddItem(i);
            }
            var lastItem = ll.CurrentItem;
            var list = ll.GetAllItems();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
