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

            graph.AddEdge("3D Cinema", " Pirate Ship");

            graph.AddEdge("Slot Machines", "Hotdogs");
            graph.AddEdge("Slot Machines", "Rocket Ships");

            graph.AddEdge("Rocket Ships", "3D Cinema");
            graph.AddEdge("Rocket Ships", "Ghost Train");

            graph.AddEdge("Hotdogs", "Log Flume");

            graph.AddEdge("Log Flume", "Big Dipper");

            graph.AddEdge("Big Dipper", "Rollercoaster");
            graph.AddEdge("Big Dipper", "Ghost Train");

            graph.AddEdge("Ghost Train", "Carousel");
            graph.AddEdge("Ghost Train", " Flying Chairs");

            graph.AddEdge("Carousel", "Flying Chairs");
        }
    }
}
