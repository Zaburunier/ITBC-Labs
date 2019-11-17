using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class SimpleStack<T> : SimpleList<T>
        where T : IComparable
    {
        public void Push(T element)
        {
            base.Add(element);
        }

        public T Pop()
        {
            SimpleListItem<T> temp = base.first;
            int counter = 1;
            while (counter++ < base.Count - 1)
            {
                temp = temp.next;
            }
            SimpleListItem<T> taken;
            if (base.Count != 1)
            {
                taken = temp.next;
                temp.next = null;
                base.last = temp;
            }
            else {
                taken = temp;
                temp = null;
                base.last = null;
            }
            base.Count--;
            return taken.data;
        }
    }
}
