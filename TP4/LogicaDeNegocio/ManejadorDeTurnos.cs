using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        //constantes SQL
        private const string nombreDeTabla = "tablaDeTurnos";
        private const string conectionString = "Server=.;Database=Odontologia;Trusted_Connection=True;";

        //atributos
        private string pathPrecios;
        private SqlConnection coneccionBaseDeDatos;
        private SqlCommand command;
        private List<float> precios;

        //constructor
        public ManejadorDeTurnos(string pathPrecios)
        {
            InstanciarSqlConecction(conectionString);
            command = new SqlCommand();
            command.Connection = coneccionBaseDeDatos;

            this.pathPrecios = pathPrecios;
            ObtenerPrecios();
            EliminarTurnosVencidos();
        }

        //propiedades
        public List<float> Precios
        {
            get { return precios; }
        }

        private List<Turno> Turnos
        {
            get
            {
                string querry = $"SELECT * FROM {nombreDeTabla}";
                try
                {
                    coneccionBaseDeDatos.Open();
                    command.Parameters.Clear();

                    command.CommandText = querry;

                    SqlDataReader dataReader = command.ExecuteReader();
                    return ObtenerTurnosDeDataReader(dataReader);
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    coneccionBaseDeDatos.Close();
                }
            }
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
                precios = new List<float>() { 1000, 8000, 25000, 1500 };
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
            string atributosDeTurno = "fecha, precio, tipo, telefono, nombre, apellido, dni, fueAtendido";
            string mascarasDeTurno = "@fecha, @precio, @tipo, @telefono, @nombre, @apellido, @dni, @fueAtendido";

            string querry = $"INSERT INTO {nombreDeTabla} ({atributosDeTurno}) VALUES ({mascarasDeTurno})";
            try
            {
                coneccionBaseDeDatos.Open();
                command.Parameters.Clear();
                command.CommandText = querry;

                command.Parameters.AddWithValue("fecha", turno.Fecha.ObtenerFormatoFechaHoraLong());
                command.Parameters.AddWithValue("precio", turno.Precio);
                command.Parameters.AddWithValue("tipo", turno.Tipo);
                command.Parameters.AddWithValue("telefono", turno.Telefono);
                command.Parameters.AddWithValue("nombre", turno.Nombre);
                command.Parameters.AddWithValue("apellido", turno.Apellido);
                command.Parameters.AddWithValue("dni", turno.DniPaciente);
                command.Parameters.AddWithValue("fueAtendido", turno.FueAtendido);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (coneccionBaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    coneccionBaseDeDatos.Close();
                }
            }
        }

        /// <summary>
        /// Elimina el turno a modificar de la lista de turnos
        /// Añade el nuevo turno
        /// </summary>
        /// <param name="turnoAModificar"></param>
        /// <param name="nuevoTurno"></param>
        public void ModificarTurno(Turno turnoAModificar, Turno nuevoTurno)
        {
            EliminarTurno(turnoAModificar);
            AgregarTurno(nuevoTurno);
        }

        public void MarcarTurnoComoAtendido(Turno turnoAtendido)
        {
            try
            {
                coneccionBaseDeDatos.Open();
                string querry = $"UPDATE {nombreDeTabla} SET fueAtendido = 1 WHERE fecha = @fechaTurno";
                long fecha = turnoAtendido.Fecha.ObtenerFormatoFechaHoraLong();

                command.CommandText = querry;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("fechaTurno", fecha);

                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
            }
            finally
            {
                if(coneccionBaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    coneccionBaseDeDatos.Close();
                }
            }
        }

        /// <summary>
        /// Elimina un turno de la lista de turnos
        /// </summary>
        /// <param name="turno"></param>
        public void EliminarTurno(Turno turno)
        {
            long fechaDelTurno = turno.Fecha.ObtenerFormatoFechaHoraLong();
            string querry = $"DELETE FROM {nombreDeTabla} WHERE fecha = @fechaEliminar";

            try
            {
                coneccionBaseDeDatos.Open();
                command.CommandText = querry;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("fechaEliminar", fechaDelTurno);

                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
            }
            finally
            {
                if(coneccionBaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    coneccionBaseDeDatos.Close();
                }
            }
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
                    foreach (Turno turno in this.Turnos)
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
        /// Lee los turnos de path especificado
        /// Si ya existe un turno cargado con la misma fecha lo ignora
        /// </summary>
        /// <param name="path">path del cual se leearon los turnos</param>
        public void ObtenerTurnos(string path)
        {
            List<TurnoDTO> turnosDTO;
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string json = streamReader.ReadToEnd();

                    turnosDTO = JsonSerializer.Deserialize<List<TurnoDTO>>(json);

                    foreach (TurnoDTO turnoDTO in turnosDTO)
                    {
                        try
                        {
                            Turno turno = turnoDTO.GenerarObjeto();
                            AgregarTurno(turno);
                        }
                        catch (SqlException)
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

            long inicioDelDia = fecha.Date.ObtenerFormatoFechaHoraLong();
            long finDelDia = fecha.Date.AddHours(23).ObtenerFormatoFechaHoraLong();
            string querry = $"SELECT * FROM {nombreDeTabla} WHERE fecha > @inicio AND fecha < @fin";

            try
            {
                coneccionBaseDeDatos.Open();
                command.CommandText = querry;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("inicio", inicioDelDia);
                command.Parameters.AddWithValue("fin", finDelDia);

                SqlDataReader dataReader = command.ExecuteReader();
                turnosDelDia = ObtenerTurnosDeDataReader(dataReader);
            }
            catch(Exception)
            {
            }
            finally
            {
                if(coneccionBaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    coneccionBaseDeDatos.Close();
                }
            }

            turnosDelDia.Sort();
            return turnosDelDia;
        }

        public List<Turno> ObtenerTurnosDelDia(DateTime fecha, bool atendidos)
        {
            List<Turno> turnosDelDia = new List<Turno>();

            long inicioDelDia = fecha.Date.ObtenerFormatoFechaHoraLong();
            long finDelDia = fecha.Date.AddHours(23).ObtenerFormatoFechaHoraLong();

            string estado = atendidos ? "1" : "0";
            string querry = $"SELECT * FROM {nombreDeTabla} WHERE fecha > @inicio AND fecha < @fin AND fueAtendido = {estado}";

            try
            {
                coneccionBaseDeDatos.Open();
                command.CommandText = querry;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("inicio", inicioDelDia);
                command.Parameters.AddWithValue("fin", finDelDia);

                SqlDataReader dataReader = command.ExecuteReader();
                turnosDelDia = ObtenerTurnosDeDataReader(dataReader);
            }
            catch (Exception)
            {
            }
            finally
            {
                if (coneccionBaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    coneccionBaseDeDatos.Close();
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

        public Turno ObtenerTurnoPorHorario(long horario)
        {
            try
            {
                coneccionBaseDeDatos.Open();
                string querry = $"SELECT * FROM {nombreDeTabla} WHERE fecha = @horario";
                command.CommandText = querry;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@horario", horario);

                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                return GenerarTurnoDesdeDataReader(dataReader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(coneccionBaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    coneccionBaseDeDatos.Close();
                }
            }
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

            while (horario < DateTime.Now.AddHours(2) && horario.Hour < 18)
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
            long fechaDeHoy = DateTime.Now.ObtenerFormatoFechaHoraLong();
            string querry = $"REMOVE * FROM {nombreDeTabla} WHERE fecha < @fechaDeHoy AND fueAtendido = 0";

            try
            {
                coneccionBaseDeDatos.Open();

                command.CommandText = querry;
                command.Parameters.Clear();

                command.Parameters.AddWithValue("fechaDeHoy", fechaDeHoy);
                
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                coneccionBaseDeDatos.Close();
            }
        }

        private void InstanciarSqlConecction(string connectionString)
        {
            try
            {
                coneccionBaseDeDatos = new SqlConnection(connectionString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static List<Turno> ObtenerTurnosDeDataReader(SqlDataReader dataReader)
        {
            List<Turno> turnos = new List<Turno>();

            while (dataReader.Read())
            {
                Turno turno = GenerarTurnoDesdeDataReader(dataReader);
                if (turno is not null)
                {
                    turnos.Add(turno);
                }
            }

            return turnos;
        }
        private static Turno GenerarTurnoDesdeDataReader(SqlDataReader dataReader)
        {
            Turno turno;

            //obtengo los datos del dataReader
            long fechaCompleta = dataReader.GetInt64(0);
            float precio = dataReader.GetFloat(1);
            Turno.TipoConsulta tipo = (Turno.TipoConsulta)dataReader.GetInt16(2);
            string telefono = dataReader.GetString(3);
            string nombre = dataReader.GetString(4);
            string apellido = dataReader.GetString(5);
            int dni = dataReader.GetInt32(6);

            DateTime fecha = fechaCompleta.ObtenerFecha();

            try
            {
                turno = new Turno(fecha, precio, tipo, dni, telefono, nombre, apellido);
                return turno;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
