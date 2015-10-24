using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
   public  class Produto
    {
       [Key]
       public int ProdutoId { get; set; }

       public string Nome { get; set; }


       public string Descricao { get; set; }

       public Decimal Preco { get; set; }

       public string Categoria { get; set; }


    }
}
