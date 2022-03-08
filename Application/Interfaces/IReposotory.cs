using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReposotory<T> where T : class
    {
        Task<IReadOnlyList<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        void Add(T entity);
        void DeleteAsync(T entity);
        Task<int> SaveChangesAsync();
        IQueryable<T> GetQueryAble();


    }
}