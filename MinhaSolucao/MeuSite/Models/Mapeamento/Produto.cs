using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeuSite.Models.Mapeamento
{
    public class Produto
    {
        public int ID { get; set; }
        public int IDCategoria { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        //relacionamentos
        [Display(Name = "Nome da Categoria")]
        public Categoria Categoria { get; set; }
    }
}