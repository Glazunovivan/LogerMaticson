# LogerMaticson
Папка LibraryLoggerMaticson - сам библиотека с логерами
Папка LoggerMaticson - демо проект. В файле program.cs показн пример работы с логерами.

Библиотека поддерживает 3 типа логирования: 
  1) консольное - LoggerConsole
  2) файловое - LoggerFile
  3) в базу данных - LoggerDB (SQLite)
  
У всех логеров одинаковый интерфейс, что позволяет легко заменять реализацию одного варианта логирования на другую. 
Для добавления нового типа логирования необходимо унаследоваться от базоваго класса Logger и реализовать абстрактный класс. 

Для написания использовался сторонний фреймворк Entity Framework Core 6.0 для работы с БД.  
