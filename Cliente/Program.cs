using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;


namespace cliente
{
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

            byte[] buffer = new byte[1024];
            int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
            string respuesta = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

            Console.WriteLine("Respuesta del servidor: " + respuesta);

            stream.Close();
            cliente.Close();
        }

        public void enviar_mensaje(string dato)
        {
            byte[] datos = Encoding.UTF8.GetBytes(dato);
            stream.Write(datos, 0, datos.Length);
            Console.WriteLine("Mensaje enviado con éxito");
        }
    }
}

