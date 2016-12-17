using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlDumps
{
    class MysqlBackup
    {
        public static void Backup(string mysqldump, string pathFolder, string fileName, string args)
        {
            //ConfigurationManager.AppSettings["MysqlDump"]

            ProcessStartInfo psi = new ProcessStartInfo(mysqldump, args);

            string filename = Path.Combine(pathFolder, fileName + DateTime.Now.ToString(@"yyyy-MM-dd.\sql"));

            using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
            {
                using (Process process = new Process())
                {
                    // Evita que el proceso se inicie en una nueva ventana.
                    psi.CreateNoWindow = true;

                    // Evita que se use el shell del sistema operativo para iniciar el proceso.
                    psi.UseShellExecute = false;

                    // Escribir la salida en Process.StandarOuput
                    psi.RedirectStandardOutput = true;

                    // Codificación de los datos de salida
                    psi.StandardOutputEncoding = Encoding.UTF8;

                    process.StartInfo = psi;

                    process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
                    {
                        writer.WriteLine(e.Data);
                    };

                    process.Start();

                    // Lectura asincrónica del stream de salida
                    process.BeginOutputReadLine();

                    // Esperar a que el proceso termine.
                    process.WaitForExit();
                }
            }
        }
    }
}
