using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class GenericList<T> : IEnumerable<T>
    {
        private T[] elements;

        private int index = 0;

        public GenericList()
        {
            elements = new T[4];
        }

        public void Add(T element)
        {
            if (index == elements.Length/2)
            {
                T[] tmp = elements.ToArray();

                elements = new T[elements.Length * 2];

                for (int i = 0; i < tmp.Length; i++)
                {
                    elements[i] = tmp[i];
                }
            }

            elements[index] = element;

            index++;
        }

        public void Remove(T element)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                    for (int y = 0; y < elements.Length - 1; y++)
                    {
                        elements[y] = elements[y + 1];
                        elements[y + 1] = default(T);
                    }

                    index--;
                    break;
                }
            }
        }

        public void Clear()
        {
            index = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = default(T);
            }
        }

        public void Sort()
        {
            Array.Sort(elements, 0, index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var indexo = 0;
            while (indexo < index)
            {
                yield return elements[indexo];
                indexo++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
