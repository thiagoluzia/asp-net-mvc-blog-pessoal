using BlogPessoal.Web.Models.Artigos;
using System.Data.Entity.ModelConfiguration;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class ArtigoMap : EntityTypeConfiguration<Artigo>
    {
        /// <summary>
        /// Classe responsável por mapear os campos do banco de dados na model.
        /// </summary>
        public ArtigoMap()
        {
            //PROPIEDADE DA TABELA COMO ELA É NO BANCO DE DADOS
            ToTable("artigo", "dbo");
            HasKey(x => x.Id);

            //PROPIEDADES DOS CAMPOS COMO SÃO NO BANCO DE DADOS
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).HasColumnName("id");
            Property(x => x.Titulo).IsRequired().HasMaxLength(300).HasColumnName("titulo");
            Property(x => x.Conteudo).IsRequired().HasColumnName("conteudo");
            Property(x => x.DataPublicacao).IsRequired().HasColumnName("data_publicacao");
            Property(x => x.CategoriaDeArtigoId).IsRequired().HasColumnName("categoria_id");
            Property(x => x.AutorId).IsRequired().HasColumnName("autor_id");
            Property(x => x.Removido).IsRequired().HasColumnName("removido");

            
            //TEM QUE TER UMA CATEGORIA 
            HasRequired(t => t.CategoriaDeArtigo)
                .WithMany(t => t.Artigos)
                .HasForeignKey(t => t.CategoriaDeArtigoId)
                .WillCascadeOnDelete(false);

            // TEM QUE TER UM AUTOR
            HasRequired(t => t.Autor)
                .WithMany(t => t.Artigos)
                .HasForeignKey(t => t.AutorId)
                .WillCascadeOnDelete(false);
            
            
        }
    }
}