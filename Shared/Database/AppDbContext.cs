using Microsoft.EntityFrameworkCore;
using ControleGastosResidenciais.Shared.Database.Entities;

namespace ControleGastosResidenciais.Shared.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<PessoaEntity> Pessoas => Set<PessoaEntity>();
}
