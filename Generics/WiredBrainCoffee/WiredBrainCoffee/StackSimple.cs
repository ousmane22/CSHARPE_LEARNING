namespace WiredBrainCoffee
{
     class StackSimple
    {
        private readonly double[] _items;
        private int _currendIndex = -1;

        public StackSimple() =>  _items = new double[10];

        public int Count => _currendIndex + 1;
        public void Push(double item) => _items[++_currendIndex] = item;
        public double Pop() => _items[_currendIndex--];
    }
}