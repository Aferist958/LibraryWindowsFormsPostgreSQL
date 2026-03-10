# LibraryWindowsFormsPostgreSQL

Описание

Декстоп приложение для контроля и учёта книг

Установка

Шаги:

1. Клонируем репозиторий
    ```
   git clone https://github.com/Aferist958/LibraryWindowsFormsPostgreSQL.git
   ```
2. Вводим секреты
     ```
    cd .\LibraryWindowsFormsPostgreSQL\
    ```
     Запускаем configure.bat, после чего вводим наши данные в .env
   
3. Запуск

    Для запуска должен быть включён PostgreSQ Server
    ```
     cd ./Library/
   dotnet run
   ```
    Если приложение не запустилось после этого, то переходим в bin\Debug\net10.0-windows\ и запускаем Library.exe
