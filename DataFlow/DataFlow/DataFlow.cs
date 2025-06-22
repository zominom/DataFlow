using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class DataFlow<T> : IDataFlow<T>
        where T : class
    {
        private readonly List<IBlock<T>> _data = new List<IBlock<T>>();

        public void AddBlock(IBlock<T> block)
        {
            _data.Add(block);
        }

        public T RunFlow(T input)
        {
            T value = input;
            _data.ForEach(item =>
            {
                value = item.Process(value);
            });
            return value;
        }

    }
}
