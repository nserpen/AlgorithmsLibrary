// ***********************
// Nejat Serpen (2020)
// ***********************
//
using System;
using System.Text;

namespace AlgorithmsLibrary.LinkedLists
{
    public class Node<T> where T : IComparable<T>, IComparable
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public static Node<T> Insert(Node<T> head, T data)
        {
            Node<T> p = new Node<T>(data);

            if (head == null)
                head = p;
            else if (head.Next == null)
                head.Next = p;
            else
            {
                Node<T> start = head;
                while (start.Next != null)
                    start = start.Next;
                start.Next = p;
            }
            return head;
        }

        public static void Display(Node<T> head)
        {
            Node<T> start = head;
            while (start != null)
            {
                Console.Write($"{start.Data} ");
                start = start.Next;
            }
        }

        public static int Count(Node<T> head)
        {
            Node<T> start = head;
            int cnt = 0;
            while (start != null)
            {
                cnt++;
                start = start.Next;
            }
            return cnt;
        }

        public static string ToString(Node<T> head)
        {
            var sb = new StringBuilder();
            Node<T> start = head;
            while (start != null)
            {
                sb.AppendFormat("{0} ", start.Data);
                start = start.Next;
            }

            return sb.ToString().TrimEnd();
        }


        public static Node<T> RemoveDuplicatesOfNonDecreasingList(Node<T> head)
        {
            Node<T> start = head;
            while (start.Next != null)
            {
                var comp = start.Data.CompareTo(start.Next.Data);
                if (comp < 0)
                {
                    start = start.Next;
                }
                else if (comp == 0)
                {
                    var toBeRemoved = start.Next;
                    
                    if (toBeRemoved.Next != null)
                    {
                        start.Next = toBeRemoved.Next;
                        toBeRemoved.Next = null;
                    }
                    else
                    {
                        start.Next = null;
                    }
                    toBeRemoved = null;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("List does not have valid data structure: not non-decreasing!");
                }
            }

            return head;
        }

    }

}
