namespace LibraryLoggerMaticson
{
    public class LoggerDB : Logger
    {
        public LoggerDB() 
        {
        }

        public LoggerDB(string name) : base(name) 
        {         
        }

        public override void Debug(string message)
        {
                Models.Log newRecord = new Models.Log()
                {
                    Date = DateTime.Now.ToString(),
                    Message = $"DEBUG. "+message,
                    Name = ShowName()
                };
                AddToDB(newRecord);
        }

        public override void Error(string message)
        {
            Models.Log newRecord = new Models.Log()
            {
                Date = DateTime.Now.ToString(),
                Message = $"ERROR. " + message,
                Name = ShowName()
            };
            AddToDB(newRecord);
        }

        public override void Info(string message)
        {
            Models.Log newRecord = new Models.Log()
            {
                Date = DateTime.Now.ToString(),
                Message = $"INFO. " + message,
                Name = ShowName()
            };
            AddToDB(newRecord);
        }

        public override void Warn(string message)
        {
            Models.Log newRecord = new Models.Log()
            {
                Date = DateTime.Now.ToString(),
                Message = $"WARN. " + message,
                Name = ShowName()
            };
            AddToDB(newRecord);
        }
    
        private void AddToDB(Models.Log log)
        {
            using (var db = new DBContextLoggerSqlite())
            {
                db.Logs.Add(log);
                db.SaveChanges();
            }
        }
    }
}
