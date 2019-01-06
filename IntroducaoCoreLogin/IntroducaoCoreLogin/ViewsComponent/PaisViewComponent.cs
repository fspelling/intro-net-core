using IntroducaoCoreLogin.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoCoreLogin.ViewsComponent
{
    public class PaisViewComponent : ViewComponent
    {
        public IPaisRepositorio Rep { get; }

        public PaisViewComponent(IPaisRepositorio rep)
        {
            Rep = rep;
        }

        public IViewComponentResult Invoke()
        {
            return View(Rep.Obter());
        }
    }
}
