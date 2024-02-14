using Microsoft.EntityFrameworkCore;

namespace GraphQL.API.Queries
{
    public class ProdutoQuery
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Produto> Get([Service] ApiContext context) => context.Produtos.AsQueryable();

        [UseProjection]
        public IQueryable<Produto> Post([Service] ApiContext context)
        {
            if (context.Produtos.Any()) return context.Produtos.AsQueryable();
            List<Produto> listaProdutos = new List<Produto>
            {
                new Produto("123456", "Produto 1", 10.00m, 20.00m, 0.5m, 10.0m, 5.0m, 15.0m, 1),
                new Produto("789012", "Produto 2", 15.00m, 25.00m, 0.7m, 12.0m, 6.0m, 18.0m, 2),
                new Produto("345678", "Produto 3", 20.00m, 30.00m, 0.8m, 14.0m, 7.0m, 20.0m, 4),
                new Produto("321128", "Produto 4", 40.00m, 50.00m, 0.3m, 12.0m, 1.0m, 10.0m, 5),
                new Produto("566568", "Produto 5", 20.00m, 30.00m, 0.8m, 14.0m, 7.0m, 20.0m, 9),
            };
            context.Produtos.AddRange(listaProdutos);
            context.SaveChanges();
            return context.Produtos.AsQueryable();
        }
    }
}
