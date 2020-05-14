

using HelpdeskNeoh.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HelpdeskNeoh.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {

            HasKey(p => p.UsuarioId);

            Property(p => p.NmUsuario)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.EmailUsuario)
                .IsRequired()
                .HasMaxLength(40);

            Property(p => p.CpfUsuario)
                .IsRequired()
                .HasMaxLength(11);

            Property(p => p.CelularUsuario)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.SenhaUsuario)
                .IsRequired()
                .HasMaxLength(11);

            HasRequired(p => p.Hospital)
                .WithMany()
                .HasForeignKey(p => p.HospitalId);

        }


    }
}
