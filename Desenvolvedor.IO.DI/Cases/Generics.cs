namespace Desenvolvedor.IO.DI.Cases
{
    public interface IGenericRepository<T> where T : class
    {
        void Adicionar(T obj);
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Adicionar(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
