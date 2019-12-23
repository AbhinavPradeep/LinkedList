using System;

namespace LnkdList
{
    public class LinkedList
    {
        Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void Add(Person person)
        {

            Node node = CreateNode(person);           

             if (Head == null)
             {
                Head = node;
                return;
             }

            if(Head.Next == null)
            {
                Head.Next = node;
                return;
            }

            Node current = Head;
            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;

            
                

           

        }

        public void Remove(string name)
        {
            if (Head == null)
                return;

            Node Current;
            Current = Head;

            if (Head.person.Name == name)
            {
                Head = null;
            }
            if (Head.person.Name != name)
            {
                while (Current.Next.person.Name != name)
                {
                    Current = Current.Next;
                } 
                if (Current.Next.person.Name == name)
                {
                    Current.Next = Current.Next.Next;
                }
            }


        }

        public void Print()
        {
            if (Head == null)
                return;

            Node Current;
            Current = Head;

            do
            {
                System.Console.WriteLine($"Persons first name is  {Current.person.Name}");
                Current = Current.Next;

            } while (Current != null);
        }

        private Node CreateNode(Person person)
        {
            Node node = new Node();
            node.person = person;
            node.Next = null;
            return node;
        }

    }
}