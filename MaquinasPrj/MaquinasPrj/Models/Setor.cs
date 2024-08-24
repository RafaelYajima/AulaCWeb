using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasPrj.Models
{
    public class Setor
    {
        public Setor(int setorId, string nome)
        {
            SetorId = setorId;
            Nome = nome;
        }

        public int SetorId { get; set; }
        public string Nome { get; set; }
    }
}
