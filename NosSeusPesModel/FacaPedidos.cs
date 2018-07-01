using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPesModel
{
    class FacaPedidos
    {
        
         public IList<Pedido> ObterPedidos()
         {

            ModelPedido ctx = new ModelPedido();
              return ctx.Pedidos.ToList();
         }

        public IList<Sapato> ObterSapatos()
        {

            ModelPedido ctx = new ModelPedido();
            return ctx.Sapatos.ToList();
        }

    }
}
