namespace GraphQL.API
{
    public class Produto
    {
        public Produto() { ; }
        public Produto(string codigoBarra, string descricao, 
            decimal precoCusto, decimal precoVenda, decimal peso, 
            decimal altura, decimal largura, decimal comprimento, int estoque)
        {
            CodigoBarra = codigoBarra;
            Descricao = descricao;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            Peso = peso;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
            Estoque = estoque;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string CodigoBarra { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Comprimento { get; set; }
        public int Estoque { get; set; }
    }
}
