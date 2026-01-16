using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {

        int puerto = 5000;

        TcpListener servidor = new TcpListener(IPAddress.Any, puerto);
        servidor.Start();

        while (true)
        {
            TcpClient cliente = servidor.AcceptTcpClient();
            Console.WriteLine("Cliente conectado");

            Thread hiloCliente = new Thread(() => ManejarCliente(cliente));
            hiloCliente.Start();
        }
    }

    static void ManejarCliente(TcpClient cliente)
    {

        NetworkStream stream = cliente.GetStream();

        byte[] buffer = new byte[1024];
        int bytesLeidos = stream.Read(buffer, 0, buffer.Length);

        string mensaje = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);
        Console.WriteLine($"Mensaje recibido: {mensaje}");

        string respuesta = "Servidor recibió: " + mensaje;

        byte[] datosRespuesta = Encoding.UTF8.GetBytes(respuesta);
        stream.Write(datosRespuesta, 0, datosRespuesta.Length);

        stream.Close();
        cliente.Close();

        Console.WriteLine("Cliente atendido y desconectado");

    }
}
