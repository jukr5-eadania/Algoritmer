﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafer
{
    internal class Edge<T>
    {
        public Node<T> From { get; private set; }

        public Node<T> To { get; private set; }

        public Edge(Node<T> from, Node<T> to)
        {
            this.From = from;
            this.To = to;
        }
    }
}
