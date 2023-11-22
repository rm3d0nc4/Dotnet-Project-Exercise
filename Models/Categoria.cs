using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dot_project.Models
{
    public class Categoria
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; } = new List<Produto>();
    }
}