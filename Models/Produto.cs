using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dot_project.Models
{
    public class Produto
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Imagem")]
        public string pathImagem { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Categoria")]
        public Categoria Categoria { get; set; } = null!;
    }
}