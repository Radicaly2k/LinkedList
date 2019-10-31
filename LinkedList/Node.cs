using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class Node
    {
        private Node m_next = null;
        private int m_data;

        public Node Next 
        { 
            get 
            {
                return m_next;
            }
            set
            {
                m_next = value;
            } 
        }

        public int Data
        {
            get
            {
                return m_data;
            }
            set
            {
                m_data = value;
            }
        }

        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }
}
