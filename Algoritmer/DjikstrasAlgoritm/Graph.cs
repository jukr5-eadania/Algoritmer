using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjikstrasAlgoritm
{
    internal class Graph<T>
    {
        public List<Node<T>> Nodes { get; private set; } = new List<Node<T>>();

        public void AddNode(T data)
        {
            Nodes.Add(new Node<T>(data));
        }

        public void AddDirectionalEdge(T from, T to, float weight = 1)
        {
            Node<T> fromNode = Nodes.Find(x => x.Data.Equals(from));

            Node<T> toNode = Nodes.Find(x => x.Data.Equals(to));

            if (!fromNode.Equals(default(T)) && !toNode.Equals(default(T))) 
            {
                fromNode.AddEdge(toNode);
            }
            else
            {
                Console.WriteLine("Node not found");
            }
        }

        public void AddEdge(T from, T to, float weight = 1)
        {
            Node<T> fromNode = Nodes.Find(x => x.Data.Equals(from));

            Node<T> toNode = Nodes.Find(x => x.Data.Equals(to));

            if (!fromNode.Equals(default(T)) && !toNode.Equals(default(T)))
            {
                fromNode.AddEdge(toNode);
                toNode.AddEdge(fromNode);
            }
            else
            {
                Console.WriteLine("Node not found");
            }
        }
    }
}
