using System.Transactions;

namespace BlockChain;

public interface IRepository<T>
{
    void Add(T entity);
    T Read(int id);
}