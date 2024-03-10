namespace main
{
    public class linkedlist
    {
        public class Node
        {
            public int item;
            public Node next;
            public Node(int item)
            {
                this.item = item;
                this.next = null;
            }
        }
        public Node head, tail;
        private int len;
        public linkedlist()
        {
            head = tail = null;
            len = 0;
        }
        public bool empty()
        {
            /*if (len == 0)
                return true;
            else
                return false;*/
            return len == 0;
        }
        public void push_front(int val)
        {
            Node newnode = new Node(val);
            if (empty())
            {
                head = tail = newnode;
            }
            else
            {
                newnode.next = head;
                head = newnode;
            }
            len++;
        }
        public int Getfront()
        {
            if (empty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                return head.item;
            }
            return 0;
        }
        public void push_back(int val)
        {
            Node newnode = new Node(val);
            if (empty())
            {
                head = tail = newnode;
            }
            else
            {
                tail.next = newnode;
                tail = newnode;
            }
            len++;
        }
        public int Getback()
        {
            if (empty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                return tail.item;
            }
            return 0;
        }
        public void print()
        {
            Node newnode = head;
            while (newnode != null)
            {
                Console.Write(newnode.item + " ");
                newnode = newnode.next;
            }
        }
        public void insertAt(int pos,int val)
        {
            if(pos < 0 || pos > len)
            {
                Console.WriteLine("Error");
                return;
            }
            if(pos == 0)
            {
                push_front(val);
            }
            else if(pos == len)
            {
                push_back(val);
            }
            else
            {
                Node newnode = new Node(val);
                Node cur = head;
                for(int i = 1;i < pos; i++)
                {
                    cur = cur.next;
                }
                newnode.next = cur.next;
                cur.next = newnode;
                len++;
            }
        }
        public void pop_front()
        {
            if (empty())
            {
                Console.WriteLine("empty Linked List");
                return;
            }
            if(len == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
            }
            len--;
        }
        public void pop_back()
        {
            if (empty())
            {
                Console.WriteLine("empty Linked List");
                return;
            }
            if (len == 1)
            {
                head = tail = null;
            }
            else
            {
                Node cur = head;
                while (cur.next != tail)
                {
                    cur = cur.next;
                }
                cur.next = null;
                tail = cur;
            }
            len--;
        }
        public void erase(int element)
        {
            if (empty())
            {
                Console.WriteLine("empty Linked List");
                return;
            }
            if(head.item == element)
            {
                pop_front();
                return;
            }
            Node cur = head.next;
            Node prev = head;
            while(cur != null)
            {
                if(cur.item == element)
                {
                    break;
                }
                prev = cur;
                cur = cur.next;
            }
            if(cur == null)
            {
                Console.WriteLine("Element Not found");
                return;
            }
            prev.next = cur.next;
            if(cur == tail)
            {
                tail = prev;
            }
            len--;
        }
        public int size()
        {
            return len;
        }
        public bool find(int val)
        {
            Node cur = head;
            while(cur != null)
            {
                if(cur.item == val)
                    return true;
                cur = cur.next;
            }
            return false;
        }
        public Node begin()
        {
            return head;
        }
        public void copy(linkedlist l2)
        {
            while(l2.size() > 0)
            {
                push_back(l2.Getfront());
                l2.pop_front();
            }
        }
        public void sort()
        {
            Node node = head;
            while(node != null)
            {
                Node tmp = node;
                Node cur = node.next;
                while(cur != null)
                {
                    if(tmp.item > cur.item)
                    {
                        tmp = cur;
                    }
                    cur = cur.next;
                }
                (node.item, tmp.item) = (tmp.item, node.item);
                node = node.next;
            }
        }
        public void Sort()
        {
            Node node = head;
            while (node != null)
            {
                //Node tmp = node;
                Node cur = node.next;
                while (cur != null)
                {
                    if (node.item > cur.item)
                    {
                        //node.item = cur.item;
                        (node.item, cur.item) = (cur.item, node.item);
                    }
                    cur = cur.next;
                }
                node = node.next;
            }
        }

    }
}
