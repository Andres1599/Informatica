using System.Collections.Generic;

namespace Hoja2
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public QueHaceres Tareas;

        public string nombre_ { get; set; }
        public string apellido_ { get; set; }
        public QueHaceres tareas_ { get; set; }
        //operaciones
        public Persona() {
        }

        public bool EstaDisponible()
        {
            if (Tareas.EstaDisponible())
            {
                return true;
            }
            return false;
        }

        public void AgregarTarea(QueHacer QueHacer)
        {
            Tareas.AgregarTarea(QueHacer);
        }

        public void CompletarQueHacer()
        {
            Tareas.CompletarTarea();
        }

    }
}