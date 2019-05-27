using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCollections
{
    public class LinkedList
    {
        private class ListNode
        {
            private Object _item;

            public Object Item
            {
              get { return _item; }
              set { _item = value; }
              
            }
            //Reference to next node in list
            private ListNode _nextNode = null;
            //Get Set metode til NextNode
            public ListNode NextNode
            {
                get { return _nextNode; }
                set { _nextNode = value; }
            }
        }
        

        private ListNode _firstNode = null;
        private ListNode _lastNode = null;

        public Object Add(Object item)
        {
            var node = new ListNode();
            node.Item = item;

            if (_firstNode == null)
            {
                _firstNode = node;
                _lastNode = node;
            }
            else
            {
                //_lastNode.NextNode = node;
                //_lastNode = node;

                ListNode currentNode = _firstNode;
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = node;
            }
            return item;
        }

        public int Length()
        {
            throw new NotImplementedException();
        }
        //TODO: Implement Object Last()
        //TODO: Object RemoveLast()

        //TODO: Implement Object InsertAfter


        public void PrintList()
        {
            ListNode currentNode = _firstNode;
            while (currentNode.NextNode != null)
            {
                Console.WriteLine(currentNode.Item);
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine(currentNode.Item);
 
        }
    }
}
