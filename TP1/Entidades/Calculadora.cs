﻿namespace Entidades
{
    public static class Calculadora
    {
        //metodos privados
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }

            return '+';
        }

        //metodos publicos
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;

            operador = ValidarOperador(operador);

            switch (operador)
            {
                case '-':
                    resultado = num1 - num2;
                    break;

                case '/':
                    resultado = num1 / num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                default:
                    resultado = num1 + num2;
                    break;
            }

            return resultado;
        }
    }
}