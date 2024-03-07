namespace main.DataStructure
{
    public class ArrayQueue<T>
    {
        private static int N = 100;
        private int begin;
        private int rear;
        private int sz;
        private T[] arr = new T[N];
        public ArrayQueue()
        {
            begin = 0;
            rear = N - 1;
            sz = 0;
        }
        public ArrayQueue(int s)
        {
            if (s < 0)
                throw new ArgumentOutOfRangeException("s");
            N = s;
            arr = new T[N];
            begin = 0;
            rear = N - 1;
            sz = 0;
        }
        public bool isEmpty()
        {
            return sz == 0;
        }
        public bool isFull()
        {
            return sz == N;
        }
        public void push(T val)
        {
            if (isFull())
                throw new Exception("Queue is full");
            sz++;
            rear = (rear + 1) % N;
            arr[rear] = val;
        }
        public void pop()
        {
            if (isEmpty())
                throw new Exception("Queue is empty");
            sz--;
            begin = (begin + 1) % N;
        }
        public void pop(ref T val)
        {
            if (isEmpty())
                throw new Exception("Queue is empty");
            val = arr[begin];
            sz--;
            begin = (begin + 1) % N;
        }
        public T front()
        {
            if (isEmpty())
                throw new Exception("Queue is empty");
            return arr[begin];
        }
        public T back()
        {
            if (isEmpty())
                throw new Exception("Queue is empty");
            return arr[rear];
        }
        public void print()
        {
            if (isEmpty())
                throw new Exception("Queue is empty");
            for (int i = begin; i != rear + 1; i = (i + 1) % N)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
