using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace projetoDDD.Application.Interfaces
{
    public interface IAppFornecedorService 
    {
        void AdicionarFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
        void AtualizarFornecedor(Fornecedor forncedor);
        void RemoverForncedor(int id);
    }
}