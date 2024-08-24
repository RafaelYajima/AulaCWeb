using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPApp_aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program program = new Program();    
            string nomeCliente = ImprimeNomeCliente();
            Console.WriteLine(nomeCliente); 
        }

        private static string ImprimeNomeCliente()
        {
            Cliente cliente = new Cliente();
            cliente.SetId(1);
            cliente.SetName("Marcelo");

            Cliente clienteAmigo = new Cliente();
            clienteAmigo.SetId(2);
            clienteAmigo.SetName("Cleber");

            return cliente.GetName();
        }
    }
}
