using System;
using System.Collections.Generic;

namespace TestGenericList
{
    // type parameter T in angle brackets
    public class GenericList<T>
    {
        // The nested class is also generic on T.
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {
                Next = null;
                Data = t;
            }

            public Node Next { get; set; }

            // T as private member data type.
            // T as return type of property.
            public T Data { get; private set; }
        }

        private Node _head;

        // constructor
        public GenericList()
        {
            _head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            var n = new Node(t)
            {
                Next = _head
            };
            _head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var standartList = new List<int>();

            // int is the type argument
            var list = new GenericList<int>();

            for (var x = 0; x < 10; x++)
            {
                list.AddHead(x);
                standartList.Add(x);
            }

            foreach (var i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nDone");

            foreach (var i in standartList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nDone");
            Console.ReadLine();
        }
    }
}
