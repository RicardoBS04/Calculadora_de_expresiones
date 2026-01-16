namespace CreacionArbolExprresiones{
public class Nodo
{
    public string valor { get; set;}
    public Nodo hijo_derecho { get; set;}
    public Nodo hijo_izquierdo { get; set;}

    public Nodo(string valor)
    {
        this.valor = valor;
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
                    Nodo hijo = pila.Pop();
                    nodo_operador_not.hijo_izquierdo = hijo;

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

    public double EvaluarArbol(Nodo nodo)
    {
        if(nodo.hijo_izquierdo == null && nodo.hijo_derecho == null)
        {
            return Convert.ToDouble(nodo.valor);
        }

        if(nodo.valor == "not")
        {
            double hijo = EvaluarArbol(nodo.hijo_izquierdo);

            if (!EsLogico(hijo))
            {
                throw new Exception("Solo se aceptan valores de 0 o 1");
            }

            return hijo == 0 ? 1 : 0;
        }

        double izquierdo = EvaluarArbol(nodo.hijo_izquierdo);
        double derecho = EvaluarArbol(nodo.hijo_derecho);

        switch (nodo.valor)
        {
            case "+":
                return izquierdo + derecho;
            case "-":
                return izquierdo - derecho;
            case "/":
                return izquierdo / derecho;
            case "*":
                return izquierdo * derecho;
            case "**":
                return Math.Pow(izquierdo, derecho);
            case "%":
                return izquierdo % derecho;
            case "and":

                if(!EsLogico(izquierdo) || !EsLogico(derecho))
                    {
                       throw new Exception("Tienen que ser valores de 0 o 1"); 
                    }
                return (izquierdo == 1 && derecho == 1) ? 1 : 0;

            case "or":

                if(!EsLogico(izquierdo) || !EsLogico(derecho))
                    {
                       throw new Exception("Tienen que ser valores de 0 o 1"); 
                    }
                return (izquierdo == 1 || derecho == 1) ? 1 : 0;
                
            case "xor":

                if(!EsLogico(izquierdo) || !EsLogico(derecho))
                    {
                       throw new Exception("Tienen que ser valores de 0 o 1"); 
                    }
                return (izquierdo != derecho) ? 1 : 0;

            default:
                throw new Exception("Operador desconocido");
        }

    }

    private bool EsLogico(double valor)
        {
            return valor == 1 || valor == 0 ;
        }
}
}
