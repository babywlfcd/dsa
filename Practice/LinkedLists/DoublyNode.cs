using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LinkedLists
{
    public class DoublyNode
    {
        public int Value;
        public DoublyNode Next;
        public DoublyNode Previous;

        public DoublyNode(int value, DoublyNode previous = null, DoublyNode next = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}
