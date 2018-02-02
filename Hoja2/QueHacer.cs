namespace Hoja2
{
    public enum Estados
    {
        enProgreso = 0,
        Terminda = 1
    }

    public class QueHacer
    {
        //propiedades
        public int CodigoQueHacer;
        public string Descripcion;
        public Estados Estado {get; private set;}
        public bool Utiles;
        public string ListadoUtiles;

        //metodos getter y setters
        public int CodigoQueHacer_
        {
            get { return CodigoQueHacer; }
            set { this.CodigoQueHacer = value; }
        }

        public string Descripcion_
        {
            get { return this.Descripcion; }
            set { this.Descripcion = value; }
        }

        public bool Utiles_
        {
            get { return this.Utiles; }
            set { this.Utiles = value; }
        }

        public string ListadoUtiles_
        {
            get { return this.ListadoUtiles; }
        }
        //cosntructor por defecto
        public QueHacer() { this.Estado = Estados.enProgreso; }
        //metodos 

        public void Completar()
        {
            this.Estado = Estados.Terminda;
        }

        public string checkUtiles(bool util, string ListadoUtiles_)
        {
            if (util)
            {
                this.ListadoUtiles = ListadoUtiles_;
                return this.ListadoUtiles;
            }
            else
            {
                this.ListadoUtiles = "No hay utencilios disponibles en la tarea";
            }
            return "No hay utencilios disponibles en la tarea";
        }
    }
}