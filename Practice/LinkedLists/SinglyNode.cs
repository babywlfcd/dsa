using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LinkedLists
{
    public class SinglyNode
    {
        public int Value;
        public SinglyNode Next;

        public SinglyNode(int value, SinglyNode next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
