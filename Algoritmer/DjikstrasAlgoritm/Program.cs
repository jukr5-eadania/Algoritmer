using System;
using System.Collections.Generic;

namespace DjikstrasAlgoritm
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

            graph.AddDirectionalEdge("Entrance", "FunHouse", 6);
            graph.AddDirectionalEdge("Entrance", "Ice Blaster", 1);
            graph.AddDirectionalEdge("Entrance", "Slot Machines", 9);

            graph.AddDirectionalEdge("Ice Blaster", "Slot Machines", 3);
            graph.AddDirectionalEdge("Ice Blaster", "Rocket Ships", 2);
            graph.AddDirectionalEdge("Ice Blaster", "3D Cinema", 7);
            graph.AddDirectionalEdge("Ice Blaster", "FunHouse", 6);

            graph.AddDirectionalEdge("FunHouse", "3D Cinema", 1);

            graph.AddDirectionalEdge("3D Cinema", "Pirate Ship", 5);

            graph.AddDirectionalEdge("Slot Machines", "Hotdogs", 6);
            graph.AddDirectionalEdge("Slot Machines", "Rocket Ships", 4);

            graph.AddDirectionalEdge("Rocket Ships", "3D Cinema", 5);
            graph.AddDirectionalEdge("Rocket Ships", "Ghost Train", 9);

            graph.AddDirectionalEdge("Hotdogs", "Log Flume", 5);

            graph.AddDirectionalEdge("Log Flume", "Big Dipper", 7);

            graph.AddDirectionalEdge("Big Dipper", "Rollercoaster", 8);
            graph.AddDirectionalEdge("Big Dipper", "Ghost Train", 5);

            graph.AddDirectionalEdge("Ghost Train", "Carousel", 7);
            graph.AddDirectionalEdge("Ghost Train", "Flying Chairs", 2);

            graph.AddDirectionalEdge("Carousel", "Flying Chairs", 5);

            Console.WriteLine("Djikstras Algoritm:");

            List<Node<string>> path = Djikstra(graph, graph.Nodes.Find(x => x.Data == "Entrance"), graph.Nodes.Find(x => x.Data == "Ghost Train"));

            foreach (var item in path)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static List<Node<T>> Djikstra<T>(Graph<T> graph, Node<T> start, Node<T> goal)
        {
            Dictionary<Node<T>, float> distances = new Dictionary<Node<T>, float>();
            HashSet<Node<T>> unvisitedNodes = new HashSet<Node<T>>();

            foreach (Node<T> node in graph.Nodes)
            {
                distances.Add(node, float.PositiveInfinity);
                unvisitedNodes.Add(node);
            }

            distances[start] = 0;
            Node<T> current = null;

            while (unvisitedNodes.Count != 0)
            {
                float minValue = float.PositiveInfinity;

                foreach (var unvisited in unvisitedNodes)
                {
                    if (distances[unvisited] < minValue)
                    {
                        minValue = distances[unvisited];
                        current = unvisited;
                    }
                }

                unvisitedNodes.Remove(current);

                foreach (var edge in current.Edges)
                {
                    if (edge.Weight + distances[current] < distances[edge.To])
                    {
                        edge.To.Parent = current;
                        distances[edge.To] = edge.Weight + distances[current];
                    }
                }
            }

            Node<T> currentGoal = goal;
            List<Node<T>> nodes = new List<Node<T>>();

            Console.WriteLine(currentGoal.Data);

            while (currentGoal.Parent != null)
            {
                nodes.Add(currentGoal.Parent);
                currentGoal = currentGoal.Parent;
            }

            return nodes;
        }
    }
}