using ProjetoDDD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infra.Data.Entity;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private BancoDeDados banco = new BancoDeDados();

        public void AdicionaCliente(Cliente cliente)
        {
            banco.Clientes.Add(cliente);
            banco.SaveChanges();
        }

        public void AtualizaCliente(Cliente cliente)
        {
            banco.Clientes.Add(cliente);
            banco.SaveChanges();
        }

        public void DefinirClienteVip()
        {
            throw new NotImplementedException();
        }
        
        public List<Cliente> ObtemTodos()
        {
            return banco.Clientes.ToList();
        }

        public Cliente ObterCliente(int id)
        {
            return banco.Clientes.Find(id);
        }

        public void RemoveCliente(int id)
        {
            banco.Clientes.Remove(banco.Clientes.Find(id));
            banco.SaveChanges();
        }
    }
}