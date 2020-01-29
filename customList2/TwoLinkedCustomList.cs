using CustomList;
using customList2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList2
{
    public class TwoLinkedCustomList : CustomList.CustomList
    {
        //public TwoLinkedCustomList(CustomList.CustomList Add, CustomList.CustomList AddFirst) : base(Add, AddFirst)
        //{
        //}

        public new TwoNode Head;
        public new TwoNode Tail;
        public new int Counter;
        public new Notebook this[int index]
        {
            get
            {
                TwoNode current = Head;
                int i = 0;
                while (current != null && i != index)
                {
                    current = current.nextElement;
                    i++;
                }
                return current.Element;
            }
        }

        public new void Add(Notebook value)
        {
            TwoNode twonode = new TwoNode(value, null);
            if (Head == null)
                Head = twonode;
            else
            {
                Tail.nextElement = twonode;
                TwoNode previous = Tail;
            }
            Tail = twonode;
            Counter++;
        }
        public new void AddFirst(Notebook value)
        {
            TwoNode twonode = new TwoNode(value, null);
            TwoNode Tail = Head;
            twonode.nextElement = Tail;
            Head = twonode;
            if (Counter == 0)
                Tail = Head;
            else
                Tail.nextElement = twonode;
            Counter++;
        }
        public new bool Delete(Notebook value)
        {
            TwoNode current = Head;
            while (current != null)
            {
                if (current.element.Equals(value))
                {
                    break;
                }
                current = current.nextElement;
            }
            if (current != null)
            {
                if (current.nextElement != null)
                {
                    current.nextElement.element = current.element;
                }
                else
                {
                    Tail.element = current.element;
                }
                if (current.element != null)
                {
                    current.nextElement = current.nextElement;
                }
                else
                {
                    Head = current.nextElement;
                }
                Counter--;
                return true;
            }
            return false;
        }
        public int Coun { get { return Counter; } }
        //public bool IsEmpty { get { return Counter == 0; } }


        IEnumerator  GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

       public IEnumerator StartEnumerator()
        {
            TwoNode current = Head;
            while (current != null)
            {
                yield return current;
                current = current.nextElement;
            }
        }

        public IEnumerable BackEnumerator()
        {
            TwoNode current = Tail;
            while (current != null)
            {
                yield return current;
                current = current.element; 
            }
        }
    }
}  


  
    