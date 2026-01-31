namespace SnackMachine.Application.Abstractions
{
    public interface IReadRepository<T>
    {
        public Task<T?> GetByIdAsync(int id);
        public Task<IEnumerable<T>> ListAllAsync();
    }
}
