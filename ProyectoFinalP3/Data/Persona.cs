using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalP3.Data
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Lugar { get; set; }

        public int? VehiculoId { get; set; }

    }
}
