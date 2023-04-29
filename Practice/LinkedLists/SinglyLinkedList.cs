using System.Text;

namespace Practice.LinkedLists
{
    /// <summary>
    /// Singly list implementation
    /// Remark: Linked List refers to the singly linked list
    /// Advantages:
    ///     1. No size limitation
    ///     2. Insertion / Deletion easy (comparing with arrays)
    /// Disadvantages:
    ///     1. Sequential access -> need to traverse tle linked list to reach a node (vs array -> index)
    ///     2. Extra pointer -> extra size
    /// </summary>
    public class SinglyLinkedList
    {
        public SinglyNode Head;
        public int Length;

        public SinglyLinkedList(SinglyNode head = null)
        {
            Head = head;
            Length = 0;
        }

        /// <summary>
        /// Add new node at head:
        /// 1. Initialize new node current
        /// 2. Link new node to head
        /// 3. Assign current to head
        /// T.C. -> O(1)
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new SinglyNode(val);
                Length++;
                return;
            }

            var newNode = new SinglyNode(val);
            newNode.Next = Head;
            Head = newNode;
            Length++;
        }

        /// <summary>
        /// Add at tail:
        /// 1. Start from head.
        /// 2. Traverse the whole list till the tail
        /// 3. Assign the new node to tail
        /// T.C  -> O(n)
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                Head = new SinglyNode(val);
                Length++;
                return;
            }

            var current = Head;
            while (current != null && current.Next!= null)
            {
                current = current.Next;
            }

            var newNode = new SinglyNode(val);
            current.Next = newNode;
            newNode.Next = null;
            Length++;
        }

        /// <summary>
        /// Add a node to a given position
        /// 1. for index 0 add at head
        /// 2. for index greater then length add node at the end of the linked list
        /// 3. find the index and add the node to index
        /// T.C -> O(1)
        /// </summary>
        /// <param name="index">index where the node is inserted</param>
        /// <param name="val"></param>
        public void AddAtIndex(int index,int val)
        {
            if (index >= Length)
            {
                AddAtTail(val);
                return;
            }

            var current = Head;

            while (index - 1 > 0)
            {
                current = current.Next;
                index--;
            }

            var nodeToAdd = new SinglyNode(val);
            var nextNode = current.Next;
            current.Next = nodeToAdd;
            nodeToAdd.Next = nextNode;
            Length++;
        }

        /// <summary>
        /// T.C -> O(1)
        /// </summary>
        public void RemoveAtHead()
        {
            if (Head == null)
                return;

            Head = Head.Next;
            Length--;
        }

        /// <summary>
        /// Empty list or List with one node return null
        /// T.C -> O(n)
        /// </summary>
        public void RemoveAtTail()
        {
            if(Head == null)
                return;

            if (Head.Next == null)
            {
                Head = null;
                Length--;
                return;
            }

            var current = Head;
            var preview = current.Next;
            while (current != null && current.Next != null)
            {
                current = current.Next;
            }

            preview.Next = null;
            Length--;

        }
        /// <summary>
        /// T.C -> O(n)
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAtIndex(int index)
        {
            if (Head == null || index > Length)
                return;

            if (index == 0)
            {
                RemoveAtHead();
                return;
            }

            if (Length == index + 1)
            {
                RemoveAtTail();
                return;
            }

            var current = Head;
           
            while (index - 1 > 0)
            {
                current = current.Next;
                index--;
            }

            current.Next = current.Next.Next;
            Length--;
        }

        /// <summary>
        /// T.C -> O(n)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public SinglyNode GetNodeAtIndex(int index)
        {
            if (index > Length)
                return Head = null;

            if (Head == null )
                return Head;

            var current = Head;

            while (index> 0)
            {
                current = current.Next;
                index--;
            }

            return current;
        }

        /// <summary>
        /// T.C -> O(n)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public SinglyNode GetNode(int val)
        {
            if (Head == null)
                return Head;

            var current = Head;

            while (current != null)
            {
                if (current.Value == val)
                    return current;

                current = current.Next;
            }

            Head = null;
            return Head;
        }

        /// <summary>
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="Head"></param>
        /// <returns></returns>
        public string Traverse(SinglyNode head)
        {
            var sb = new StringBuilder();
            if (head == null)
                return string.Empty;

            var current = head;
            while (current != null && current.Next != null)
            {
                sb.Append(current.Value);
                sb.Append(" ");
                current = current.Next;
            }

            Head = current;
            sb.Append(Head.Value);
            return sb.ToString();
        }
    }
}
