using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Parte del proyecto que contiene el tema:
    /// Tema 10 - Excepciones
    /// </summary>
    public class DatosInvalidosException : Exception
    {
        public DatosInvalidosException()
        {
        }

        public DatosInvalidosException(string message)
            : base(message)
        {
        }

        public DatosInvalidosException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        protected DatosInvalidosException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
