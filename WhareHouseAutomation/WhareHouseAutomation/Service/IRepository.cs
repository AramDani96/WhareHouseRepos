namespace WhareHouseAutomation.Service
{
    public interface IRepository<T> where T:class
    {
        Task AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<T> GetByAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
