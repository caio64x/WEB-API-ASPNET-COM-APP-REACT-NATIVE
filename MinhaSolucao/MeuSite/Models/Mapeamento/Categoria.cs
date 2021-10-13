using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeuSite.Models.Mapeamento
{
    public class Categoria
    {
        [Display(Name = "Código")]
        public int ID { get; set; }
        
        [Display(Name = "Nome da Categoria")]
        public string Nome { get; set; }
    }
}