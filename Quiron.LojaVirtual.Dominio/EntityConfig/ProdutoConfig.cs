using System.Data.Entity.ModelConfiguration;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(c => c.ProdutoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            
            Property(c => c.Preco)
                .IsRequired();
            
            Property(c => c.Categoria)
                .IsRequired()
                .HasMaxLength(60);


            ToTable("Produtos");
        }
    }
}