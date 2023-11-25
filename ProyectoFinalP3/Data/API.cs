using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

//Consumiendo el API
namespace ProyectoFinalP3.Data
{
    public class Api
    {
        private string url = "https://api.adamix.net/apec/cedula/";

        public Persona Consulta(string cedula)
        {
            Persona persona = new Persona();

            try
            {
                url += cedula;

                var str = new WebClient().DownloadString(url);
                dynamic d = JsonConvert.DeserializeObject<dynamic>(str);

                persona.Cedula = cedula;
                persona.Nombre = d.Nombres;
                persona.Apellido = d.Apellido1 + " " + d.Apellido1;

                if (persona.Nombre == null)
                {
                    persona.Nombre = "No encontrado";
                    persona.Apellido = "No encontrado";
                }
            }
            catch (Exception)
            {

                throw;
            }

            return persona;
        }

    }
}
