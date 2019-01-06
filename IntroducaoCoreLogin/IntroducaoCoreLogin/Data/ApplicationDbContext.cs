using System;
using System.Collections.Generic;
using System.Text;
using IntroducaoCoreLogin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IntroducaoCoreLogin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Pais> Paises { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
