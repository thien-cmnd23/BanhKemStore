using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace BanhKemStore.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private BanhKemStoreDbContext context;
        public EFOrderRepository(BanhKemStoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
        .Include(o => o.Lines)
        .ThenInclude(l => l.BanhKem);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.BanhKem));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}