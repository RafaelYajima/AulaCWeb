using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinasPrj.Models
{
    public class Maquina
    {
        public Maquina(int maquinaId, string nome, string descricao, 
                       string fabricante, string dataAquisicao, int setorId, Setor setor)
        {
            MaquinaId = maquinaId;
            Nome = nome;
            Descricao = descricao;
            Fabricante = fabricante;
            DataAquisicao = dataAquisicao;
            SetorId = setorId;
            Setor = setor;
        }

        public int MaquinaId { get; set; }
        public string Nome {  get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public string DataAquisicao { get; set; }
        public int SetorId { get; set; }
        public virtual Setor Setor { get; set; }
    }
}
