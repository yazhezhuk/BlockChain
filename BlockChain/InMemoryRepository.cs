namespace BlockChain;

public class InMemoryRepository<T> : IRepository<T> where T :  BaseEntity
{
    private readonly List<T> _localStorage;                                 

    public InMemoryRepository(List<T> collection=null)
    {
        _localStorage = new();
    }

    public void Add(T entity) => 
        _localStorage.Add(entity);

    public T Read(int id) => 
        _localStorage.First(e => e.Id == id);
}