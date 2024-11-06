using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUPExpert.Persistence.Contexts.Configurations
{
    internal sealed class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> entity)
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Tbl_Proyectos");

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("int(11)")
                .HasColumnName("Id");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nombre");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("Descripcion");

            entity.Property(e => e.StartDate)
                .IsRequired()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("FechaInicio");

            entity.Property(e => e.EndDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("FechaFinal");

            entity.Property(e => e.State)
                .IsRequired()
                .HasColumnType("enum('PENDIENTE','FINALIZADO')")
                .HasColumnName("Estado")
                .HasDefaultValue(ProjectState.PENDIENTE);

            entity.Property(e => e.InitialPhaseCompleted)
                .IsRequired()
                .HasColumnType("bit(1)")
                .HasColumnName("FaseInicialCompletada");

            entity.Property(e => e.ElaborationPhaseCompleted)
                .IsRequired()
                .HasColumnType("bit(1)")
                .HasColumnName("FaseElaboracionCompletada");

            entity.Property(e => e.ConstructionPhaseCompleted)
                .IsRequired()
                .HasColumnType("bit(1)")
                .HasColumnName("FaseConstruccionCompletada");

            entity.Property(e => e.TransitionPhaseCompleted)
                .IsRequired()
                .HasColumnType("bit(1)")
                .HasColumnName("FaseTransitionCompletada");
        }
    }
}
