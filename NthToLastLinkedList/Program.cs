using System;

namespace NthToLastLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new LinkedList();
			head.Add(1);
			head.Add(2);
			head.Add(3);
			head.Add(4);
			head.Add(5);

			// 1->2->3->4->5->null

            var n = head.GetNthToLastLinkedList(3);
			var n1 = head.GetNthToLastLinkedList(0);
			var n2 = head.GetNthToLastLinkedList(6);
		}
    }

    public class LinkedList {
        public Node _head;

		public class Node
		{
			public int value;
			public Node next;

			public Node(int d)
			{
				value = d;
			}
		}

        public LinkedList() {

        }   
		
		public void Add(int d)
		{
			Node newNode = new Node(d);
			Node current = _head;

			if (_head == null)
			{
				_head = newNode;
			}
			else
			{
				while(current.next != null)
				{
					current = current.next;
				}

				current.next = newNode;
			}
		}

		public Node GetNthToLastLinkedList(int n)
		{
			Node curr = _head;
			Node follower = _head;

            int loop = 0;
            while(curr != null) {
                curr = curr.next;
                if (n <= loop++) {
                    follower = follower.next;        
                }
            }

			return follower;
		}
    }
}
