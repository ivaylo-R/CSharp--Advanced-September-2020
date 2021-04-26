using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> Data { get; set; }
        private int index;
        public ListyIterator(params T[] data)
        {
            this.Data = new List<T>(data);
            this.index = 0; 
        }

        public void Print()
        {
            if (this.Data.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.Data[this.index]);
        }

        
        public bool HasNext()
        {
            return this.index+1 < this.Data.Count;
        }
        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }
            return false;
        }

        public void PrintAll()
        {
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(string.Join(" ",this.Data));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Data.Count; i++)
            {
                yield return this.Data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
