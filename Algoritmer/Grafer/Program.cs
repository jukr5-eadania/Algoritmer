using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();

            graph.AddNode("Entrance");
            graph.AddNode("FunHouse");
            graph.AddNode("Ice Blaster");
            graph.AddNode("Slot Machines");
            graph.AddNode("Hotdogs");
            graph.AddNode("Rocket Ships");
            graph.AddNode("3D Cinema");
            graph.AddNode("Log Flume");
            graph.AddNode("Big Dipper");
            graph.AddNode("Ghost Train");
            graph.AddNode("Pirate Ship");
            graph.AddNode("Rollercoaster");
            graph.AddNode("Carousel");
            graph.AddNode("Flying Chairs");

            graph.AddEdge("Entrance", "FunHouse");
            graph.AddEdge("Entrance", "Ice Blaster");
            graph.AddEdge("Entrance", "Slot Machines");

            graph.AddEdge("Ice Blaster", "Slot Machines");
            graph.AddEdge("Ice Blaster", "Rocket Ships");
            graph.AddEdge("Ice Blaster", "3D Cinema");
            graph.AddEdge("Ice Blaster", "FunHouse");

            graph.AddEdge("FunHouse", "3D Cinema");

            graph.AddEdge("3D Cinema", "Pirate Ship");

            graph.AddEdge("Slot Machines", "Hotdogs");
            graph.AddEdge("Slot Machines", "Rocket Ships");

            graph.AddEdge("Rocket Ships", "3D Cinema");
            graph.AddEdge("Rocket Ships", "Ghost Train");

            graph.AddEdge("Hotdogs", "Log Flume");

            graph.AddEdge("Log Flume", "Big Dipper");

            graph.AddEdge("Big Dipper", "Rollercoaster");
            graph.AddEdge("Big Dipper", "Ghost Train");

            graph.AddEdge("Ghost Train", "Carousel");
            graph.AddEdge("Ghost Train", "Flying Chairs");

            graph.AddEdge("Carousel", "Flying Chairs");

            Node<string> n = DFS<string>(graph.Nodes.Find(x => x.Data == "Entrance"), graph.Nodes.Find(x => x.Data == "Ghost Train"));

            List<Node<string>> path = TrackPath<string>(n, graph.Nodes.Find(x => x.Data == "Entrance"));

            foreach (Node<string> pathNode in path)
            {
                Console.WriteLine(pathNode.Data);
            }

            Console.ReadLine();
        }

        public static Node<T> DFS<T>(Node<T> start, Node<T> goal)
        {
            Stack<Edge<T>> edges = new Stack<Edge<T>>();
            edges.Push(new Edge<T>(start, start));

            while (edges.Count > 0)
            {
                Edge<T> edge = edges.Pop();

                if (!edge.To.Discovered)
                {
                    edge.To.Discovered = true;
                    edge.To.Parent = edge.From;
                }

                if (edge.To == goal)
                {
                    return edge.To;
                }


                foreach (var e in edge.To.Edges)
                {
                    if (!e.To.Discovered)
                    {
                        edges.Push(e);
                    }
                }
            }

            return null;
        }

        private static List<Node<T>> TrackPath<T>(Node<T> node, Node<T> start)
        {
            List<Node<T>> path = new List<Node<T>>();

            while (!node.Equals(start))
            {
                path.Add(node);
                node = node.Parent;
            }

            path.Add(start);

            path.Reverse();

            return path;
        }
    }
}
