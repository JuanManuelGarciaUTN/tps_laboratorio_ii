using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LogicaDeNegocio
{
    public class RecordatorioEvent
    {
        //delegado y evento
        public delegate void RecordatorioHandler();
        public event RecordatorioHandler OnTiempoCumplido;

        //metodos
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
