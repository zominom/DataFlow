namespace Generics
{
    internal class DataFlow<T> : IDataFlow<T>
        where T : class
    {
        private readonly List<IBlock<T>> _data = new List<IBlock<T>>();

        public void AddBlock(IBlock<T> block)
        {
            if (block != null)
            {
                _data.Add(block);
            }
        }

        public T RunFlow(T input)
        {
            if (input != null)
            {
                T value = input;
                _data.ForEach(item =>
                {
                    value = item.Process(value);
                });
                return value;
            }
            return input;
        }

    }
}
