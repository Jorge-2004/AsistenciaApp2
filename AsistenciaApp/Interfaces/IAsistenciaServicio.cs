using AsistenciaApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaApp.Interfaces
{
    public interface IAsistenciaServicio
    {
        void AddRecord(Empleados emp);
        void UpdateRecord(int id, Empleados updatedEmp);
        void DeleteRecord(int id);
        List<Empleados> GetRecords();
    }
}
