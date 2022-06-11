using System.Linq;
namespace BanhKemStore.Models
{
    public interface IBanhKemStoreRepository
    {
        IQueryable<BanhKem> BanhKems { get; }
        void SaveBanhKems(BanhKem b);
        void CreateBanhKems(BanhKem b);
        void DeleteBanhKems(BanhKem b);
    }
}