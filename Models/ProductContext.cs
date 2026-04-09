using Microsoft.EntityFrameworkCore;

namespace ShriFoodsProj.Models
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<ProductModel> ProductDBTable { get; set; }
        public DbSet<CartItem> CartItem { get; set; }

        //protected ProductDbContext()
        //{
        //}
    }
}
