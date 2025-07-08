using AsistenciaApp.Interfaces;
using AsistenciaApp.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaApp.Reports
{
    public class CsvGeneradorReporte : IGeneradorReporte
    {
        public void GenerateReport(List<Empleados> data, string filePath)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Nombre,DNI,Fecha,Presente,Área,Cargo,Correo");

            foreach (var emp in data)
            {
                sb.AppendLine($"{emp.Name},{emp.DNI},{emp.Date.ToShortDateString()},{emp.Present},{emp.Area},{emp.Position},{emp.Email}");
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
