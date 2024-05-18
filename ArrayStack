namespace main.Data_Structure
{
    public class ArrayStack<T>
    {
        private int top;
        private T[] items;
        private const int MAX_SIZE = 100;

        public ArrayStack()
        {
            top = -1;
            items = new T[MAX_SIZE];
        }

        public bool IsEmpty()
        {
            return top < 0;
        }

        public void Push(T element)
        {
            if (top >= MAX_SIZE - 1)
            {
                Console.WriteLine("Stack full on push");
            }
            else
            {
                top++;
                items[top] = element;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack empty on pop");
            }
            else
            {
                T item = items[top];
                top--;
                return item;
            }
        }

        public T GetTop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack empty on pop");
            }
            else
            {
                return items[top];
            }
        }

        public void Print()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write(items[i] + " ");
            }
        }
    }
}
