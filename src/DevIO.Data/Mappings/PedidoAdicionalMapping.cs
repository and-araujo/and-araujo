using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class PedidoAdicionalMapping : IEntityTypeConfiguration<PedidoAdicional>
    {
        public void Configure(EntityTypeBuilder<PedidoAdicional> builder)
        {
            builder.HasKey(p => p.Id);

            //builder.HasOne(bc => bc.Pedido)
            // .WithMany(b => b.PedidoAdicionais)
            //  .HasForeignKey(bc => bc.PedidoId);

            //builder.HasOne(bc => bc.Adicional)
            // .WithMany(b => b.PedidoAdicionais)
            //  .HasForeignKey(bc => bc.AdicionalId);

        }
    }
}
