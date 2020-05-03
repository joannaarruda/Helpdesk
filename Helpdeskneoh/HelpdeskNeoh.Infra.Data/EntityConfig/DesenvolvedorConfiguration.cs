using HelpdeskNeoh.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HelpdeskNeoh.Infra.Data.EntityConfig
{
    public class DesenvolvedorConfiguration : EntityTypeConfiguration<Desenvolvedor>
    {
        public DesenvolvedorConfiguration()
        {
            HasKey(d => d.DesenvolvedorId);

            Property(d => d.NmDesenvolvedor)
                .IsRequired()
                .HasMaxLength(250);

            Property(d => d.EmailDesenvolvedor)
                .IsRequired()
                .HasMaxLength(100);

            Property(d => d.CpfDesenvolvedor)
                .IsRequired()
                .HasMaxLength(11);

        }

    }
}
