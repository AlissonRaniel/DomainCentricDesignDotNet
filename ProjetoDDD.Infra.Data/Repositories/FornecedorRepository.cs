using ProjetoDDD.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infra.Data.Entity;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private BancoDeDados banco = new BancoDeDados();

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            banco.Fornecedores.Add(fornecedor);
            banco.SaveChanges();
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            banco.Fornecedores.Add(fornecedor);
            banco.SaveChanges();
        }

        public List<Fornecedor> ObtemTodos()
        {
            return banco.Fornecedores.ToList();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return banco.Fornecedores.Find(id);
        }

        public void RemoverFornecedor(int id)
        {
            banco.Fornecedores.Remove(banco.Fornecedores.Find(id));
            banco.SaveChanges();
        }
    }
}
