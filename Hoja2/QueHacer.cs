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
        private int Estado;
        private bool Utiles;

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

        public int Estado_
        {
            get
            {
                if (this.Estado > 0 || this.Estado < 1)
                    throw new System.Exception("El estado que esta ingresado no es valido");
                else
                    return this.Estado;
            }
            set { this.Estado = value; }
        }
        public bool Utiles_
        {
            get { return this.Utiles; }
            set { this.Utiles = value; }
        }

        //cosntructor padre
        public QueHacer() { }

        //metodos 

        public void setEstado(Estados estados,int estado)
        {
            switch (estados)
            {
                case Estados.Terminda:
                    this.Estado = estado;
                    System.Console.WriteLine("La tarea esta terminada");
                    break;
                case Estados.enProgreso:
                    this.Estado = estado;
                    System.Console.WriteLine("La tarea esta en progreso");
                    break;
                default:
                    break;
            }
        }

    }
}