using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPesModel
{
    public class PessoaJuridica:Pessoa
    {
        public String CNPJ { get; set; }
        public String RazaoSocial { get; set; }   
        public String Endereco{ get; set; }
        public String Complemento { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set;
        }

    }
}
