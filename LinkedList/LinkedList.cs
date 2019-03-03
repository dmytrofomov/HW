using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T>
    {

        private LinkedList<T> PreviousItems { get; set; }

        private T LastItem { get; set; }

        public T CurrentItem => PreviousItems.LastItem;

        public void AddItem(T item)
        {
            LastItem = default(T);
            PreviousItems = new LinkedList<T>
            {
                LastItem = item,
                PreviousItems = PreviousItems
            };
        }


        public List<T> GetAllItems()
        {
            var list = new List<T>();
            //list.Add(CurrentItem);
            var prev = PreviousItems;
            while(prev != null)
            {
                list.Add(prev.LastItem);
                prev = prev.PreviousItems;
            }

            return list;
        }
    }
}
