//using System.Collections;
//using System.Collections.Generic;

//namespace Wrox.ProCSharp.Generics
//{
//    public class Person : IEnumerable<string>
//    {
//        public LinkedListNode<string> FirstName { get; set; }
//        public LinkedListNode<string> LastName { get; set; }

//        public LinkedListNode<string> AddLast(string node)
//        {
//            var newNode = new LinkedListNode<string>(node);
//            if (FirstName == null)
//            {
//                FirstName = newNode;
//                LastName = FirstName;
//            }
//            else
//            {
//                newNode.Prev = LastName;
//                LastName.Next = newNode;
//                LastName = newNode;
//            }
//            return newNode;
//        }

//        public IEnumerator<string> GetEnumerator()
//        {
//            LinkedListNode<string> current = FirstName;

//            while (current != null)
//            {
//                yield return current.Value;
//                current = current.Next;
//            }
//        }

//        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

//        public LinkedListNode<string> AddFirst(string node)
//        {
//            var newNode = new LinkedListNode<string>(node);
//            if (LastName == null)
//            {
//                LastName = newNode;
//                FirstName = LastName;
//            }
//            else
//            {
//                FirstName.Prev = newNode;
//                newNode.Next = FirstName;
//                FirstName = newNode;
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