using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller1_u2
{
    internal class funciones
    {
        public int solo_numeros(char caracter)
        {
            string Caracteres_Aceptados = "0123456789" + (char)8 + (char)13;
            if (Caracteres_Aceptados.IndexOf(caracter) == -1)
            {
                return 0;
            }
            else
            {
                return (int)caracter;
            }
        }
        public int solo_numeros_k(char caracter)
        {
            string Caracteres_Aceptados = "0123456789" + (char)8 + (char)13 + (char)75 + (char)107;
            if (Caracteres_Aceptados.IndexOf(caracter) == -1)
            {
                return 0;
            }
            else
            {
                return (int)caracter;
            }
        }
    }
}
