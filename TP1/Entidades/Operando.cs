using System;

namespace Entidades
{
    public class Operando
    {
        //atributo
        private double numero;


        //constructores

        /// <summary>
        /// Inicializa atributo numero en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Inicializa numero segun el parametro
        /// </summary>
        /// <param name="numero">numero a asignar al atributo numero</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Inicializa numero segun el string del parametro, si no es valido inicializa en 0
        /// </summary>
        /// <param name="strNumero">string a intentar convertir a double y asignar a numero</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        //propiedades
        /// <summary>
        /// Asigna el string al atributo numero de ser posible, si no asigna 0 
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        //metodos privados

        /// <summary>
        /// Recibe un string y lo intenta retornarlo como double, si no se puede retorna 0
        /// </summary>
        /// <param name="strNumero">string a convertir a double</param>
        /// <returns>double tras la conversion o 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double numero = 0;
            //Reemplazo '.' por ',' porque TryParse convierte "2.2" en 22 y considero que deberia ser "2.2" = 2.2
            strNumero = strNumero.Replace('.', ',');
            double.TryParse(strNumero, out numero);

            return numero;
        }

        /// <summary>
        /// Valida si un string esta compuesto unicamente por '0' y '1'
        /// </summary>
        /// <param name="binario">string a validar</param>
        /// <returns>true, string solo tiene '1' y '0' - si no false</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }

            return true;
        }

        //metodos publicos

        /// <summary>
        /// Convierte un string binario a decimal de ser posible
        /// </summary>
        /// <param name="binario">string binario a intentar convertir a decimal</param>
        /// <returns>string del numero decimal - "Valor Invalido" de no ser un string binario el paramatro</returns>
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                ulong resultado = Convert.ToUInt64(binario, 2);
                return resultado.ToString();
            }

            return "Valor invalido";
        }

        /// <summary>
        /// Convierte un numero decimal en binario, solo toma el valor absoluto y entero del mismo
        /// </summary>
        /// <param name="numero">numero decimal a convertir a binario</param>
        /// <returns>string binario</returns>
        public string DecimalBinario(double numero)
        {
            numero = Math.Abs(numero);

            return Convert.ToString((long)numero, 2);
        }

        /// <summary>
        /// Recibe un string de un numero decimal e intenta convertirlo a binario
        /// </summary>
        /// <param name="numero">string de un numero decimal a convetir</param>
        /// <returns>string binario - "Valor invalido" en caso de no ser posible la conversion</returns>
        public string DecimalBinario(string numero)
        {
            double numeroDecimal;
            if (double.TryParse(numero, out numeroDecimal))
            {
                return DecimalBinario(numeroDecimal);
            }

            return "Valor invalido";
        }

        //sobrecargas de operador
        /// <summary>
        /// Suma los numeros de los operandos
        /// </summary>
        /// <param name="n1">primer operando</param>
        /// <param name="n2">segundo operando</param>
        /// <returns>la suma del primer numero y el segundo</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Resta los numeros de los operandos
        /// </summary>
        /// <param name="n1">primer operando</param>
        /// <param name="n2">segundo operando</param>
        /// <returns>la resta del primer numero y el segundo</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Intenta dividir el numero del primer operando y el segundo.
        /// De no ser posible retorna double.MinValue
        /// </summary>
        /// <param name="n1">primer operando</param>
        /// <param name="n2">segundo operando</param>
        /// <returns>el resultado de la division o double.MinValue si n2 es 0</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        /// <summary>
        /// Multiplica los numeros de ambos opeandos
        /// </summary>
        /// <param name="n1">primer operando</param>
        /// <param name="n2">segundo operando</param>
        /// <returns>El resultado de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
