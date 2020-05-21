using Microsoft.EntityFrameworkCore;
using Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource= Data\PersonaDB.db");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Persona>().HasData(new Persona
            {
                PersonaID = 1,
                FechaDeNacimiento = DateTime.Now,
                Nombres = "Juan Alberto",
                Telefono = "8292655182",
                Direccion = "Calle Roberto Acevedo #34",
                Cedula = "05600345926"
            });
        }
    }
}
