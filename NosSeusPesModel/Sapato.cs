using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPesModel
{
    public class Sapato
    {
       // Nome • Presença ou não de cadarço. 
       //• Material.  • Cor • Preço
        public String Nome { get; set; }
        public String Cardaco { get; set; }
        public String Material { get; set; }
        public String Cor { get; set; }
        public Char Tamanho { get; set; }
        public Decimal Preco { get; set; }
        public Char Quantidade { get; set; }
                
    }
}
