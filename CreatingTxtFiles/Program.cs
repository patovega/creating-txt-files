using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTxtFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 100 ;i++)
            {
                LogWriter(i.ToString());
            }
        }

        /// <summary>
        /// write lines in the log file.
        /// </summary>
        /// <param name="logMessage"></param>
        public static void LogWriter(string logMessage)
        {
            try
            {
                string path = Util.GetPath();

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    Log(logMessage, sw);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// create a new line log in the file.
        /// </summary>
        /// <param name="logMessage"></param>
        /// <param name="txtWriter"></param>
        public static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.WriteLine(logMessage + ";" + DateTimeOffset.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
