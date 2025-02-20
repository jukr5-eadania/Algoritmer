﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafer
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

        public void AddEdge(Node<T> other)
        {
            Edges.Add(new Edge<T>(this, other));
        }
    }
}
