using System.Collections.Generic;

namespace Hoja2

{
    public class QueHaceres
    {
        public List<QueHacer> Lista {get; set;}

        public QueHaceres() {
            Lista = new List<QueHacer>();
        }

        public void AgregarTarea(QueHacer QueHacer){
            Lista.Add(QueHacer);
        }

        public void CompletarTarea(){
            for (int i = 0; i < Lista.Count; i++)
            {
                if(Lista[i].Estado == Estados.enProgreso){
                    Lista[i].Completar();
                    break;
                }
            }
        }

        public bool EstaDisponible(){
            for (int i = 0; i < Lista.Count; i++)
            {
                if(Lista[i].Estado == Estados.enProgreso){
                    return false;
                }
            }
            return true;
        }

    }
}