using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class listNode
    {
        public Node head;
        public void printAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "\t");
                current = current.next;
            }
        }

        public void AddFirst(int data)
        {
            Node toAdd = new Node(data);
            toAdd.next = head;
            head = toAdd;
        }

        public void AddLast(int data)
        {
            if (head == null)
            {
                head = new Node(data);

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node(data);
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
        public int countList()
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }

    }
}
