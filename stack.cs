namespace main.DataStructure
{
    public class stack<T>
    {
        private class node
        {
            public T val;
            public node next;
        }
        node top;
        public stack()
        {
            top = null;
        }
        public bool empty()
        {
            return top == null;
        }
        public void push(T x)
        {
            node newnode = new node();
            newnode.val = x;
            newnode.next = top;
            top = newnode;
        }
        public void pop()
        {
            if (empty())
                throw new Exception("Stack is empty");
            node newnode = top;
            top = top.next;
            newnode = newnode.next = null;
        }
        public void pop(ref T x)
        {
            x = top.val;
            node newnode = top;
            top = top.next;
            newnode = newnode.next = null;
        }
        public T getTop()
        {
            if (empty())
                throw new Exception("Stack is empty");
            return top.val;
        }
        public void print()
        {
            node newnode = top;
            while (newnode != null)
            {
                Console.Write(newnode.val + " ");
                newnode = newnode.next;
            }
            Console.WriteLine();
        }
    }
}
