//using System.Collections;
//using System.Collections.Generic;

//namespace Wrox.ProCSharp.Generics
//{
//    public class Person<T> : IEnumerable<T>
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public LinkedListNode<T> AddLast(T node)
//        {
//            var newNode = new LinkedListNode<T>(node);
//            if (First == null)
//            {
//                First = newNode;
//                Last = First;
//            }
//            else
//            {
//                newNode.Prev = Last;
//                Last.Next = newNode;
//                Last = newNode;
//            }
//            return newNode;
//        }

//        public IEnumerator<T> GetEnumerator()
//        {
//            LinkedListNode<T> current = First;

//            while (current != null)
//            {
//                yield return current.Value;
//                current = current.Next;
//            }
//        }

//        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

//        public LinkedListNode<T> AddFirst(T node)
//        {
//            var newNode = new LinkedListNode<T>(node);
//            if (Last == null)
//            {
//                Last = newNode;
//                First = Last;
//            }
//            else
//            {
//                First.Prev = newNode;
//                newNode.Next = First;
//                First = newNode;
//            }
//            return newNode;
//        }

//        public Person(string f = "none", string l = "none")
//        {
//            FirstName = f;
//            LastName = l;
//        }

//        public override string ToString() => $"{FirstName} {LastName}";
//    }


//}