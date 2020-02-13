using System;
using System.Net;
using System.Net.Sockets;

namespace Redes
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            //Creacion del Socket
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Enlace de socket al puerto (y en cualquier interfaz de red)
            //Salta excepción si el puerto está ocupado
            s.Bind(ie);
            //Esperando una conexión y estableciendo cola de clientes pendientes
            s.Listen(10);
            //Esperamos y aceptamos la conexion del cliente (socket bloqueante)
            Socket sClient = s.Accept();
            //Obtenemos la info del cliente
            //El casting es necesario ya que RemoteEndPoint es del tipo EndPoint
            //mas genérico
            IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
            Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address, ieClient.Port);
            sClient.Close(); // Se puede usar using con Socket y nos ahorramos los close.
            s.Close();
            Console.ReadKey();
        }
    }
}
