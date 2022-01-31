using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivroApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivroApi.Data.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnType("int");                
            
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnType("numeric(18,2)")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Categoria)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(p => p.Img)
                .HasColumnType("varchar(20)")
                .IsRequired();                            
        }
    }
}
