using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BanhKemStore.Models
{
    public class MyCart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(BanhKem banhkem, int quantity)
        {
            CartLine line = Lines
            .Where(b => b.BanhKem.BanhKemID == banhkem.BanhKemID)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    BanhKem = banhkem,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(BanhKem banhkem) =>
        Lines.RemoveAll(l => l.BanhKem.BanhKemID == banhkem.BanhKemID);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.BanhKem.Price * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public BanhKem BanhKem { get; set; }
        public int Quantity { get; set; }
    }
}