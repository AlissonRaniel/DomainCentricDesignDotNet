using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.Service
{
    public interface IPratoService
    {
        double VerificarEAplicarPromocao(Prato prato);
        double PratoComSucoGratis(Prato prato);
    }
}
