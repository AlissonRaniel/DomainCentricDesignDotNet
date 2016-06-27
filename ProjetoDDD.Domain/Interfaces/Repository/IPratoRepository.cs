using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repository
{
    public interface IPratoRepository
    {
        void AdicionarPrato(Prato prato);
        Prato ObterPrato(int id);
        List<Prato> ObtemTodos();
        void AtualizarPrato(Prato prato);
        void RemoverPrato(int id);
    }
}