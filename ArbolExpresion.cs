public class Convertor
{
    public List<string> Postfijo (string expresion_infija)
    {
        List<string> salida = new List<string>();
        Stack<string> pila = new Stack<string>();


        for (int i = 0; i < expresion_infija.Length; i++)
        {
            char actual = expresion_infija[i];

            if (char.IsWhiteSpace(actual))
            {
                continue;
            }

            else if (char.IsDigit(actual))
            {
                string numero = leerNumero(expresion_infija, ref i);
                salida.Add(numero);
                continue;
            }

            else if (char.IsLetter(actual))
            {
                string operador_logico = LeerPalabra(expresion_infija, ref i);

                while (!EsOperadorLogico(operador_logico))
                {
                    throw new Exception("Operador no valido");
                }

                ProcesarOperador(operador_logico, pila, salida);
                continue;
            }
            else if (actual == '(')
            {
                pila.Push("(");
                continue;
            }
            else if (actual == ')')
            {
                ProcesarParentesisCierre(pila, salida);
                continue;
            }

            string operador_aritmetico = LeerOperadorAritmetico(expresion_infija, ref i);
            ProcesarOperador(operador_aritmetico, pila, salida);
        }

        while (pila.Count > 0)
        {
         salida.Add(pila.Pop());   
        }

        return salida;
    }

    private string LeerOperadorAritmetico(string expresion, ref int i)
    {
        if (expresion[i] == '*' && i + 1 < expresion.Length && expresion[i + 1] == '*')
        {
            i++;
            return "**";
        }

        return expresion[i].ToString();
    }


    private string leerNumero(string expresion_infija, ref int i)
    {
        string numero = "" ;

        while(i < expresion_infija.Length && char.IsDigit(expresion_infija[i]))
        {
            numero += expresion_infija[i];
            i++;
        }
        i--;
        return numero;
    }


    private string LeerPalabra(string expresion, ref int i)
    {
        string palabra = "";

        while (i < expresion.Length && char.IsLetter(expresion[i]))
        {
            palabra += expresion[i];
            i++;
        }

        i--;
        return palabra;
    }

    private bool EsOperadorLogico(string operador_logico)
    {
        return operador_logico == "and" || operador_logico == "or" || operador_logico == "not" || operador_logico == "xor";
    }

    private int ObtenerPrecedencia(string operador_logico)
    {
        switch (operador_logico)
        {
            case "not": return 4;
            case "**": return 4;
            case "*":
            case "/":
            case "%": return 3;
            case "+":
            case "-": return 2;
            case "and": return 1;
            case "or":
            case "xor": return 0;
            default: return -1;
        }
    }

    private bool EsAsociativoIzquierda(string operador_logico)
    {
        return operador_logico != "**" && operador_logico != "not";
    }

    private void ProcesarOperador(string operador_logico, Stack<string> pila, List<string> salida)
    {
        while (pila.Count > 0 && pila.Peek() != "(")
        {
            string cima = pila.Peek();

            int precedencia_cima = ObtenerPrecedencia(cima);
            int precedencia_actual = ObtenerPrecedencia(operador_logico);

            if (precedencia_cima > precedencia_actual || (precedencia_cima == precedencia_actual && EsAsociativoIzquierda(operador_logico)))
            {
                salida.Add(pila.Pop());
            }
            else
            {
                break;
            }
        }

        pila.Push(operador_logico);
    }
    private void ProcesarParentesisCierre(Stack<string> pila, List<string> salida)
    {
        while (pila.Count > 0 && pila.Peek() != "(")
            salida.Add(pila.Pop());

        pila.Pop();
    }

}


class Program
{
    public static void Main(string[] args)
    {
        Convertor convertor = new Convertor();
        List<string> resultado = convertor.Postfijo("23 + 9 * (9 - 2)");
        Console.WriteLine(string.Join(" ", resultado));
    }
}