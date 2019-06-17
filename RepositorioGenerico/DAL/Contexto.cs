using RepositorioGenerico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGenerico.DAL
{
    class Contexto : DbContext
    {

        public DbSet<Ciudades>Ciudad { get; set; }
        public Contexto() : base("Constr")
        {

        }
    }
}
