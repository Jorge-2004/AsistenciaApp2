using AsistenciaApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AsistenciaApp.Interfaces
{
    public interface IGeneradorReporte
    {
        void GenerateReport(List<Empleados> data, string filePath);
    }
}
