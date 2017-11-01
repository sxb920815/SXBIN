using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SXBIN.Tool
{
    public class Log
    {

        /// <summary>
        /// 获取日志保存的地址
        /// </summary>
        /// <returns></returns>
        private static string GetFolderPath()
        {
            string path =
                $"{AppDomain.CurrentDomain.BaseDirectory}\\App_Data\\Logs\\{DateTime.Now.Year}\\{DateTime.Now.Month}";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        /// <summary>
        /// 获取单个日志保存的地址
        /// </summary>
        /// <returns></returns>
        private static string GetSingleFolderPath()
        {
            string path =
                $"{AppDomain.CurrentDomain.BaseDirectory}\\App_Data\\Logs-Single\\{DateTime.Now.Year}\\{DateTime.Now.Month}\\{DateTime.Now.Day}";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        /// <summary>
        /// 错误日志
        /// </summary>
        public static void ErrorMessage(string message)
        {
            var fileName = $"{GetFolderPath()}\\ErrorMessage-{DateTime.Now.ToString("yyyy.MM.dd")}.log";
            File.AppendAllText(fileName,$"\r\n{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\r\n{message}\r\n");
        }

        public static void Error(Exception ex)
        {
            var fileName = $"{GetFolderPath()}\\Error-{DateTime.Now.ToString("yyyy.MM.dd")}.log";
            StringBuilder str = new StringBuilder();
            string ip = "";
            str.Append("\t错误信息：" + ex.Message);
            str.Append("\r\n\t错误源：" + ex.Source);
            str.Append("\r\n\t异常方法：" + ex.TargetSite);
            str.Append("\r\n\t堆栈信息：" + ex.StackTrace);
            str.Append("\r\n--------------------------------------------------------------------------------------------------");
            File.AppendAllText(fileName, $"\r\n{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\r\n{str.ToString()}\r\n");
        }

        /// <summary>
        /// 常规日志
        /// </summary>
        /// <param name="message"></param>
        public static void Information(string message)
        {
            var fileName = $"{GetFolderPath()}\\Information-{DateTime.Now.ToString("yyyy.MM.dd")}.log";
            File.AppendAllText(fileName, $"\r\n{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\r\n{message}\r\n");
        }

        /// <summary>
        /// 记录单个日志（一个日志一个文件）
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="message"></param>
        public static void SingleLog(string fileName,string message)
        {
            var path = $"{GetSingleFolderPath()}\\{fileName}.log";
            File.AppendAllText(path, $"\r\n{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\r\n{message}\r\n");
        }
    }
}