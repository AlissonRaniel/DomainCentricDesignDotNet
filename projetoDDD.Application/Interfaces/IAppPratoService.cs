using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace projetoDDD.Application.Interfaces
{
    public interface IAppPratoService
    {
        void AdicionarPrato(Prato prato);
        Prato ObterPrato(int id);
        List<Prato> ObtemTodos();
        void AtualizarPrato(Prato prato);
        void RemoverPrato(int id);
    }
}