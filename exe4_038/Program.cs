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
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push (int element)
        {
            if (info == max - 1)
            {
                Console.WriteLine("Stack is FULL");
                return;
            }
            else
            {
                Node fresh;
                fresh = new Node(element, null);

                fresh.next = top;
                top = fresh;
                Console.WriteLine("\n" + element + " pushed.");
            }
        }
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next;
        }
        public void display()
        {
            if (info == max - 1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Node tmp;
                if (empty())
                    Console.WriteLine("\nStack Empty");
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                Console.Write("\nEnter your choice: ");
                String sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
