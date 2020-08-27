using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TestTCPserver
{
    class Serverworker
    {
        public void Start()
        {
            // Her coder vi vores worker

            // Vi opretter serveren
            // Ip egen computer (altså 127.0.0.1), port er applikationen her har vi en ekko server så vi bruger port 7
            TcpListener server = new TcpListener(IPAddress.Loopback, 7);
            server.Start();

            // Vent på en klient laver et opkald
            TcpClient socket = server.AcceptTcpClient();

            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());

            // Læses tekst fra client
            String str = sr.ReadLine();
            Console.WriteLine($"Her er server input: {str}");

            // Svar clienten
            sw.WriteLine(str);
            sw.Flush(); // Tømmer buffer

            socket.Close();

        }
    }
}
