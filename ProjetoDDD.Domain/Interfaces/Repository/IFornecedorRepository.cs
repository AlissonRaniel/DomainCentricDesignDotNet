using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repository
{
    public interface IFornecedorRepository
    {
        void AdicionarFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
        void AtualizarFornecedor(Fornecedor fornecedor);
        void RemoverFornecedor(int id);
    }
}