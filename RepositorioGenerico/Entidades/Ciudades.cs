using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioGenerico.Entidades
{
    class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string Descripcion { get; set; }

        public Ciudades()
        {
            CiudadId = 0;
            Descripcion = string.Empty;
        }

    }
}
