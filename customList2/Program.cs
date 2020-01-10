using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Node
    {
        public Node(Notebook element, Node nextElement = null)
        {
            Element = element;
            NextElement = nextElement;
        }
        public Notebook Element { get; set; }
        public Node NextElement { get; set; }
    }
    public class CustomList : IEnumerable, ICustomLink
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public Notebook this[int index] => throw new NotImplementedException();

        public void Add(Notebook value)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notebook value)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class Notebook
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }
    }
    public interface ICustomLink
    {
        void Add(Notebook value);
        Notebook this[int index] { get; }
        void Delete(Notebook value);
    }
}
