using Domain;
using Dominio;
using System.Data.Entity;

namespace Data
{
    public class ProdutoDBContext : DbContext
    {
        public ProdutoDBContext() : base("Name=ProdutoDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ProdutoDBContext>());
            Database.Initialize(false);

            // Comando para mostrar o SQL no output
            Database.Log = (d => System.Diagnostics.Debug.WriteLine(d));
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}
