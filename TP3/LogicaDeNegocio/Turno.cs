using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Turno : IComparable<Turno>
    {
        //enum anidados
        public enum TipoConsulta
        {
            Consulta,
            Ortodoncia,
            ImplanteDental,
            Extraccion
        }

        //atributos
        private DateTime fecha;
        private float precio;
        private TipoConsulta tipo;
        private string telefono;
        private string nombre;
        private string apellido;
        private int dniPaciente;

        //constructor
        public Turno(DateTime fecha, float precio, TipoConsulta tipo, int dni, string telefono, string nombre, string apellido)
        {
            if (dni < 10000 || dni > 100000000)
            {
                throw new DatosInvalidosException("DNI invalido, ingrese solo numeros sin espacios ni puntuacion.");
            }
            if (!int.TryParse(telefono, out _))
            {
                throw new DatosInvalidosException("Telefono invalido, ingrese solo numeros sin simbolos especiales o guiones.");
            }
            if (telefono.Length < 8 || telefono.Length > 20)
            {
                throw new DatosInvalidosException("Telefono invalido, cantiad de digitos invalida");
            }
            if (EsUnNombreInvalido(nombre) || EsUnNombreInvalido(apellido))
            {
                throw new DatosInvalidosException("Nombre y apellido debe solo contener letras.");
            }

            this.fecha = fecha;
            this.precio = precio;
            this.tipo = tipo;
            this.dniPaciente = dni;
            this.telefono = telefono;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //propiedades
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    this.fecha = value;
                }
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (precio > 0)
                {
                    this.precio = value;
                }
            }
        }

        public TipoConsulta Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public int DniPaciente
        {
            get
            {
                return this.dniPaciente;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        //metodos estaticos

        /// <summary>
        /// Devuelve una lista con los tipos de consulta
        /// </summary>
        /// <returns></returns>
        public static List<TipoConsulta> ObtenerTipos()
        {
            List<TipoConsulta> tipos = new List<TipoConsulta>();

            for (int i = 0; i < 4; i++)
            {
                tipos.Add((TipoConsulta)i);
            }
            return tipos;
        }

        /// <summary>
        /// Verifica si el string recibido solo tiene caracteres validos
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private static bool EsUnNombreInvalido(string nombre)
        {
            string filtro = " abcdefghijklmnñoprstuvwxyzáéíóú";
            nombre = nombre.ToLower();

            foreach (char letra in nombre)
            {
                if (!filtro.Contains(letra))
                {
                    return true;
                }
            }
            return false;
        }

        //metodos

        /// <summary>
        /// Implementacion de IComparable para poder ordenar una lista de turnos
        /// Se Ordenan segun su fecha y en orden ascendente
        /// </summary>
        /// <param name="turnoAComparar"></param>
        /// <returns></returns>
        public int CompareTo(Turno turnoAComparar)
        {
            if(this.Fecha > turnoAComparar.Fecha)
            {
                return 1;
            }
            if(this.Fecha == turnoAComparar.Fecha)
            {
                return 0;
            }
            return -1;
        }

        /// <summary>
        /// Genera un string con los datos del turno
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {FormatearFecha()}");
            sb.AppendLine($"Tipo de Consulta: {this.tipo}");
            sb.AppendLine($"Precio: {this.Precio}");
            sb.AppendLine($"Nombre: {this.nombre} {this.apellido}");
            sb.AppendLine($"DNI: {this.DniPaciente}");
            sb.AppendLine($"Telefono: {this.telefono}");

            return sb.ToString();
        }

        /// <summary>
        /// Formatea una fecha para que siga el formato
        /// Dia/Mes/Año Hora:Minutos
        /// </summary>
        /// <returns></returns>
        private string FormatearFecha()
        {
            string hora = this.fecha.Hour.ToString();
            string minutos = this.fecha.Minute.ToString();
            if (this.fecha.Minute < 10)
            {
                minutos = $"0{this.fecha.Minute}";
            }
            return $"{this.fecha.Day}/{this.fecha.Month}/{this.fecha.Year} {hora}:{minutos}";
        }

        //sobrescritura metodos

        /// <summary>
        /// Sobrescribe el metodo ToString() para que muestre en una linea
        /// Hora del Turno | Nombre | DNI | Telefono
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int hora = this.Fecha.Hour;
            string minutos = this.Fecha.Minute.ToString();
            string nombreCompleto = $"{this.nombre} {this.apellido}";

            if(this.Fecha.Minute < 10)
            {
                minutos = $"0{this.Fecha.Minute}";
            }

            return $"{hora}:{minutos} {this.Tipo} | {nombreCompleto} | DNI: {this.DniPaciente} | Tel: {this.Telefono}";
        }

        //sobrecagar operadores

        /// <summary>
        /// Dos turnos son iguales si su DateTime es el mismo
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Turno t1, Turno t2)
        {
            try
            {
                return t1.Fecha == t2.Fecha;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static bool operator !=(Turno t1, Turno t2)
        {
            return !(t1 == t2);
        }

        /// <summary>
        /// Verifica si el DateTime de un turno coincide con
        /// algun DateTime de todos los turnos de una lista de turnos.
        /// </summary>
        /// <param name="turno"></param>
        /// <param name="listaTurnos"></param>
        /// <returns></returns>
        public static bool operator ==(Turno turno, List<Turno> listaTurnos)
        {
            try
            {
                foreach(Turno item in listaTurnos)
                {
                    if(item == turno)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static bool operator !=(Turno turno, List<Turno> listaTurnos)
        {
            return !(turno == listaTurnos);
        }
    }
}
