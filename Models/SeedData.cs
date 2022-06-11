using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace BanhKemStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BanhKemStoreDbContext context =
           app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < BanhKemStoreDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.BanhKems.Any())
            {
                context.BanhKems.AddRange(
                new BanhKem
                {
                    Title = "Bánh Tiệc Cưới",
                    Description = "Bánh cưới từ xa xưa đã là một biểu tượng mang 1 thông điệp về tương lai hạnh phúc và tròn đầy! Đến ngày nay, thì bánh cưới đã trở thành một vật phẩm quan trọng không thể thiếu trong lễ cưới của các cặp đôi! Thế nhưng, không phải ai cũng có thể hiểu rõ về nguồn gốc lịch sử cũng như những ý nghĩa mà chiếc bánh cưới tượng trưng.",             
                    Genre = "",
                    Price = 11.98m
                },
                new BanhKem
                {
                    Title = "Bánh Sinh Nhật",
                    Description = "Bánh sinh nhật là một loại bánh thường có ý nghĩa quan trọng và đặc biệt nhất trong dịp kỷ niệm sinh nhật của người dùng. Đây là một loại bánh ngọt dạng tháp như bánh bông lan xốp và được phủ lên một lớp kem dày hoặc mỏng vừa để trang trí vừa để tăng thêm hương vị cho bánh.",               
                    Genre = "",
                    Price = 17.46m
                },
                new BanhKem
                {
                    Title = "Bánh Thôi Nôi",
                    Description = "Lễ cúng thôi nôi là một nét văn hóa đặc trưng của người Việt với mong muốn cầu cho trẻ nhỏ được khỏe mạnh và hạnh phúc.",              
                    Genre = "",
                    Price = 13.41m
                },
                new BanhKem
                {
                    Title = "Bánh Tình Bạn",
                    Description = "Bánh kem tình bạn thể hiện quan hệ hai chiều giữa 2 người với  nhau",              
                    Genre = "",
                    Price = 18.69m
                },
                new BanhKem
                {
                    Title = "Bánh Ngọt",
                    Description = "Bánh ngọt là một trong những món ăn được rất nhiều người yêu thích, những chiếc bánh ngọt ngon kết hợp với ly cà phê nóng sẽ mang lại sự thoải mái, giúp giảm streess và căng thẳng. Thưởng thức một chiếc bánh ngọt được ví như tận hưởng một thú vui bởi nuông chiều vị giác, làm thỏa mãn bản thân sau những giờ làm việc hay học tập căng thẳng. Có thể nói bánh ngọt là một món ăn giúp xoa dịu tâm hồn.",             
                    Genre = "",
                    Price = 31.26m
                }
                );
                context.SaveChanges();
            }
        }
    }
}