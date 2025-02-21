using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjikstrasAlgoritm
{
    internal class Edge<T>
    {
        public Node<T> From { get; private set; }

        public Node<T> To { get; private set; }

        public float Weight;

        public Edge(Node<T> from, Node<T> to, float weight = 1)
        {
            this.From = from;
            this.To = to;
            this.Weight = weight;
        }
    }
}
