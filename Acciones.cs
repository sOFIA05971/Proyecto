using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Acciones : IAcciones
    {

        private List<Alumno> listalumnos = new List<Alumno>()
        { new Alumno("Sofia",19,113117),
        new Alumno("KK",22,116112)};

        public List<Alumno> Consular()
        { 
            return listalumnos;
        }
        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> Consultar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int matricula)
        {
            throw new NotImplementedException();
        }

        public void ExportarExcel()
        {
            throw new NotImplementedException();
        }
    }
}
