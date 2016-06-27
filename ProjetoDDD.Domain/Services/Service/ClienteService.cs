using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using System.Diagnostics;
using ProjetoDDD.Domain.Interfaces.Repository;

namespace ProjetoDDD.Domain.Services.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository repository;

        public ClienteService(IClienteRepository repository)
        {
            this.repository = repository;
        }

        public void AdicionaCliente(Cliente cliente)
        {
            this.repository.AdicionaCliente(cliente);
        }

        public void AtualizaCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void DefinirClienteVip()
        {
            Debug.WriteLine("Cliente vip OK!");
        }

        public void EnviarEmailPromocao()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObtemTodos()
        {
            return this.repository.ObtemTodos();
        }

        public Cliente ObterCliente(int id)
        {
            return repository.ObterCliente(id);
        }

        public void RemoveCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}