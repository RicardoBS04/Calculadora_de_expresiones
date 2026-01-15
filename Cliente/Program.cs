using System;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        string ipServidor = "127.0.0.1";
        int puerto = 5000;

        TcpClient cliente = new TcpClient();

        cliente.Connect(ipServidor, puerto);
        Console.WriteLine("Conectado al servidor");

        NetworkStream stream = cliente.GetStream();

        Console.Write("Ingrese una expresión: ");
        string mensaje = Console.ReadLine();

        byte[] datos = Encoding.UTF8.GetBytes(mensaje);
        stream.Write(datos, 0, datos.Length);

        byte[] buffer = new byte[1024];
        int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
        string respuesta = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

        Console.WriteLine("Respuesta del servidor: " + respuesta);

        stream.Close();
        cliente.Close();
    }
}
