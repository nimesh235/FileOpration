using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileOpration
{
    public enum LogWriteMode
    {
        Sucsess,
        Error,
    }
    public class LogWriter
    {

        private string m_exePath = string.Empty;

        public LogWriter()
        {
        }
        public void LogWrite(string logMessage, LogWriteMode writeMode)
        {
            
            if (writeMode == LogWriteMode.Sucsess)
                m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Log\\" + "SucsessLog.txt";
            if (writeMode == LogWriteMode.Error)
                m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Log\\" + "ErrorLog.txt";
            try
            {
                System.IO.FileInfo destfileinfo = new System.IO.FileInfo(m_exePath);
                destfileinfo.Directory.Create(); // If the directory already exists, this method does nothing.
                using (StreamWriter w = File.AppendText(m_exePath))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
