using AsistenciaApp.Interfaces;
using AsistenciaApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AsistenciaApp.Services
{
    public class AsistenciaServicio : IAsistenciaServicio
    {
        private List<Empleados> employees = new List<Empleados>();

        public void AddRecord(Empleados emp)
        {
            employees.Add(emp);
        }

        public void UpdateRecord(int id, Empleados updatedEmp)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                emp.Name = updatedEmp.Name;
                emp.Date = updatedEmp.Date;
                emp.Present = updatedEmp.Present;
                emp.Late = updatedEmp.Late;
                emp.DNI = updatedEmp.DNI;
                emp.Area = updatedEmp.Area;
                emp.Position = updatedEmp.Position;
                emp.Email = updatedEmp.Email;
            }
        }

        public void DeleteRecord(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
                employees.Remove(emp);
        }

        public List<Empleados> GetRecords()
        {
            return employees.ToList();
        }
    }
}
