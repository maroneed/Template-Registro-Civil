using Microsoft.EntityFrameworkCore;
using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RC.MS_Divorcio.AccessData
{
    public class MS_DivorcioDbContext : DbContext
    {
        public MS_DivorcioDbContext(DbContextOptions<MS_DivorcioDbContext>options
            ): base(options)
        {
            
        }

        public DbSet<DomicilioConvivencia> DomicilioConvivencia { get; set; }
        public DbSet<Propuesta> Propuestas { get; set; }
        public DbSet<SolicitudTipo> SolicitudTipos { get; set; }
        public DbSet<TramiteDivorcio> TramiteDivorcios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            

            //DomicilioConvivencia

            modelBuilder.Entity<DomicilioConvivencia>().Property(t => t.Id).ValueGeneratedOnAdd();
            
            modelBuilder.Entity<DomicilioConvivencia>().Property(t => t.numero).HasMaxLength(45).IsRequired(); 
            modelBuilder.Entity<DomicilioConvivencia>().Property(t => t.calle).HasMaxLength(45).IsRequired(); 

            


            //propuesta

            modelBuilder.Entity<Propuesta>().Property(v => v.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Propuesta>().Property(t => t.descripcion).HasMaxLength(250).IsRequired(); 

            //solicitudTipo

            modelBuilder.Entity<SolicitudTipo>().Property(v => v.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<SolicitudTipo>().Property(t => t.descripcion).HasMaxLength(20).IsRequired(); 
            modelBuilder.Entity<SolicitudTipo>().Property(t => t.valor).HasColumnType("decimal(15,2)").IsRequired();

            //tramiteDivorcio

            modelBuilder.Entity<TramiteDivorcio>().Property(v => v.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<TramiteDivorcio>().HasIndex(v => v.actaMatrimonioId).IsUnique();
            modelBuilder.Entity<TramiteDivorcio>().HasIndex(v => v.propuestaId).IsUnique();
           
            modelBuilder.Entity<TramiteDivorcio>().Property(v => v.actaMatrimonioId).IsRequired();
            modelBuilder.Entity<TramiteDivorcio>().Property(v => v.propuestaId).IsRequired();
            modelBuilder.Entity<TramiteDivorcio>().Property(v => v.solicitudTipoId).IsRequired();

            modelBuilder.Entity<TramiteDivorcio>().Property(v => v.personaId1).IsRequired();
            modelBuilder.Entity<TramiteDivorcio>().Property(v => v.personaId2).IsRequired();
            modelBuilder.Entity<TramiteDivorcio>().Property(v => v.domicilioConyugalId).IsRequired();








        }
    }
}
