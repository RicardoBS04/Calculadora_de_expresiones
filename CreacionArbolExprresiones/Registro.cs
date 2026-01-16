namespace CreacionArbolExprresiones
{
public class Registro
{
    public string ruta;

    public Registro(string Ruta)
    {
        ruta = Ruta ;
    }

    public void registrarOperacion(List<string> expresion, double resultado)
    {

        bool existe = File.Exists(ruta);

        using(StreamWriter writer = new StreamWriter(ruta, true))
        {
            if (!existe)
            {
                writer.WriteLine("Fecha, Expresion, Resultado");
            }

            string expresion_string = string.Join("", expresion);
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            writer.WriteLine($"{fecha},{expresion_string},{resultado}");
        }
    } 

    public string getRegistro()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }
            return string.Empty;
        }
}
}