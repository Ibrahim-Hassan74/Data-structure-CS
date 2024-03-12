namespace main.Data_Structure
{
    public class DoublyLinkedList<T>
    {
        class Node
        {
            public T item;
            public Node next;
            public Node prev;
            public Node(T item)
            {
                this.item = item;
                this.next = this.prev = null;
            }
        }
        private Node head, tail;
        int len;
        public DoublyLinkedList()
        {
            this.len = 0;
            this.head = this.tail = null;
        }
        public bool empty()
        {
            return len == 0;
        }
        public void push_front(T val)
        {
            Node newnode = new Node(val);
            if (empty())
            {
                head = tail = newnode;
            }
            else
            {
                newnode.next = head;
                head.prev = newnode;
                head = newnode;
            }
            len++;
        }
        public void push_back(T val)
        {
            Node newnode = new Node(val);
            if (empty())
            {
                head = tail = newnode;
            }
            else
            {
                newnode.prev = tail;
                tail.next = newnode;
                tail = newnode;
            }
            len++;
        }
        public void insert(int pos,T val)
        {
            if(pos < 0 || pos > len)
                throw new IndexOutOfRangeException();
            if (pos == 0)
                push_front(val);
            else if (pos == len)
                push_back(val); 
            else
            {
                Node newnode = new Node(val);
                Node cur = head;
                for (int i = 1; i < pos; i++)
                    cur = cur.next;
                newnode.next = cur.next;
                newnode.prev = cur;
                cur.next.prev = newnode;
                cur.next = newnode;
                len++;
            }
        }
        public void pop_front()
        {
            if (empty())
                throw new Exception("Empty Linked List");
            if(len == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            len--;
        }
        public void pop_back()
        {
            if (empty())
                throw new Exception("Empty Linked List");
            if (len == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            len--;
        }
        public void erase(T element)
        {
            if (empty())
                throw new Exception("Empty Linked List");
            if (object.Equals(head.item, element)) 
            {
                pop_front();
            }
            else
            {
                Node cur = head;
                while(cur != null)
                {
                    if (object.Equals(cur.item, element))
                        break;
                    cur = cur.next;
                }
                if(cur == null)
                {
                    throw new Exception("Empty Not found");
                }
                if (cur.next == null)
                    pop_back();
                else
                {
                    cur.prev.next = cur.next;
                    cur.next.prev = cur.prev;
                    len--;
                }
            }
        }
        public void print()
        {
            Node node = head;
            while(node != null)
            {
                Console.Write(node.item + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
        public void printr()
        {
            Node node = tail;
            while(node != null)
            {
                Console.Write(node.item + " ");
                node = node.prev;
            }
            Console.WriteLine();
        }
        public void clear()
        {
            head = tail = null;
        }

    }
}
