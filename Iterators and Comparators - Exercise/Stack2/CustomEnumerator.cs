using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack2
{
    public class CustomEnumerator<T> : IEnumerator<T>
    {
        private List<T> list;
        private int index ;
        public CustomEnumerator(List<T> data)
        {
            this.list = data;
            Reset();
        }
        public T Current
        {
            get
            {
                try
                {
                    return this.list[this.index];
                }
                catch (IndexOutOfRangeException)
                {

                    throw new Exception("No elements");
                }
            }
        }

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            index--;
            return index >= 0 && index < list.Count;
        }

        public void Reset() => index = list.Count;
        
    }
}
