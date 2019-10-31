using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class LinkedList
    {
        private Node m_head;

        public Node InsertBack(int data)
        {
            if(m_head == null)
            {
                m_head = new Node(data);
                return m_head;
            }

            Node lastNode = GetLastNode();
            lastNode.Next = new Node(data);

            return lastNode;
        }

        public Node InsertFront(int data)
        {
            if(m_head == null)
            {
                m_head = new Node(data);
                return m_head;
            }

            Node newNode = new Node(data);
            newNode.Next = m_head;
            m_head = newNode;

            return newNode;
        }

        public Node GetLastNode()
        {
            Node last;
            last = m_head;

            while (last.Next != null)
            {
                last = last.Next;
            }

            return last;
        }

        public void PrintFirstNode()
        {
            Console.Out.WriteLine($"First Data: {m_head.Data}");
            Console.Out.WriteLine($"Next Data: {m_head.Next.Data}");
        }

        public void PrintAllInOrder()
        {
            Node last;
            last = m_head; 

            while (last.Next != null)
            {
                Console.Out.WriteLine($"{last.Data},");
                last = last.Next;
            }

            Console.Out.WriteLine($"{last.Data},");
        }
    }
}
