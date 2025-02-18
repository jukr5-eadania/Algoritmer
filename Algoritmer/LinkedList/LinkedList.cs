using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> First { get; set; }

        public Node<T> Last { get; set; }

        public Node<T> AddFirst(T value)
        {
            Node<T> n = new Node<T>(value);

            if (First == null)
            {
                First = n;
                Last = First;
            }
            else
            {
                First.Previous = n;
                n.Next = First;
                First = n;
            }
            return n;
        }

        public Node<T> AddLast(T value)
        {
            Node<T> n = new Node<T>(value);

            if (First == null)
            {
                First = n;
                Last = First;
            }
            else
            {
                n.Previous = Last;
                Last.Next = n;
                Last = n;
            }

            return n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = First;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
