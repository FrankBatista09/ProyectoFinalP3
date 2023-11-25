using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalP3.Data
{
    public class Context :DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseSqlite("DataSource=Datos.db");
        
    }
}
