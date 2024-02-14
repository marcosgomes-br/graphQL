using Microsoft.EntityFrameworkCore;

namespace GraphQL.API
{
    public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
