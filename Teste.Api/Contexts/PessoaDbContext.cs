using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Core.Entities;

namespace Teste.Data.Contexts
{
    public class PessoaDbContext : DbContext
    {
        public PessoaDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
