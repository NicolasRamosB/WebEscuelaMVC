using Microsoft.EntityFrameworkCore;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Data
{
    public class EscuelaDBMVC : DbContext
    {
        public EscuelaDBMVC(DbContextOptions<EscuelaDBMVC> options) : base(options)
        {
        }
        public DbSet<Aula> Aulas { get; set; }
    }
}
