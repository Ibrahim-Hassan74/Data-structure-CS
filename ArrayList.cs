namespace main.DataStructure
{
    public class ArrayList<T> where T : IComparable
    {
        const int N = 10000;
        private T[] a = new T[N];
        private int size;
        public ArrayList() {}
        public ArrayList(int sz)
        {
            this.size = sz;
        }
        public T this[int indx]
        {
            get
            {
                if (indx >= size || indx < 0)
                    throw new IndexOutOfRangeException("out of range");
                return a[indx];
            }
            set
            {
                if (indx >= size || indx < 0)
                    throw new IndexOutOfRangeException("out of range");
                a[indx] = value;
            }
        }
        public void push_back(T val)
        {
            if (size == N)
                throw new Exception("the array is full size");
            a[size++] = val;
        }
        public void pop_back()
        {
            if (isEmpty())
            {
                throw new Exception("the array is empty");
            }
            size--;
        }
        public int Size() => size;
        public void print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public T front()
        {
            if (isEmpty())
                throw new Exception("array is Empty");
            return a[0];
        }
        public T back()
        {
            if (isEmpty())
                throw new Exception("array is Empty");
            return a[size - 1];
        }
        public void insert(T val, int indx)
        {
            if (size == N)
                throw new Exception("the array is full size");
            else if (indx < 0 || indx >= size)
                throw new IndexOutOfRangeException();
            for (int i = size; i > indx; i--)
            {
                a[i] = a[i - 1];
            }
            a[indx] = val;
            size++;
        }
        public T Begin() => a[0];
        public T End() => a[size - 1];
        public void erase(int index)
        {
            if (isEmpty())
                throw new Exception("array is Empty");
            else if (index < 0 || index > size)
                throw new IndexOutOfRangeException();
            for (int i = index; i < size; i++)
            {
                a[i] = a[i + 1];   
            }
            size--;
        }
        public int BinarySearch(int l, int r, T val)
        {
            if (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (object.Equals(a[mid], val))
                    return mid;
                int cmp = (a[mid] as IComparable).CompareTo(val);
                bool ok = cmp > 0;
                if (ok)
                    return BinarySearch(l, mid - 1, val);
                else
                    return BinarySearch(mid + 1, r, val);
            }
            return -1;
        }
        public int LinearSearch(T val)
        {
            for (int i = 0; i < size; i++)
            {
                if (object.Equals(a[i], val))
                    return i;
            }
            return -1;
        }
        public bool isEmpty() => size == 0;
        public void clear()
        {
            a = null;
            size = 0;
        }
    }
}
