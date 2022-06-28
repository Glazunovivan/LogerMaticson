using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLoggerMaticson
{
    public class LoggerFile : Logger
    {
        private string _path;
        private string _fileName;

        /// <summary>
        /// Создает файл в указанном каталоге
        /// </summary>
        public LoggerFile()
        {
            _path = Path.Combine(Environment.CurrentDirectory, "Logger");

            CreateFile(_path);
        }

        /// <summary>
        /// Создает файл в указнном каталоге
        /// </summary>
        /// <param name="path"></param>
        public LoggerFile(string path)
        {
            CreateFile(path);
        }

        public LoggerFile(string name, string path) : base(name)
        {
            CreateFile(path);
        }

        public override void Debug(string message)
        {
            string text = $"{ShowName()}DEBUG. {message}";
            WriteFile(text);
        }

        public override void Error(string message)
        {
            string text = $"{ShowName()}ERROR. {message}";
            WriteFile(text);
        }

        public override void Info(string message)
        {
            string text = $"{ShowName()}INFO. {message}";
            WriteFile(text);
        }

        public override void Warn(string message)
        {
            string text = $"{ShowName()}WARN. {message}";
            WriteFile(text);
        }

        private void CreateFile(string path)
        {
            _path = path;

            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            _fileName = Path.Combine(_path, $"Log.log");
        }

        private void WriteFile(string text)
        {
            try
            {
                string result = DateTime.Now.ToString() + text + "\n";
                File.AppendAllText(_fileName, result);
            }
            catch
            {

            }
        }
    }
}
