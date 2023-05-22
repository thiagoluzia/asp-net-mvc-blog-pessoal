using BlogPessoal.Web.Models.CategoriasDeArtigo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


namespace BlogPessoal.Web.Data.Mapeamento
{
    public class CategoriaDeArtigoMap : EntityTypeConfiguration<CategoriaDeArtigo>
    {
        public CategoriaDeArtigoMap()
        {
            ToTable("categoria_artigo", "dbo");
            HasKey(x => x.Id);

            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(x => x.Descricao).IsRequired().HasMaxLength(300).HasColumnName("descricao");
        }

    }
}