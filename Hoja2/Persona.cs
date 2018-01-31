using System.Collections.Generic;

namespace Hoja2
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private List<QueHacer> Tareas;

        public string nombre_
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string apellido_
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        //operaciones

        public bool EstaDisponible()
        {
            int cont = 0;

            //busco las tareas que esten en progreso
            foreach (var item in Tareas)
            {
                //buscar las tareas en la lista que se encuentren en progreso
            }

            if (cont < 1) return true; else return false;
        }


    }
}