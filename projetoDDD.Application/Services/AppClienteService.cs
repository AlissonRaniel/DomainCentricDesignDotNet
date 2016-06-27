using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using projetoDDD.Application.Interfaces;

namespace projetoDDD.Application.Services
{
    public class AppClienteService : IAppClienteService
    {
        private IClienteService service;

        public AppClienteService(IClienteService service)
        {
            this.service = service;
        }

        public void AdicionaCliente(Cliente cliente)
        {
            this.service.AdicionaCliente(cliente);
        }

        public void AtualizaCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void DefinirClienteVip()
        {
            this.service.DefinirClienteVip();
        }

        public List<Cliente> ObtemTodos()
        {
            return this.service.ObtemTodos();
        }

        public Cliente ObterCliente(int id)
        {
            return service.ObterCliente(id);
        }

        public void RemoveCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
