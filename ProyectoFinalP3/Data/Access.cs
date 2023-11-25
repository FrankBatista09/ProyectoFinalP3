using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalP3.Data
{
    public class Access
    {
        //Leer Vehiculos
        public async Task<List<Vehiculo>> GetVehiculosAsync()
        {

            try
            {
                using (var db = new Context())
                {
                    return await db.Vehiculos.ToListAsync();
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        //Insertar Vehiculos
        public async Task InsertarVehiculosAsync(Vehiculo v)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Vehiculos.Add(v);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Leer Personas
        public async Task<List<Persona>> GetPersonaAsync()
        {

            try
            {
                using (var db = new Context())
                {
                    return await db.Personas.ToListAsync();
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        //Insertar Personas
        public async Task InsertarPersonasAsync(Persona p)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Personas.Add(p);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
