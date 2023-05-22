using BlogPessoal.Web.Models.Artigos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class ArtigoMap : EntityTypeConfiguration<Artigo>
    {
        public ArtigoMap()
        {
            ToTable("artigo", "dbo");
            HasKey(x => x.Id);

            Property(x => x.Titulo).IsRequired().HasMaxLength(300).HasColumnName("titulo");
            Property(x => x.Conteudo).IsRequired().HasColumnName("conteudo");
            Property(x => x.DataPublicacao).IsRequired().HasColumnName("data_publicacao");
            Property(x => x.CategoriaDeArtigoId).IsRequired().HasColumnName("categoria_id");
            Property(x => x.AutorId).IsRequired().HasColumnName("autor_id");
            Property(x => x.Removido).IsRequired().HasColumnName("removido");


            HasRequired(t => t.CategoriaDeArtigo)
                .WithMany(t => t.Artigos)
                .HasForeignKey(t => t.CategoriaDeArtigoId)
                .WillCascadeOnDelete(false);

            HasRequired(t => t.Autor)
                .WithMany(t => t.Artigos)
                .HasForeignKey(t => t.AutorId)
                .WillCascadeOnDelete(false);

            
        }
    }
}