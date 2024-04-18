namespace main.DataStructure
{
    public class stack<T> where T : IComparable
    {
        private class node
        {
            public T val;
            public node next;
            public node(T item)
            {
                this.val = item;
                this.next = null;
            }
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
            node newnode = new node(x);
            newnode.next = top;
            top = newnode;
        }
        public void pop()
        {
            if (empty())
                throw new Exception("Stack is empty");
            top = top.next;
        }
        public void pop(ref T x)
        {
            x = top.val;
            top = top.next;
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
