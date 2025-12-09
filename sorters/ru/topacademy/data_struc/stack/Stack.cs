using System.Threading.Channels;

namespace ru.topacademy.data_struc.stack
{
    unsafe public class Stack
    {
        class Node
        {

            public int* data;
            public Node? prev;
            Node()
            {
                data = null;
                prev = null;
            }
        }

        Node last;

        public Stack()
        {
            last = null;
        }

        public Stack& Put(int val) 
        {
            Node* temp = val;

            if (!last) { last = temp; }
            else
            {
                temp->prev = last;
                last = temp;
            }
            return *this;
        }

        public int& Pop() 
        {
            if (last)
            {
                last = last->prev;
                return *last->data;
            }
            else
            {
                Console.WriteLine("stack is empty");

            }
        }
    }
}
