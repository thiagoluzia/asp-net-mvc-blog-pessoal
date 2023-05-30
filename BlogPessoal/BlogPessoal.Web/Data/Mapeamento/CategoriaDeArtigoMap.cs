using BlogPessoal.Web.Models.CategoriasDeArtigo;
using System.Data.Entity.ModelConfiguration;


namespace BlogPessoal.Web.Data.Mapeamento
{
    public class CategoriaDeArtigoMap : EntityTypeConfiguration<CategoriaDeArtigo>
    {
        /// <summary>
        /// Classe responsável por mapear os campos do banco de dados na model.
        /// </summary>
        public CategoriaDeArtigoMap()
        {
            //PROPIEDADE DA TABELA COMO ELA É NO BANCO DE DADOS
            ToTable("categoria_artigo", "dbo");
            HasKey(x => x.Id);

            //PROPIEDADES DOS CAMPOS COMO SÃO NO BANCO DE DADOS
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).HasColumnName("id");
            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(x => x.Descricao).IsOptional().HasMaxLength(300).HasColumnName("descricao");
        }

    }
}