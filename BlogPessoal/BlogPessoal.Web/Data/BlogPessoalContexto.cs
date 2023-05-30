using BlogPessoal.Web.Data.Mapeamento;
using BlogPessoal.Web.Models.Artigos;
using BlogPessoal.Web.Models.Autores;
using BlogPessoal.Web.Models.CategoriasDeArtigo;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Diagnostics;

namespace BlogPessoal.Web.Data
{
    public class BlogPessoalContexto : DbContext
    {
        //CONSTRUTOR PEGANDO A SCRTING DE CONNEXAO
        public BlogPessoalContexto() : base(ConfigurationManager.ConnectionStrings["BlogPessoalContexto"].ConnectionString)
        {
            //Database.Log = Console.WriteLine;
        }

        //MODELO
        public DbSet<CategoriaDeArtigo> CategoriasDeArtigo { get; set; }
        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<Autor> Autores { get; set; }

        //MAPEAMENTO DO RETORNO DO BANCO PARA O MODELO
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaDeArtigoMap());
            modelBuilder.Configurations.Add(new ArtigoMap());
            modelBuilder.Configurations.Add(new AutorMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}