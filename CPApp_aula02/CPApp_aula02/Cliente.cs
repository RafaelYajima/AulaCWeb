using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPApp_aula02
{
    internal class Cliente
    {
        private int Id;
        private string Name;

        public void SetId(int id)
        {
            this.Id = id;
        }

        public int GetId()
        {
            return this.Id;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName() { 
            return this.Name; 
        }

    }
}
