using System.Net.Sockets;
using System.Text;

namespace clienteTCP
{
    public class ClienteTCP
    {
        private TcpClient cliente;
        private NetworkStream stream;

        public void Conectar(string ip, int puerto)
        {
            cliente = new TcpClient(ip, puerto);
            stream = cliente.GetStream();
        }

        public void Enviar(string mensaje)
        {
            byte[] datos = Encoding.UTF8.GetBytes(mensaje);
            stream.Write(datos, 0, datos.Length);
        }

        public string Recibir()
        {
            byte[] buffer = new byte[1024];
            int bytes = stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytes);
        }

        public void Cerrar()
        {
            stream.Close();
            cliente.Close();
        }
    }
}
