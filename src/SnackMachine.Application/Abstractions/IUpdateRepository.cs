namespace SnackMachine.Application.Abstractions
{
    public interface IUpdateRepository<T>
    {
        public Task<T>? UpdateAsync(T entity);
    }
}
