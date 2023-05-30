using BlogPessoal.Web.Models.Artigos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models.CategoriasDeArtigo
{
    /// <summary>
    /// Classe model de categoria de artigo
    /// </summary>
    public class CategoriaDeArtigo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name ="Nome da categoria")]
        [StringLength(150)]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, MinimumLength = 3)]
        public string Descricao { get; set; }

        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}