using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Data.Mappings
{
    public class AnuncioMap : IEntityTypeConfiguration<Anuncio>
    {
        public void Configure(EntityTypeBuilder<Anuncio> builder)
        {
            builder.ToTable("tb_AnuncioWebmotors");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.marca).IsRequired().HasMaxLength(45);
            builder.Property(x => x.modelo).IsRequired().HasMaxLength(45);
            builder.Property(x => x.versao).IsRequired().HasMaxLength(45);
            builder.Property(x => x.ano).IsRequired();
            builder.Property(x => x.quilometragem).IsRequired();
            builder.Property(x => x.observacao).IsRequired();
        }
    }
}
