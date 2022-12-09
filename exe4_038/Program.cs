using System;

namespace exe4_038
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Stacks
    {
        Node top;
        public string[] siti;
        public int max;
        public int info;
        public Stacks()
        {
            siti = new string[58];
            info = -1;
            max = 58;
        }
    }
    /*static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }*/
}
