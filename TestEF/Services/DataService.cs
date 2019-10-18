using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestEF.Models;

namespace TestEF.Services
{
    public interface IDataService
    {
        IList<Persona> GetAll();
    }

    public class DataService : IDataService
    {
        public IList<Persona> GetAll()
        {
            //Get data...
            var persona1 = new Persona
            {
                ID = 1,
                Nombre = "Rob",
                Edad = 40
            };
            var persona2 = new Persona
            {
                ID = 2,
                Nombre = "Mau",
                Edad = 38
            };
            var persona3 = new Persona
            {
                ID = 3,
                Nombre = "Seb",
                Edad = 39
            };
            List<Persona> listaPersonas = new List<Persona>
            {
                persona1,
                persona2,
                persona3
            };
            return listaPersonas;
        }
    }
}
