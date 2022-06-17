using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Parte del proyecto que contine los temas:
    /// Tema 12 - Tipos Genericos
    /// Tema 13 - Interfaces
    /// </summary>
    /// <typeparam name="T">El tipo del cual se desea crear un DTO</typeparam>
    internal interface IDataTransferObject<T>
        where T : class
    {
        public T GenerarObjeto();
        public void ConvertirADTO(T objeto);
    }
}
