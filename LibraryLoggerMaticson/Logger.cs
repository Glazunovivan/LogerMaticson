namespace LibraryLoggerMaticson
{
    abstract public class Logger : ILogger
    {
        protected string _name = string.Empty;

        public Logger() { }

        /// <summary>
        /// Создает логер с именем
        /// </summary>
        /// <param name="name"></param>
        public Logger(string name)
        {
            _name = name;   
        }

        /// <summary>
        /// Выводит сообщение с пометкой DEBUG
        /// </summary>
        /// <param name="message"></param>
        public abstract void Debug(string message);

        /// <summary>
        /// Выводит сообщение с пометкой ERROR
        /// </summary>
        /// <param name="message"></param>
        public abstract void Error(string message);

        /// <summary>
        /// Выводит сообщение с пометкой INFO
        /// </summary>
        /// <param name="message"></param>
        public abstract void Info(string message);

        /// <summary>
        /// Выводит сообщение с пометкой WARN
        /// </summary>
        /// <param name="message"></param>
        public abstract void Warn(string message);

        /// <summary>
        /// Выдает строку с именем логера (если оно установлено), иначе пустую строку
        /// </summary>
        /// <returns></returns>
        protected string ShowName()
        {
            if (_name != string.Empty)
            {
                return $"{_name}.";
            }
            else
            {
                return "";
            }
        }
    }
}
