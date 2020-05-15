

using HelpdeskNeoh.Domain.Entities;
using HelpdeskNeoh.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace HelpdeskNeoh.Infra.Data.Contexto
{
    public class HelpdeskNeohContext : DbContext

    {

        public HelpdeskNeohContext()
            : base("HelpdeskNeoh")
        {

        }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet <Hospital> Hospitais { get; set; }
        public DbSet <Usuario> Usuarios { get; set; }
        public DbSet<PedidoSuporte> PedidoSuportes { get; set; }
        public DbSet <AtenderPedido> AtenderPedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new DesenvolvedorConfiguration());
            modelBuilder.Configurations.Add(new HospitalConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new PedidoSuporteConfiguration());
            modelBuilder.Configurations.Add(new AtenderPedidoConfiguration());


        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(Entry => Entry.Entity.GetType().GetProperty("DataCadastro") is null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }

            }
            return base.SaveChanges();

        }



    }
}
