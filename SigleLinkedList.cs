namespace main.DataStructure
{
    public class SigleLinkedList<T> where T : IComparable
    {
        public class Node
        {
            public T item;
            public Node next;
            public Node(T item)
            {
                this.item = item;
                this.next = null;
            }
        }
        private Node head;
        private Node tail;
        private int len;
        public SigleLinkedList()
        {
            this.head = this.tail = null;
            this.len = 0;
        }
        public bool empty() => len == 0;
        public void push_front(T val)
        {
            Node newnode = new Node(val);
            if (len == 0)
            {
                this.head = this.tail = newnode;
            }
            else
            {
                newnode.next = head;
                this.head = newnode;
            }
            len++;
        }
        public void push_back(params T[] a)
        {
            foreach (var i in a)
                push_back(i);
        }
        public void push_front(params T[] a)
        {
            foreach(var i in a)
                push_front(i);
        }
        public void push_back(T val)
        {
            Node newnode = new Node(val);
            if (len == 0)
            {
                this.tail = this.head = newnode;
            }
            else
            {
                this.tail.next = newnode;
                this.tail = newnode;
            }
            len++;
        }
        public void insert(int pos, T val)
        {
            if (pos < 0 || pos > len)
                throw new IndexOutOfRangeException();
            Node node = new Node(val);
            if (pos == 0)
                push_front(val);
            else if (pos == len)
                push_back(val);
            else
            {
                Node cur = head;
                for (int i = 1; i < pos; i++)
                    cur = cur.next;
                node.next = cur.next;
                cur.next = node;
            }
            len++;
        }
        public void pop_front()
        {
            if (len == 0)
                throw new Exception("List is empty\n");
            else if (len == 1)
                head = tail = null;
            else
                head = head.next;
            len--;
        }

        public void print()
        {
            Node cur = head;
            while (cur != null)
            {
                Console.Write(cur.item + " ");
                cur = cur.next;
            }
        }
        public void pop_back()
        {
            if (len == 0)
                throw new Exception("List is empty\n");
            else if (len == 1)
                head = tail = null;
            else
            {
                Node cur = head.next;
                Node prev = head;
                while (cur != tail)
                {
                    prev = cur;
                    cur = cur.next;
                }
                prev.next = null;
                tail = prev;
            }
            len--;
        }
        public void erase(T element)
        {
            if (empty())
                throw new Exception("List is empty\n");
            if (object.Equals(head.item, element))
            {
                head = head.next;
                len--;
                if (len == 0)
                    tail = null;
            }
            else
            {
                Node cur = head.next, prev = head;
                while (cur != null)
                {
                    if (object.Equals(cur.item, element))
                        break; 
                    prev = cur;
                    cur = cur.next;
                }
                if (cur == null)
                    throw new Exception("Element not Found");
                prev.next = cur.next;
                if (tail == cur)
                    tail = prev;
                len--;
            }
        }
        public void erasepos(int pos)
        {
            if (empty())
                throw new Exception("List is empty\n");
            if (pos > len || pos < 0)
                throw new IndexOutOfRangeException();
            if (pos == 0)
            {
                pop_front();
            }
            else if (pos == len)
            {
                pop_back();
            }
            else
            {
                Node cur = head.next, prev = head;
                for (int i = 1; i < pos; i++)
                {
                    prev = cur;
                    cur = cur.next;
                }
                prev.next = cur.next;
                if (tail == cur)
                    tail = prev;
            }
            len--;
        }
        public void reverse()
        {
            Node cur, next, prev;
            cur = head;
            next = cur.next;
            prev = null;
            while (next != null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            head = prev;
        }
        public int find(T val)
        {
            Node node = head;
            int cnt = 0;
            while (node != null)
            {
                if (object.Equals(val, node.item))
                    return cnt;
                cnt++;
                node = node.next;
            }
            return -1;
        }
        public void BubbleSort()
        {
            if (empty())
                throw new Exception("list is empty");
            Node n = head;
            while (n != null)
            {
                Node cur = n.next;
                while (cur != null)
                {
                    int cmp = (n.item as IComparable).CompareTo(cur.item);
                    bool ok = cmp > 0;
                    if (ok) 
                    {
                        T val = n.item;
                        n.item = cur.item;
                        cur.item = val;
                    }
                    cur = cur.next;
                }
                n = n.next;
            }
        }
        public void SelectionSort()
        {
            if (empty())
                throw new Exception("list is empty");
            Node n = head;
            while (n != null)
            {
                Node cur = n.next;
                Node x = n;
                while (cur != null)
                {
                    int cmp = (x.item as IComparable).CompareTo(cur.item);
                    bool ok = cmp > 0;
                    if (ok)
                    {
                        x = cur;
                    }
                    cur = cur.next;
                }
                T val = x.item;
                x.item = n.item;
                n.item = val;
                n = n.next;
            }
        }
        public int size() => len;
        public void copy(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                push_back(a[i]);
            }
        }
        public T getMax()
        {
            if (empty())
                throw new Exception("list is empty");
            T mx = head.item;
            Node n = head;
            while (n != null)
            {
                int cmp = (n.item as IComparable).CompareTo(mx);
                bool ok = cmp > 0;
                if (ok)
                {
                    mx = n.item;
                }
                n = n.next;
            }
            return mx;
        }
        public T getMin()
        {
            if (empty())
                throw new Exception("list is empty");
            T mn = head.item;
            Node n = head;
            while (n != null)
            {
                int cmp = (mn as IComparable).CompareTo(n.item);
                bool ok = cmp > 0;
                if (ok)
                {
                    mn = n.item;
                }
                n = n.next;
            }
            return mn;
        }
        public T display(int k)
        {
            if (k > len || k < 0)
                throw new Exception("out of list");
            if(empty())
                throw new Exception("list is empty");
            Node a = head;
            while(a != null && k > 0)
            {
                k--;
                a = a.next;
            }
            return a.item;
        }
        public T front()
        {
            if (empty())
                throw new Exception("out of list");
            return head.item;
        }
        public void concat(SigleLinkedList<T> l2)
        {
            while(!l2.empty())
            {
                push_back(l2.front());
                l2.pop_front();
            }
        }
    }
}
