using IntroducaoCoreLogin.Data;
using IntroducaoCoreLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoCoreLogin.Services
{
    public class PaisRepositorioEF : IPaisRepositorio
    {
        public ApplicationDbContext DB { get; }

        public PaisRepositorioEF(ApplicationDbContext db)
        {
            DB = db;
        }

        public List<Pais> Obter()
        {
            return DB.Paises.ToList();
        }
    }
}
