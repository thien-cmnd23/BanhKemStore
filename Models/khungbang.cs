using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanhKemStore.Models
{
    public class khungbang
    {
        [Key]
        public long BanhkemID { get; set; }
        [Display(Name = "Tên Khách Hàng")] public long BanhKemID { get; set; }
        [Display(Name = "Tên loại bánh")] public string Title { get; set; }
        [Display(Name = "Giá Bánh")] public decimal Price { get; set; }
        [Display(Name = "Size Bánh")] public string Genre { get; set; }
        [Display(Name = "Ngày Giao Hàng")] [Column(TypeName = "decimal(8, 2)")] public string Description { get; set; }
        public string ProfilePicture { get; set; }
    }
}
    

