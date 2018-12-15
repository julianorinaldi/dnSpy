using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dnSpyLibrary
{
    /// <summary>
    /// Contém operações da matemática básica
    /// </summary>
    public static class Matematica
    {
        /// <summary>
        /// Checar quald os dois valores é o maior
        /// </summary>
        /// <param name="valor1">Entrada de variável numérica 1</param>
        /// <param name="valor2">Entrada de variável numérica 2</param>
        /// <returns>Retorna o valor maior, ou qualquer um se forem iguais</returns>
        public static int ChecarMaiorNumero(int valor1, int valor2)
        {
            if (valor1 > valor2)
                return valor2;

            return valor1;
        }
    }
}
