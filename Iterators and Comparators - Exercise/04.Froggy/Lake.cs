using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        private int index;

        public Lake(List<int> data)
        {
            this.stones = data;

        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return stones[i];
            }

            for (int i = this.stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
