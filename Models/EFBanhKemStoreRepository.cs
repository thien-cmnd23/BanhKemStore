using System.Linq;
namespace BanhKemStore.Models
{
    public class EFBanhKemStoreRepository : IBanhKemStoreRepository
    {
        private BanhKemStoreDbContext context;
        public EFBanhKemStoreRepository(BanhKemStoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<BanhKem> BanhKems => context.BanhKems;
        public void CreateBanhKems(BanhKem b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteBanhKems(BanhKem b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveBanhKems(BanhKem b)
        {
            context.SaveChanges();
        }
    }
}