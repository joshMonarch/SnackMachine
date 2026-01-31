namespace SnackMachine.Application.Abstractions
{
    public interface IDeleteRepository<T>
    {
        public Task<bool> DeleteAsync(T entity);
    }
}
