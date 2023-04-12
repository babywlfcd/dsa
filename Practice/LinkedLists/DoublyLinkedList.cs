namespace Practice.LinkedLists
{
    /// <summary>
    /// Doubly list implementation
    /// Advantages:
    ///     1. Revers easier
    ///     2. Delete a node easier
    /// Disadvantages:
    ///     1. More memory space
    /// </summary>
    public class DoublyLinkedList
    {
        public DoublyNode Head;

        public DoublyLinkedList(DoublyNode head = null)
        {
            Head = head;
        }

        /// <summary>
        /// Add new node at head:
        /// 1. Initialize new node current
        /// 2. Link new node to head
        /// 3. Assign current to head
        /// T.C -> O(1)
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new DoublyNode(val);
                return;
            }

            var newNode = new DoublyNode(val);
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        /// <summary>
        /// Add at tail:
        /// 1. Start from head.
        /// 2. Traverse the whole list till the tail
        /// 3. assign the new node to tail
        /// T.C -> O(1)
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                Head = new DoublyNode(val);
                return;
            }

            var current = Head;
            while (current != null && current.Next != null)
            {
                current = current.Next;
            }

            var newNode = new DoublyNode(val);
            current.Next = newNode;
            newNode.Previous = current;
            newNode.Next = null;

        }

        /// <summary>
        /// Add a node to a given position
        /// </summary>
        /// <param name="index">index where the node is inserted</param>
        /// <param name="val"></param>
        public void AddAtIndex(int index,int val)
        {
            if (Head == null)
            {
                Head = new DoublyNode(val);
                return;
            }

            var current = Head;
            while (index - 1 > 0)
            {
                current = current.Next;
                index--;
            }

            // 2 <-> 3 <-> 4
            // node to add 5, index 1
            // 2      3 (nextNode) <-> 4
            //   \   /
            //     5 (newNode)

            var newNode = new DoublyNode(val);
            var nextNode = current.Next; // store next node before link the new node
            current.Next = newNode;
            newNode.Previous = current;
            newNode.Next = nextNode.Next;
            nextNode.Previous = newNode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DoublyNode GetNode(int index)
        {
            return new DoublyNode(0);
        }
    }
}
