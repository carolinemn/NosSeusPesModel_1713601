using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPesModel
{
    public class Pessoa
    {
        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                return (this.Id == ((Pessoa)obj).Id);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public int Id { get; set; }
        public String Nome { get; set; }
       // public DateTime? Registro { get; set; }


    }

}

