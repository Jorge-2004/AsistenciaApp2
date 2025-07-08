using AsistenciaApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using AsistenciaApp.Interfaces;


namespace AsistenciaApp.Reports
{
    public class TextGeneradorReporte : IGeneradorReporte
    {
        public void GenerateReport(List<Empleados> data, string filePath)
        {
            using StreamWriter writer = new(filePath);
            foreach (var emp in data)
            {
                writer.WriteLine($"Nombre: {emp.Name}, DNI: {emp.DNI}, Fecha: {emp.Date.ToShortDateString()}, Presente: {emp.Present}, Área: {emp.Area}, Cargo: {emp.Position}, Correo: {emp.Email}");
            }
        }
    }
}
