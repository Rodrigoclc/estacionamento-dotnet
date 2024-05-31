using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("veiculo adicionado");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("veivulo removido");
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("lista de veiculos");
        }
    }
}