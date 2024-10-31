using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVeiculos
{
    internal class VeiculoDAO
    {
        public List<Veiculo> listaVeiculos = new List<Veiculo>();

        public void Cadastrar(Veiculo v)
        {
            listaVeiculos.Add(v); //Adicionando o veículo na lista criada acima.
        }

        public List<Veiculo> ListarTodos() 
        { 
            return listaVeiculos; 
        }

        public void Remover(string placa)
        {
            Veiculo vExcluir = listaVeiculos.First(p => p.placa == placa);
            listaVeiculos.Remove(vExcluir);
        }

        public Veiculo BuscarPlaca(string placa) 
        {
            Veiculo vBuscar = listaVeiculos.First(p => p.placa == placa);
            return vBuscar;
        }

    }
}
