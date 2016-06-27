using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.Service
{
    public interface IClienteService
    {
        void AdicionaCliente(Cliente cliente);
        Cliente ObterCliente(int id);
        List<Cliente> ObtemTodos();
        void AtualizaCliente(Cliente cliente);
        void RemoveCliente(int id);
        void DefinirClienteVip();

        void EnviarEmailPromocao();




    }
}