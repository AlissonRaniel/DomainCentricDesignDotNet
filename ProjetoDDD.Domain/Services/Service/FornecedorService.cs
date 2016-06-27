using ProjetoDDD.Domain.Interfaces.Service;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;

namespace ProjetoDDD.Domain.Services.Service
{
    public class FornecedorService : IFornecedorService
    {
        private IFornecedorRepository fornecedor_repository;

        public FornecedorService(IFornecedorRepository repository)
        {
            this.fornecedor_repository = repository;
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            this.fornecedor_repository.AdicionaFornecedor(fornecedor);
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            this.fornecedor_repository.AtualizaFornecedor(fornecedor);
        }

        public List<Fornecedor> ObtemTodos()
        {
            return fornecedor_repository.ObtemTodos();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return fornecedor_repository.ObterFornecedor(id);
        }

        public void RemoverFornecedor(int id)
        {
            this.fornecedor_repository.RemoveFornecedor(id);
        }
    }
}
