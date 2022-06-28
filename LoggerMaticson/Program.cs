using LibraryLoggerMaticson;

//создаем логеры
//консольный логер с именем
Logger loggerConsole = new LoggerConsole("my logger");
//консольный логер без имени
Logger loggerConsole2 = new LoggerConsole();
//файловый логер, который создает файл по указанному пути
Logger logFile = new LoggerFile(Environment.CurrentDirectory + "/My Logs");
//логер,который сохраняет данные в БД
Logger logDB = new LoggerDB();


int firstNumb = 5;
int zero = 0;

loggerConsole.Debug("Создали два числа");
loggerConsole2.Debug("Создали два числа");
logFile.Debug("Создали два числа");
logDB.Debug("Создали два числа");


try
{
    Console.WriteLine($"Результат: {firstNumb/zero}");
    logFile.Info($"Результат: {firstNumb / zero}");
    logDB.Debug($"Результат: {firstNumb / zero}");
}
catch (Exception ex)
{
    loggerConsole.Warn("Не удалось выполнить деление.\n"+ex.ToString());
    logFile.Warn("Не удалось выполнить деление.\n" + ex.ToString());
    logDB.Warn("Не удалось выполнить деление.\n" + ex.ToString());
}

Console.WriteLine("Выполним умножение. Введите два числа.");
Console.WriteLine("1 множитель >");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 множитель >");
var num2 = Convert.ToInt32(Console.ReadLine());

loggerConsole.Info($"Пользователь ввёл два числа: {num1}, {num2}");
logFile.Info($"Пользователь ввёл два числа: {num1}, {num2}");
logDB.Info($"Пользователь ввёл два числа: {num1}, {num2}");

var result = num1 * num2;
loggerConsole.Info($"Результат: {result.ToString()}");
logFile.Info($"Результат: {result.ToString()}");
logDB.Info($"Результат: {result.ToString()}");