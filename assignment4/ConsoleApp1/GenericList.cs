using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void add(T t)
        {
            Node<T> node = new Node<T>(t);
            if(tail ==  null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;             
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> n = head;
            while(n != null)
            {
                action(n.Data);
                n = n.Next;
            }

        }
    }
}
