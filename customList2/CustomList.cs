using customList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList : IEnumerable, ICustomLink
    {
        public int Counter;
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public Notebook this[int index]
        {
            get
            {
                Node current = Head;
                int i = 0;
                while (current != null && i != index)
                {
                    current = current.NextElement;
                    i++;
                }
                return current.Element;
            }
        }
        public void Add(Notebook value)
        {
            Node node = new Node(value, null);
            if (Head == null)
            {
                Head = node;
                Tail = node;
                Counter = 0;
            }
            else
            {
                Tail.NextElement = node;
                Tail = node;
                Counter++;
            }
        }
        public void Delete(Notebook value)
        {
            Node current = Head;
            Node previous = null;

            while (current != null)
            {
                if (current.Element.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.NextElement = current.NextElement;
                        {
                            if (current.NextElement == null)
                            {
                                Tail = previous;
                            }
                        }
                    }
                    else
                    {
                        Head = Head.NextElement;
                        if (Head == null)
                        {
                            Tail = null;
                        }

                        Counter--;

                    }
                    previous = current;
                    current = current.NextElement;
                }
            }
        }
        public void AppendFirst(Notebook value)
        {
            Node node = new Node(value, null);
            node.NextElement = Head;
            Head = node;
            if (Counter == 0)
                Tail = Head;
            Counter++;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator IEnumerable()
        {
            Node current = Head;
            while (current != null)
            {
                yield return current;
                current = current.NextElement;
            }
        }
    }
}


