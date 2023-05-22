using BlogPessoal.Web.Models.CategoriasDeArtigo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BlogPessoal.Web.Data.Mapeamento;
using BlogPessoal.Web.Models.Artigos;
using BlogPessoal.Web.Models.Autores;

namespace BlogPessoal.Web.Data
{
    public class BlogPessoalContexto : DbContext
    {
        DbSet<CategoriaDeArtigo> CategoriaDeArtigos { get; set; }
        DbSet<Artigo> Artigos { get; set; }
        DbSet<Autor> Autor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaDeArtigoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}