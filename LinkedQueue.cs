namespace main.stls
{
    public class LinkedQueue<T>
    {
        class Node
        {
            public T item;
            public Node next;
            public Node(T val)
            {
                this.item = val;
                this.next = null;
            }
            public Node() { }
        }
        private Node rear, front;
        private int len;
        public LinkedQueue()
        {
            rear = front = null;
            len = 0;
        }
        public bool isEmpty()
        {
            return len == 0;
        }
        public void push(T val)
        {
            Node newnode = new Node(val);
            if (isEmpty())
            {
                rear = front = newnode;
            }
            else
            {
                this.rear.next = newnode;
                this.rear = newnode;
            }
            len++;
        }
        public void pop()
        {
            if (isEmpty())
                throw new Exception("queue is empty");
            len--;
            this.front = this.front.next;
            if (this.front == null)
                this.rear = null;
        }
        public void print()
        {
            Node n = front;
            while (n != null)
            {
                Console.Write(n.item + " ");
                n = n.next;
            }
            Console.WriteLine();
        }
        public T getfront()
        {
            return isEmpty() ? throw new Exception("queue is empty") : this.front.item;
        }
        public T back()
        {
            return isEmpty() ? throw new Exception("queue is empty") : this.rear.item;
        }
        public void clear()
        {
            len = 0;
            front = rear = null;
        }
        public int size()
        {
            return len;
        }
    }
}
