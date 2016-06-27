using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDDD.Application.Interfaces
{
    public interface IAppClienteService 
    {
        void AdicionaCliente(Cliente cliente);
        Cliente ObterCliente(int id);
        List<Cliente> ObtemTodos();
        void AtualizaCliente(Cliente cliente);
        void RemoveCliente(int id);
        void DefinirClienteVip();
    }
}
