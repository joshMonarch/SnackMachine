namespace SnackMachine.Application.Abstractions
{
    public interface ICreateRepository<T>
    {
        public Task<T>? CreateAsync(T entity);
    }
}
