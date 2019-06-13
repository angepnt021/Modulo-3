using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conectar_Tablas.Models
{
    public class Dni
    {
        public int Id { get; set; }
        public string Identificador { get; set; }
        public DateTime FechaExpiracion{ get; set; }
        public DateTime FechaCreacion { get; set; }

        public int  PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
