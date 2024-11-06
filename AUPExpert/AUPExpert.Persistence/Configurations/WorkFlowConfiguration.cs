using AUPExpert.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUPExpert.Persistence.Contexts.Configurations
{
    internal sealed class WorkFlowConfiguration : IEntityTypeConfiguration<WorkFlow>
    {
        public void Configure(EntityTypeBuilder<WorkFlow> entity)
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.HasIndex(e => e.ProjectId, "ProyectoId");

            entity.ToTable("Tbl_FlujoTrabajo");

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
                .HasMaxLength(50)
                .HasColumnName("Nombre");

            entity.Property(e => e.ProjectId)
                .IsRequired()
                .HasColumnType("int(11)")
                .HasColumnName("ProyectoId");

            entity.HasOne(e => e.Project).WithMany()
                .HasForeignKey(e => e.ProjectId)
                .HasConstraintName("project_workflow_fk");

        }
    }
}
