using AUPExpert.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUPExpert.Persistence.Contexts.Configurations
{
    internal sealed class WorkFlowTaskConfiguration : IEntityTypeConfiguration<WorkFlowTask>
    {
        public void Configure(EntityTypeBuilder<WorkFlowTask> entity)
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.ToTable("Tbl_Tareas");

            entity.HasIndex(e => e.WorkFlowId, "FlujoTrabajoId");
            entity.HasIndex(e => e.IterationId, "IteracionId");

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnType("int(11)")
                .HasColumnName("Id");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("Descripcion");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(75)
                .HasColumnName("Nombre");

            entity.Property(e => e.Priority)
                .IsRequired()
                .HasColumnType("enum('BAJA','MEDIA','ALTA')")
                .HasColumnName("Prioridad");

            entity.Property(e => e.State)
                .IsRequired()
                .HasColumnType("enum('PENDIENTE','INICIADA','FINALIZADA')")
                .HasColumnName("Estado");

            entity.Property(e => e.WorkFlowId)
                .IsRequired()
                .HasColumnType("int(11)")
                .HasColumnName("FlujoTrabajoId");

            entity.Property(e => e.IterationId)
                .IsRequired()
                .HasColumnType("int(11)")
                .HasColumnName("IteracionId");

            entity.HasOne(d => d.WorkFlow).WithMany()
                .HasForeignKey(d => d.WorkFlowId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("flujoTrabajo_tarea_fk");

            entity.HasOne(d => d.Iteration).WithMany()
                .HasForeignKey(d => d.IterationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("iteracion_tarea_fk");
        }
    }
}
