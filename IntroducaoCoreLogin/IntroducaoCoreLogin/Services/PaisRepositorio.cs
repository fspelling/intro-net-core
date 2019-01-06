using IntroducaoCoreLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoCoreLogin.Services
{
    public class PaisRepositorio : IPaisRepositorio
    {
        public List<Pais> Obter()
        {
            return new List<Pais>() { new Pais("Brasil") };
        }
    }
}
