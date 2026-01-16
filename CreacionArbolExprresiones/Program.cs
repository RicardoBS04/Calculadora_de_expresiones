using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace CreacionArbolExprresiones
{

    //CODIGO PARA PROBAR LOS ARBOLES y REGISTRO QUITAR PARA PEGAR TODO
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string expresion = "(1 + 3) * 7";

                Convertor convertor = new Convertor();
                List<string> postfija = convertor.Postfijo(expresion);

                Console.WriteLine("Expresión postfija:");
                foreach (string token in postfija)
                {
                    Console.Write(token + " ");
                }
                Console.WriteLine();

                ArbolDeExpresiones arbol = new ArbolDeExpresiones();
                arbol.construirArbol(postfija);

                double resultado = arbol.EvaluarArbol(arbol.raiz);

                Registro registro = new Registro("RegistroOperaciones.csv");
                registro.registrarOperacion(postfija, resultado);

                Console.WriteLine("\nResultado final:");
                Console.WriteLine(resultado);
                Console.WriteLine(registro.getRegistro());
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nERROR:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
