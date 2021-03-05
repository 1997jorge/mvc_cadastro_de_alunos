using Microsoft.EntityFrameworkCore;
using MvcCadastro.Models;

namespace MvcCadastro.Data
{
    public class MvcCadastroContext : DbContext
    {
        public MvcCadastroContext (DbContextOptions<MvcCadastroContext> options)
            : base(options)
        {
        }

        public DbSet<Cadastro> Cadastro { get; set; }
    }
}