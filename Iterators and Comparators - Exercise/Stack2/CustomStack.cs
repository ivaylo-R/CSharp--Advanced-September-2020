using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack2
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> list;

        public CustomStack()
        {
            this.list = new List<T>();
        }

        public void Push(List<T> collection)
        {
            foreach (var item in collection)
            {
                list.Add(item);
            }
        }

        public void Pop()
        {
            if (list.Count == 0)
            {
                throw new NotImplementedException("No elements");
            }

            int lastItemIndex = list.Count - 1;
            list.Remove(list[lastItemIndex]);

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomEnumerator<T>(list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
