using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testeContSelf.Models;

namespace testeContSelf.Data
{
    public class testeContSelfContext : DbContext
    {
        public testeContSelfContext (DbContextOptions<testeContSelfContext> options)
            : base(options)
        {
        }

        public DbSet<testeContSelf.Models.Funcionario> Funcionario { get; set; }
    }
}
