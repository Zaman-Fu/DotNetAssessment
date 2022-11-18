using DotNetAssessment.Model;

namespace DotNetAssessment.Repository
{
    public interface IRepository<T>
    {
        ICollection<T> GetAll();
        bool AddItem(T item);

        bool ModifyItem(T item);

        bool DeleteItem(T item);
    }
}
