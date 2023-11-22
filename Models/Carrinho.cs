using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dot_project.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        // public virtual ICollection<int> Produtos2 { get; set; }
    }
}