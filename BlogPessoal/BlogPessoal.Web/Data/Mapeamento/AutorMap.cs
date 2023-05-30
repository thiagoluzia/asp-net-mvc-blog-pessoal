using BlogPessoal.Web.Models.Autores;
using System.Data.Entity.ModelConfiguration;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        /// <summary>
        /// Classe responsável por mapear os campos do banco de dados na model.
        /// </summary>
        public AutorMap()
        {
            //PROPIEDADE DA TABELA COMO ELA É NO BANCO DE DADOS
            ToTable("autor");
            HasKey(x => x.Id);

            //PROPIEDADES DOS CAMPOS COMO SÃO NO BANCO DE DADOS
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).HasColumnName("id");
            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(x => x.Email).IsRequired().HasMaxLength(150).HasColumnName("email");
            Property(x => x.Senha).IsRequired().HasMaxLength(50).HasColumnName("senha");
            Property(x => x.DataCadastro).IsRequired().HasColumnName("data_cadastro");
        }
    }
}