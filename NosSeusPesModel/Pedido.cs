using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPesModel
{
    public class Pedido
    {

        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public virtual ICollection<Pessoa> Pessoas{ get; set; }
        = new List<Pessoa>();

        public virtual ICollection<Sapato> Sapatos{ get; set; }
        = new List<Sapato>();

        
    }
}
