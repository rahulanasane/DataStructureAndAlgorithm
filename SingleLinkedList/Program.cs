using System;

namespace SingleLinedkList
{
    class Node
    {
        private int data;
        private Node next;

        public Node()
        {
            data = 0;
            next = null;
        }
        public Node(int value)
        {
            data = value;
            next = null;
        }
        public Node InsertNext(int value)
        {

            Node node = new Node(value);
            if (this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                Node temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }
        public int DeleteNext()
        {
            if (next == null)
                return 0;
            Node node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }
        public void Traverse(Node node)
        {
            if (node == null)
                node = this;

            System.Console.WriteLine("Traversing Singly Linked List :");

            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1000);
            Node node2 = node1.InsertNext(2000);
            Node node3 = node2.InsertNext(3000);
            Node node4 = node3.InsertNext(4000);
            Node node5 = node4.InsertNext(5000);
            node1.Traverse(null);
            Console.WriteLine("Deleting from Linked List...");
            node3.DeleteNext();
            node2.Traverse(null);
            System.Console.ReadLine();
        }
    }
}
