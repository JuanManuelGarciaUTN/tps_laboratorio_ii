using System;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Parte del proyecto que contine los temas:
    /// Tema 12 - Usar Tipos Genericos
    /// Tema 13 - Implementacion de Interfaces
    /// </summary>
    public class TurnoDTO : IDataTransferObject<Turno>
    {
        //Implementacion de un DataTransferObject para la clase Turno
        //De manera que uno pueda serializar un Turno sin que se pierda el encapsulamiento

        //atributos
        private DateTime fecha;
        private float precio;
        private Turno.TipoConsulta tipo;
        private string telefono;
        private string nombre;
        private string apellido;
        private int dniPaciente;
        private bool fueAtendido;

        //constructor
        public TurnoDTO()
        {
        }

        //propiedades
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Turno.TipoConsulta Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int DniPaciente
        {
            get { return dniPaciente; }
            set { dniPaciente = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public bool FueAtendido
        {
            get { return fueAtendido; }
            set { fueAtendido = value; }
        }


        //metodos

        /// <summary>
        /// Genera un nuevo objeto de tipo Turno segun los atributos de TurnoDTO
        /// </summary>
        /// <returns></returns>
        public Turno GenerarObjeto()
        {
            try
            {
                Turno turno = new Turno(this.Fecha, this.Precio, this.Tipo, this.DniPaciente, this.Telefono, this.Nombre, this.Apellido, this.FueAtendido);
                return turno;
            }
            catch(DatosInvalidosException)
            {
                throw;
            }
        }

        /// <summary>
        /// Asigna los atributos de un turno al TurnoDTO
        /// </summary>
        /// <param name="turno"></param>
        public void ConvertirADTO(Turno turno)
        {
            this.Fecha = turno.Fecha;
            this.Precio = turno.Precio;
            this.Tipo = turno.Tipo;
            this.DniPaciente = turno.DniPaciente;
            this.Telefono = turno.Telefono;
            this.Nombre = turno.Nombre; 
            this.Apellido = turno.Apellido;
            this.FueAtendido = turno.FueAtendido;
        }
    }
}
