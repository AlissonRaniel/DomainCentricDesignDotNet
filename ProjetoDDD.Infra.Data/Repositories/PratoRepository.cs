using ProjetoDDD.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infra.Data.Entity;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class PratoRepository : IPratoRepository
    {
        private BancoDeDados banco = new BancoDeDados();

        public void AdicionarPrato(Prato prato)
        {
            banco.Pratos.Add(prato);
            banco.SaveChanges();
        }

        public void AtualizarPrato(Prato prato)
        {
            banco.Pratos.Add(prato);
            banco.SaveChanges();
        }

        public List<Prato> ObtemTodos()
        {
            return banco.Pratos.ToList();
        }

        public Prato ObterPrato(int id)
        {
            return banco.Pratos.Find(id);
        }

        public void RemoverPrato(int id)
        {
            banco.Pratos.Remove(banco.Pratos.Find(id));
        }
    }
}