using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;

namespace projetoDDD.Application.Services
{
    public class AppPratoService : IPratoService
    {
        private IPratoService _pratoService;
        
        public AppPratoService (IPratoService pratoService)
        {
            _pratoService = pratoService;
        }

        public double PratoComSucoGratis(Prato prato)
        {
            return _pratoService.PratoComSucoGratis(prato);
        }

        public double VerificarEAplicarPromocao(Prato prato)
        {
            return _pratoService.VerificarEAplicarPromocao(prato);
        }
    }
}
