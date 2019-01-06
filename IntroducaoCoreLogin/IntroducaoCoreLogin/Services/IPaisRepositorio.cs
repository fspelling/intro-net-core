using IntroducaoCoreLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoCoreLogin.Services
{
    public interface IPaisRepositorio
    {
        List<Pais> Obter();
    }
}
