using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjikstrasAlgoritm
{
    internal class Node<T>
    {
        public T Data { get; private set; }

        public List<Edge<T>> Edges { get; private set; } = new List<Edge<T>>();

        public bool Discovered { get; set; } = false;

        public Node<T> Parent { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }

        public void AddEdge(Node<T> other, float weight = 1)
        {
            Edges.Add(new Edge<T>(this, other, weight));
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
