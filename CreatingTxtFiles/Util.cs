using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTxtFiles
{
    public class Util
    {

        /// <summary>
        /// return path of file and the file name
        /// </summary>
        /// <returns></returns>
        public static string GetPath()
        {
            string path = string.Empty;

            try
            {
                string fileName = DateTime.Now.ToString("yyyy-MM-dd") + "_LOG";
                fileName = fileName.Replace("-", "_");

                path = @"C:\Users\patovega\Desktop\FolderProject\" + fileName + ".txt";

                if (!System.IO.File.Exists(path))
                {    //if file dont exist then create the file log
                    System.IO.File.Create(path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return path;
        }
    }
}
