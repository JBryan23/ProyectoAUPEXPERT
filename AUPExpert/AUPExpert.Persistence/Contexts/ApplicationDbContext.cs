
using AUPExpert.Domain.Entities;
using AUPExpert.Persistence.Configurations;
using AUPExpert.Persistence.Contexts.Configurations;
using Microsoft.EntityFrameworkCore;
namespace AUPExpert.Persistence.Contexts;

internal sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<WorkFlow> WorkFlows { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Iteration> Iterations { get; set; }
    public DbSet<WorkFlowTask> WorkFlowTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WorkFlowConfiguration());
        modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        modelBuilder.ApplyConfiguration(new IterationConfiguration());
        modelBuilder.ApplyConfiguration(new WorkFlowTaskConfiguration());

        base.OnModelCreating(modelBuilder);
    }

}
