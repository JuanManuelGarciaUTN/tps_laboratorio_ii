using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace LogicaDeNegocio
{
    /// <summary>
    /// Parte del proyecto que contiene los temas:
    /// Tema 14 - Archivos
    /// Tema 15 - Serializacion
    /// </summary>
    public class ManejadorDeTurnos
    {
        //atributos
        private List<Turno> turnos;
        private string pathTurnos;
        private string pathPrecios;
        private List<float> precios;

        //constructor
        public ManejadorDeTurnos(string pathTurnos, string pathPrecios)
        {
            turnos = new List<Turno>();
            this.pathTurnos = pathTurnos;
            this.pathPrecios = pathPrecios;
            ObtenerPrecios();
            ObtenerTurnos();
        }

        //propiedades
        public List<float> Precios
        {
            get { return precios; }
        }

        //metodos

        /// <summary>
        /// Recibe un indice de la lista de precios y un precio nuevo como string
        /// Si el precio es un numero positivo lo asigna
        /// Si no lanza DatosInvalidosException
        /// </summary>
        /// <param name="precioSeleccionado"></param>
        /// <param name="precioString"></param>
        /// <exception cref="DatosInvalidosException"></exception>
        public void ModificarPrecio(int precioSeleccionado, string precioString)
        {
            float precio;
            if (!float.TryParse(precioString, out precio) || precio < 0)
            {
                string mensajeError = $"Datos Invalidos{Environment.NewLine}Por favor, ingrese un numero positivo";
                throw new DatosInvalidosException(mensajeError);
            }
            this.precios[precioSeleccionado] = precio;
        }

        /// <summary>
        /// Lee la lista de precios del archivo en pathPrecios
        /// Si no existe el archivo lo crea con valores por defecto
        /// Utiliza serializacion XML
        /// </summary>
        public void ObtenerPrecios()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<float>));
            try
            {
                using (StreamReader streamReader = new StreamReader(pathPrecios))
                {
                    precios = serializer.Deserialize(streamReader) as List<float>;
                }
            }
            catch (FileNotFoundException)
            {
                precios = new List<float>() {1000, 8000, 25000, 1500};
                GuardarPrecios();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Guarda los valores de la lista de precios en un archivo
        /// Utiliza serializacion XML
        /// </summary>
        public void GuardarPrecios()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<float>));

            using (StreamWriter streamWriter = new StreamWriter(pathPrecios))
            {
                serializer.Serialize(streamWriter, precios);
            }
        }

        /// <summary>
        /// Agrega un turno a la lista de turnos
        /// </summary>
        /// <param name="turno"></param>
        public void AgregarTurno(Turno turno)
        {
            turnos.Add(turno);
        }

        /// <summary>
        /// Elimina el turno a modificar de la lista de turnos
        /// Añade el nuevo turno
        /// </summary>
        /// <param name="turnoAModificar"></param>
        /// <param name="nuevoTurno"></param>
        public void ModificarTurno(Turno turnoAModificar, Turno nuevoTurno)
        {
            turnos.Remove(turnoAModificar);
            turnos.Add(nuevoTurno);
        }

        /// <summary>
        /// Elimina un turno de la lista de turnos
        /// </summary>
        /// <param name="turno"></param>
        public void EliminarTurno(Turno turno)
        {
            turnos.Remove(turno);
        }

        /// <summary>
        /// Guarda la lista de turnos en pathTurnos
        /// Elimina turnos vencidos (fecha menor a la actual)
        /// Utiliza serializacion JSON
        /// </summary>
        public void GuardarTurnos()
        {
            GuardarTurnos(pathTurnos);
        }

        /// <summary>
        /// Guarda la lista de turnos en el path especificado.
        /// Elimina turnos vencidos (fecha menor a la actual)
        /// Utiliza serializacion JSON
        /// </summary>
        /// <param name="path">path donde se guardara la lista de turnos</param>
        public void GuardarTurnos(string path)
        {
            List<TurnoDTO> listaAGuardar = new List<TurnoDTO>();
            string json;
            TurnoDTO turnoDTO;

            EliminarTurnosVencidos();
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    foreach (Turno turno in turnos)
                    {
                        turnoDTO = new TurnoDTO();
                        turnoDTO.ConvertirADTO(turno);

                        listaAGuardar.Add(turnoDTO);
                    }

                    json = JsonSerializer.Serialize(listaAGuardar);
                    streamWriter.Write(json);
                }
            }
            catch (ArgumentException)
            {
            }
        }

        /// <summary>
        /// Lee los turnos en pathTurnos
        /// Si el archivo no existe lo crea con una lista de turnos vacia
        /// Utiliza serializacion JSON
        /// </summary>
        public void ObtenerTurnos()
        {
            try
            {
                ObtenerTurnos(pathTurnos);
            }
            catch(FileNotFoundException)
            {
                using (StreamWriter streamWriter = new StreamWriter(pathTurnos))
                {
                    streamWriter.Write("[]");
                }
            }
            catch(JsonException)
            {
            }
        }

        /// <summary>
        /// Lee los turnos de path especificado
        /// Si ya existe un turno cargado con la misma fecha lo ignora
        /// </summary>
        /// <param name="path">path del cual se leearon los turnos</param>
        public void ObtenerTurnos(string path)
        {
            List<TurnoDTO> turnosDTO;
            try
            {
                using (StreamReader streamReader = new StreamReader(pathTurnos))
                {
                    string json = streamReader.ReadToEnd();

                    turnosDTO = JsonSerializer.Deserialize<List<TurnoDTO>>(json);

                    foreach (TurnoDTO turnoDTO in turnosDTO)
                    {
                        try
                        {
                            Turno turno = turnoDTO.GenerarObjeto();
                            if(turno != turnos)
                            {
                                turnos.Add(turno);
                            }
                        }
                        catch (DatosInvalidosException)
                        {
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (JsonException)
            {
                throw;
            }
        }

        /// <summary>
        /// Devuelve una lista con los turnos del dia especificado
        /// Los devuelve ordenados en orden ascendente
        /// </summary>
        /// <param name="fecha">fecha de la cual se desea saber los turnos</param>
        /// <returns></returns>
        public List<Turno> ObtenerTurnosDelDia(DateTime fecha)
        {
            List<Turno> turnosDelDia = new List<Turno>();
            foreach (Turno turno in turnos)
            {
                if (turno.Fecha.Date == fecha.Date)
                {
                    turnosDelDia.Add(turno);
                }
            }
            turnosDelDia.Sort();
            return turnosDelDia;
        }

        /// <summary>
        /// Devuelve la lista de turnos del dia de hoy
        /// </summary>
        /// <returns></returns>
        public List<Turno> ObtenerTurnosHoy()
        {
            return ObtenerTurnosDelDia(DateTime.Now);
        }

        /// <summary>
        /// Devuelve una lista de horarios
        /// que no estan ocupados en la fecha especificada por algun turno
        /// </summary>
        /// <param name="fecha">fecha de la cual se desea conocer los horarios disponibles</param>
        /// <returns></returns>
        public List<DateTime> ObtenerHorariosDisponibles(DateTime fecha)
        {
            DateTime horario = new DateTime(fecha.Date.Year, fecha.Date.Month, fecha.Date.Day, 9, 0, 0);
            List<Turno> turnosDelDia = ObtenerTurnosDelDia(fecha);
            List<DateTime> turnosDisponibles = new List<DateTime>();

            while(horario < DateTime.Now.AddHours(2))
            {
                horario = horario.AddMinutes(30);
            }
            while (horario.Hour < 18)
            {
                bool estaDisponible = true;
                foreach (Turno turno in turnosDelDia)
                {
                    if (turno.Fecha.Hour == horario.Hour && turno.Fecha.Minute == horario.Minute)
                    {
                        estaDisponible = false;
                    }
                }
                if (estaDisponible)
                {
                    turnosDisponibles.Add(horario);
                }
                horario = horario.AddMinutes(30);
            }

            return turnosDisponibles;
        }

        /// <summary>
        /// Elimina turnos cuya fecha sea menor a la actual
        /// </summary>
        private void EliminarTurnosVencidos()
        {
            List<Turno> listaCorrecta = new List<Turno>();
            foreach (Turno turno in turnos)
            {
                if(turno.Fecha >= DateTime.Now)
                {
                    listaCorrecta.Add(turno);
                }
            }

            turnos = listaCorrecta;
        }
    }
}
