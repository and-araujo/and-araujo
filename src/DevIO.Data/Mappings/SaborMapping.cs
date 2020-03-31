using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class SaborMapping : IEntityTypeConfiguration<Sabor>
    {
        public void Configure(EntityTypeBuilder<Sabor> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(50)");

            //builder.Property(p => p.ValorAdicional)
            //    .HasColumnType("decimal(5,2)");

            //builder.Property(p => p.TempoAdicional)
            //    .HasColumnType("int");

            //builder.Property(p => p.Adicional)
            //    .HasColumnType("bit");
        }
    }
}
