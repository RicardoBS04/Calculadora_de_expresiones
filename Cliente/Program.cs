using System.Net.Sockets;
using System.Text;

namespace clienteTCP
{
    public class ClienteTCP
    {
        private TcpClient _cliente;
        private NetworkStream _stream;

        public void Conectar(string ip, int puerto)
        {
            _cliente = new TcpClient(ip, puerto);
            _stream = _cliente.GetStream();
        }

        public void Enviar(string mensaje)
        {
            byte[] datos = Encoding.UTF8.GetBytes(mensaje);
            _stream.Write(datos, 0, datos.Length);
        }

        public string Recibir()
        {
            byte[] buffer = new byte[1024];
            int bytes = _stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytes);
        }

        public void Cerrar()
        {
            _stream.Close();
            _cliente.Close();
        }
    }
}
