using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalP3.Data
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }

        public List<Persona> Personas { get; set; } = new List<Persona>();
    }
}
