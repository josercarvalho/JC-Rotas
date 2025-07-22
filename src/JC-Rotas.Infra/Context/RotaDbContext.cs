using Microsoft.EntityFrameworkCore;
using JC_Rotas.Domain.Entities;
using JC_Rotas.Infra.Mappings;

namespace JC_Rotas.Infra.Context;

public class RotaDbContext : DbContext
{
    public RotaDbContext(DbContextOptions<RotaDbContext> options) : base(options) { }

    public DbSet<Rota> Rotas => Set<Rota>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Rota>(new RotaMap().Configure);
    }
}

