using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dot_project.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int Descricao { get; set; }
        public string pathImagem { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdCategoria { get; set; }
    }
}