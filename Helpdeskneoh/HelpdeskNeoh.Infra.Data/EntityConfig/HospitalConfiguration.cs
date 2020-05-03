using HelpdeskNeoh.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HelpdeskNeoh.Infra.Data.EntityConfig
{
    public class HospitalConfiguration : EntityTypeConfiguration<Hospital>
    {

        public HospitalConfiguration()
        {
            HasKey(h => h.HospitalId);

            Property(h => h.CnpjHospital)
                .IsRequired()
                .HasMaxLength(14);

            Property(h => h.NmHospital)
                .IsRequired()
                .HasMaxLength(100);


        }

    }
}
