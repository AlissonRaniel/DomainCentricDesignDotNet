using ProjetoDDD.Domain.Interfaces.Service;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using projetoDDD.Application.Interfaces;

namespace projetoDDD.Application.Services
{
    public class AppFornecedorService : IAppFornecedorService
    {
        private IFornecedorService fornecedor_service;

        public AppFornecedorService(IFornecedorService service)
        {
            this.fornecedor_service = service;
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            this.fornecedor_service.AdicionaFornecedor(fornecedor);
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            this.fornecedor_service.AtualizaFornecedor(fornecedor);
        }

        public List<Fornecedor> ObtemTodos()
        {
            return this.fornecedor_service.ObtemTodos();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return fornecedor_service.ObterFornecedor(id);
        }

        public void RemoverForncedor(int id)
        {
            this.fornecedor_service.RemoveFornecedor(id);
        }
    }
}
