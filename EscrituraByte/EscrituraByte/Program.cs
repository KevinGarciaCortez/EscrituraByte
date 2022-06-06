using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraByte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nbyte=0,car;
            try
            {
                fs = new FileStream("text.txt", FileMode.Create, FileAccess.Write);
                Console.WriteLine("Escriba:");
                while ((car = Console.Read()) != '\r' && (nbyte < buffer.Length))
                {
                    buffer[nbyte] = (byte)car;
                    nbyte++;
                }
                fs.Write(buffer, 0, nbyte);

            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(fs!=null)fs.Close();
            }
        }
    }
}
