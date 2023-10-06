using Locadora.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora.Data;
public class LocadoraDbContext : DbContext
{
    public DbSet<Endereco>? Endereco { get; set; }
    public DbSet<Avaliacao>? Avaliacao { get; set; }
    public DbSet<AssinaturaPlano>? Assinaturas { get; set; }
    public DbSet<Fornecedor>? Fornecedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=locadora.db;Cache=Shared");
    }
}