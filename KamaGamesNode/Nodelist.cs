using System;
namespace KamaGamesNode
{
    class Nodelist
    {
        public Node First { get; set; }
        public void AddElement(string data)
        {
            if (First == null)
            {
                First = new Node(data);
            }
            else
            {
                Node last = First;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = new Node(data);
            }
        }
        public void Present()
        {
            Node last = First;
            while (last != null)
            {
                Console.Write(last.Value + ' ');
                last = last.Next;
            }
            Console.WriteLine();
        }
        public void Expand()
        {
            Node now = First;
            Node next = null;
            Node previous = null;
            while (now != null)
            {
                next = now.Next;
                now.Next = previous;
                previous = now;
                now = next;
            }
            First = previous;
        }
    }
}

