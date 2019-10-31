using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();

            lList.InsertBack(10);
            lList.InsertBack(9);
            lList.InsertBack(8);
            lList.InsertBack(7);
            lList.InsertBack(6);
            lList.InsertFront(2);
            lList.InsertBack(5);
            lList.InsertBack(4);
            lList.InsertFront(0);

            lList.PrintAllInOrder();
        }
    }
}
