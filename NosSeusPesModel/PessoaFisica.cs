﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPesModel
{
    public class PessoaFisica:Pessoa
    {
        //public int Nome { get; set; }
        public String CPF { get; set; }
        public DateTime? Nascimento { get; set; }
        
        
    }
}
