using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Conectar_Tablas.Models;

    public class ConectarTablasContext : DbContext
    {
        public ConectarTablasContext (DbContextOptions<ConectarTablasContext> options)
            : base(options)
        {
        }

        public DbSet<Conectar_Tablas.Models.Persona> Persona { get; set; }
        public DbSet<Conectar_Tablas.Models.Dni> Dni { get; set; }
    }
