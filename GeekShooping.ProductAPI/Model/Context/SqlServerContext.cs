using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Model.Context
{
    public class SqlServerContext(DbContextOptions<SqlServerContext> options) : DbContext(options)
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerContext).Assembly);
        //}

        public DbSet<Product> Products { get; set; }
    }
}
