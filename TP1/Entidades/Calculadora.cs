namespace Entidades
{
    public static class Calculadora
    {
        //metodos privados

        /// <summary>
        /// Recibe un char y valida que sea un operador (+, -, /, *)
        /// </summary>
        /// <param name="operador">char a validar si es un operador</param>
        /// <returns>el operador correspondiente o + en caso de operador no ser valido</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }

            return '+';
        }

        //metodos publicos

        /// <summary>
        /// Recibe dos operandos, un operador y realiza la operacion correspondiente
        /// </summary>
        /// <param name="num1">primer operando</param>
        /// <param name="num2">segundo operando</param>
        /// <param name="operador">operador a realizar</param>
        /// <returns>el resultado de la operacion</returns>
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
