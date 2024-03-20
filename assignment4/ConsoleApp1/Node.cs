using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node()
        {
            Next = null;
        }
        public Node(T t)
        {
            Data = t;
            Next = null;
        }
    }
}
