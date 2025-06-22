public interface IBlock<T> where T : class
{
    T Process(T input);
}


public interface IDataFlow<T> where T : class
{
    T RunFlow(T input);
    void AddBlock(IBlock<T> block);
}

