﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Acciones : IAcciones
    {
        Alumno a = new Alumno();
        private List<Alumno> listaalumnos = new List<Alumno>()
        {
            new Alumno("Yy", 21, 113069),
            new Alumno("Sofia", 19, 112315)
        };

        public void Actualizar(int matriculaActual, string Nuevonombre, int Nuevaedad, int Nuevamatricula)
        {
            var actualizar = listaalumnos.FirstOrDefault(x => x.Matricula == matriculaActual);

            if (actualizar != null)
            {
                actualizar.Nombre = Nuevonombre;
                actualizar.Edad = Nuevaedad;
                actualizar.Matricula = Nuevamatricula;
                Console.WriteLine("Alumno se ha  actualizado correctamente");
            }
            else
            {
                Console.WriteLine("No se ha encontrado esa matrícula...");
            }
        }


        public void Agregar(int matricula, string nombre, int edad)
        {

            listaalumnos.Add(new Alumno(a.Nombre = nombre, a.Edad = edad, a.Matricula = matricula));
        }

        public List<Alumno> Consultar()
        {
            return listaalumnos;

        }

        public void Eliminar(int matricula)
        {
            var objetoeliminar = listaalumnos.FirstOrDefault(x => x.Matricula == matricula);
            if (objetoeliminar != null)
            {
                listaalumnos.Remove(objetoeliminar);
            }
            else
            {
                Console.WriteLine("No existe esa matricula");
            }
        }

        public void ExportarExcel()
        {
            throw new NotImplementedException();
        }
    }
}
