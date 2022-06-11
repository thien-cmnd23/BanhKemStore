using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanhKemStore.Models.ViewModels
{
    public class BanhKemListViewModel
    {
        public IEnumerable<BanhKem> BanhKems { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}
