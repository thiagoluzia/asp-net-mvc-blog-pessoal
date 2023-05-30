using BlogPessoal.Web.Data;
using BlogPessoal.Web.Models.CategoriasDeArtigo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BlogPessoal.Tests
{
    [TestClass]
    public class CategoriaDeArtigoTeste
    {
        private BlogPessoalContexto ctx; 
        public CategoriaDeArtigoTeste()
        {
            ctx = new BlogPessoalContexto();
        }

        [TestMethod]
        public void Consultar_artigo_com_sucesso()
        {
            
           
            var obj = ctx.CategoriasDeArtigo.FirstOrDefault();

            Assert.IsNotNull(obj);
        }
        [TestMethod]
        public void Create_categoria_artigo_com_sucesso()
        {
            var categorias = new List<CategoriaDeArtigo>
           {
               new CategoriaDeArtigo{Nome = "Filosofia",Descricao="Filosofia em geral"},
               new CategoriaDeArtigo{Nome = "Nerd",Descricao="nerd em geral"},
               new CategoriaDeArtigo{Nome = "Comedia",Descricao="comedia em geral"},
               new CategoriaDeArtigo{Nome = "Terror",Descricao="terror em geral"}
           };

            foreach(var categoria in categorias)
            {
                ctx.CategoriasDeArtigo.Add(categoria);
                ctx.SaveChanges();
            }
        }
    }
}
