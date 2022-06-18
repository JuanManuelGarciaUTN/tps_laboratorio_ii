using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Parte del proyecto que contiene los temas:
    /// Tema 18 - Delegados y expresion Lambda
    /// Tema 19 - Programacion multi-hilo y concurrencia
    /// Tema 20 - Evento
    /// </summary>
    public class RecordatorioEvent
    {
        //delegado y evento

        public delegate void RecordatorioHandler();
        public event RecordatorioHandler OnTiempoCumplido;

        //metodo

        /// <summary>
        /// Inicia un Task que invocara al metodo asociado al evento OnTiempoCumplido.
        /// Se invocara cada hora, segun los minutos recibidos por parametro
        /// </summary>
        /// <param name="minutos">minutos cuando se desea que se desea el recordatorio</param>
        public void IniciarCadaHora(int minutos)
        {
            if(OnTiempoCumplido is not null)
            {
                Task.Run(() =>
                {
                    while(true)
                    {
                        if(DateTime.Now.Minute == minutos)
                        {
                            OnTiempoCumplido.Invoke();
                            //espera 59 minutos y 50 segundos
                            Thread.Sleep(3590000);
                        }
                    }
                });
            }
        }
    }
}
