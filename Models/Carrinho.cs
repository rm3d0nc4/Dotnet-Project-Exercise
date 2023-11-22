using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dot_project.Models
{
    public class Carrinho
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "IdUsuario")]
        public int IdUsuario { get; set; }
        [Display(Name = "Produtos")]
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        // public virtual ICollection<int> Produtos2 { get; set; }
    }
}