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
        private int CodigoQueHacer;
        private string Descripcion;
        private Estados Estado;
        private bool Utiles;
        private string ListadoUtiles;

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
        public QueHacer()
        {
            this.CodigoQueHacer = 0;
            this.Descripcion = "";
            this.Estado = Estados.enProgreso;
            this.Utiles = false;
            this.ListadoUtiles = "";
        }

        //constructor personalizado
        public QueHacer(int cod,string descrip,Estados estados,bool utiles,string lista){
            this.CodigoQueHacer = cod;
            this.Descripcion = descrip;
            this.Estado = estados;
            this.Utiles = utiles;
            this.ListadoUtiles = lista;
        }

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