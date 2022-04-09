using System;

namespace Entidades
{
    public class Operando
    {
        //atributo
        private double numero;


        //constructores
        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        //propiedades
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        //metodos privados
        private double ValidarOperando(string strNumero)
        {
            double numero = 0;
            double.TryParse(strNumero, out numero);

            return numero;
        }
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
        public string BinarioDecimal(string binario)
        {
            if(EsBinario(binario))
            {
                return Convert.ToInt32(binario, 2).ToString();
            }

            return "Valor invalido";
        }
        public string DecimalBinario(double numero)
        {
            numero = Math.Abs(numero);

            return Convert.ToString((long)numero,2);
        }

        public string DecimalBinario(string numero)
        {
            double numeroDecimal;
            if(double.TryParse(numero, out numeroDecimal))
            {
                return DecimalBinario(numeroDecimal);
            }

            return "Valor invalido";
        }

        //sobrecargas de operador
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
