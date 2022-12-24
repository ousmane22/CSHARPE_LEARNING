namespace WiredBrainCoffee
{
     class StackSimple<T>
    {
        private readonly T[] _items;
        private int _currendIndex = -1;

        public StackSimple() =>  _items = new T[10];

        public int Count => _currendIndex + 1;
        public void Push(T item) => _items[++_currendIndex] = item;
        public T Pop() => _items[_currendIndex--];
    }
}