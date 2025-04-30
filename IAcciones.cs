using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal interface IAcciones
    {
        List<Alumno> Consultar();

        void Agregar(int matricula, string nombre, int edad);

        void Eliminar(int matricula);

        void Actualizar(int matricula, string nombre, int edad);

        void ExportarExcel();
    }
}
