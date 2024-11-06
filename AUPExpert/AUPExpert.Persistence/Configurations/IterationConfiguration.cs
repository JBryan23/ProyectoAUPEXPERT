using AUPExpert.Domain.Entities;
using AUPExpert.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUPExpert.Persistence.Configurations
{
    internal sealed class IterationConfiguration : IEntityTypeConfiguration<Iteration>
    {
        public void Configure(EntityTypeBuilder<Iteration> entity)
        {
            entity.ToTable("Tbl_Iteraciones");

            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.HasIndex(e => e.ProjectId, "IdProyecto");

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("int(11)")
                .HasColumnName("Id");

            entity.Property(e => e.EndDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("FechaFinal");

            entity.Property(e => e.StartDate)
                .IsRequired()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("FechaInicio");

            entity.Property(e => e.ProjectId)
                .IsRequired()
                .HasColumnType("int(11)")
                .HasColumnName("ProyectoId");

            entity.Property(e => e.Phase)
                .IsRequired()
                .HasColumnType("enum('INICIO','ELABORACION','CONSTRUCCION','TRANSICION')")
                .HasColumnName("Fase");

            entity.Property(e => e.State)
                .IsRequired()
                .HasColumnType("enum('PENDIENTE','FINALIZADO')")
                .HasColumnName("Estado")
                .HasDefaultValue(IterationState.PENDIENTE);

            entity.Property(e => e.Objective)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("Objetivo");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Codigo");

            entity.HasOne(d => d.Project).WithMany()
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("project_iteration_fk");
        }
    }
}
