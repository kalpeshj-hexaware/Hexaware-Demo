namespace restapione.Data.Interfaces
{
    public interface IUpdate<T, U> where T : class
    {
        T Update(U id, T entity);
    }
}
