using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class GoogleList
    {

        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void Add(string userInput)
        {
            Node node = new Node { Next = null, Data = userInput };

            if (Count == 0)
            {
                Head = node;
                Tail = node;
                Count++;              
            }
            else
            {
                Tail.Next = node;
                Tail = node;
                Count++;
            }

        }


        public void Clear()
        {
            Count = 0;
        }

        public Node GetNode(int index)
        {
            int counter = 0;
            Node node = Head;

            while (counter != index)
            {
                node = node.Next;
                counter++;
            }

            return node;          
        }

        public void RemoveAll(string userInput)
        {
            Node node = Head;

            while (node.Data == userInput)
            {
                Head = Head.Next;
                node = node.Next;
            }

            while (node != null)
            {

                while (node.Next != null && node.Next.Data == userInput)
                {
                    node.Next = node.Next.Next;
                    Count--;
                }

                node = node.Next;
            }
        }
        public void printInfo()
        {
                Node node = Head;

                while (node != null)
                {
                    Console.WriteLine(node.Data);
                    node = node.Next;
                }
        }

    }
}
