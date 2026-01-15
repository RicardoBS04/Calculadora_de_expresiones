namespace CreacionArbolExprresiones{
public class Nodo
{
    public string valor { get; set;}
    public Nodo hijo_derecho { get; set;}
    public Nodo hijo_izquierdo { get; set;}

    public Nodo(string valor)
    {
        Valor = valor;
        hijo_derecho = null;
        hijo_izquierdo = null;
    }
    
}

public class ArbolDeExpresiones
{
    public Nodo raiz { get; set;}

    public ArbolDeExpresiones()
    {
        raiz = null;
    }

    public void construirArbol(List<string> salidaPostfija)
    {
        HashSet<string> operadores = new HashSet<string>
        {
            "+", "-", "*", "/", "**", "%",
            "and", "or", "xor", "not"
        };
        Stack<Nodo> pila = new Stack<Nodo>();


        foreach(string tokenString in salidaPostfija)
        {
            if (operadores.Contains(tokenString))
            {
                if (tokenString == "not")
                {
                    Nodo nodo_operador_not = new Nodo(tokenString);
                    Nodo hijoIzquierdo = pila.Pop();
                    nodo_operador_not.hijo_izquierdo = hijoIzquierdo;

                    pila.Push(nodo_operador_not);
                    continue;
                }
                Nodo nodo_operador = new Nodo(tokenString);
                Nodo hijoDerecho = pila.Pop();
                Nodo hijoIzquierdo = pila.Pop();

                nodo_operador.hijo_derecho = hijoDerecho;
                nodo_operador.hijo_izquierdo = hijoIzquierdo;

                pila.Push(nodo_operador);
            }
            else
            {
                Nodo nodo_operando = new Nodo(tokenString);
                pila.Push(nodo_operando);
            }
        }

        if (pila.Count == 1)
        {
            raiz = pila.Pop();
        }
        else
        {
            throw new Exception("Expresion postfija invalida");
        }
    }
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