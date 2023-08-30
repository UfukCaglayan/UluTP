using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsTP
{
    public class SingleLinkedList
    {
        internal Node head;
    }
    internal class Node
    {
        internal int seferID;
        internal int koltuk;
        internal char cinsiyet;
        internal Node next;

        /// Constructor to create a new node.Next is by default initialized as null
        public Node(int s,int d,char c)
        {
            seferID = s;
            koltuk = d;
            cinsiyet = c;
            next = null;
        }
    }
    internal class HelperSLL
    {
        internal SingleLinkedList CreateLinkList()
        {
            SingleLinkedList llist = new SingleLinkedList();

            llist.head = new Node(1,1,'E');
            Node second = new Node(1,2, 'E');
            Node third = new Node(1,3, 'E');

            llist.head.next = second;
            second.next = third;

            return llist;
        }
        #region Insert_into_SinglyLinkedList
        internal void InsertFront(SingleLinkedList singlyList,int sefer, int koltuk, char cinsiyet)
        {
            Node new_node = new Node(sefer,koltuk,cinsiyet);
            new_node.next = singlyList.head;

            singlyList.head = new_node;
        }
        internal void InsertAfter(Node prev_node, int sefer, int koltuk, char cinsiyet)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(sefer,koltuk,cinsiyet);

            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        internal void InsertLast(SingleLinkedList singlyList,int sefer, int koltuk, char cinsiyet)
        {
            Node new_node = new Node(sefer,koltuk,cinsiyet);

            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);

            lastNode.next = new_node;
        }

        #endregion Insert_into_SinglyLinkedList

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;

        }

        /* Given a key, deletes the first occurrence of key in linked list */
        internal void DeleteNodebyKey(SingleLinkedList singlyList, int key)
        {
            Node temp = singlyList.head;
            Node prev = null;

            if (temp != null && temp.koltuk == key)
            {
                singlyList.head = temp.next;
                return;
            }

            while (temp != null && temp.koltuk != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
        /* Given a position in Linked List, deletes the node at the given position*/


        public void DeleteNodebyPosition(SingleLinkedList singlyList, int position)
        {
            if (singlyList.head == null)
            {
                return;
            }
            Node temp = singlyList.head;

            if (position == 0)
            {
                singlyList.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }

            // Node temp->next is the node to be deleted
            Node nextNode = temp.next.next;

            temp.next = nextNode;

        }

        public void SearchLinkedList(SingleLinkedList singlyList, int value)
        {
            Node temp = singlyList.head;

            while (temp != null)
            {
                if (temp.koltuk == value)
                {
                    Console.WriteLine("The Element {0} is present in Linked List", value);
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("The Element {0} is NOT present in Linked List", value);
        }

        public void ReverseLinkedList(SingleLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.head;
            Node temp = null;

            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            singlyList.head = prev;

        }

        /* Traverse linked list using two pointers.
         * Move one pointer by one and other pointer by two.
         * When the fast pointer reaches end slow pointer will reach middle of the linked list.
         * */

        public void FindMiddle(SingleLinkedList singlyList)
        {
            Node slow_ptr = singlyList.head;
            Node fast_ptr = singlyList.head;

            if (singlyList.head != null)
            {
                while (fast_ptr != null && fast_ptr.next != null)
                {
                    fast_ptr = fast_ptr.next.next;
                    slow_ptr = slow_ptr.next;
                }
                Console.WriteLine("The middle element is {0}", slow_ptr.koltuk);
            }
        }

        /* This function prints contents of linked list starting from head */
        public void PrintList(SingleLinkedList singlyList)
        {
            Node n = singlyList.head;
            while (n != null)
            {
                Console.Write(n.koltuk + " ");
                n = n.next;
            }
        }
    }
}
