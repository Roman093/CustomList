using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList2
{
    public class TwoNode : Node
    {
        //public TwoNode<T> nextElement;

        public TwoNode(Notebook element, Node nextElement) : base(element, nextElement)
        {
            NextElement = nextElement;
            element = Element;
        }
        public TwoNode nextElement{get; set;}
        public Notebook element { get; set; }
    }
}
