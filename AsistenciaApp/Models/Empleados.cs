using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaApp.models
{
    public class Empleados
    {
        private static int _idCounter = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }
        public bool Late { get; set; }
        public string DNI { get; set; }
        public string Area { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }

        public Empleados(string name, DateTime date, bool present, bool late,
                        string dni, string area, string position, string email, string observaciones)
        {
            Id = _idCounter++;
            Name = name;
            Date = date;
            Present = present;
            Late = late;
            DNI = dni;
            Area = area;
            Position = position;
            Email = email;
        }


        // Para permitir modificar Id (al modificar registro)
        public Empleados() { }
    }
}
