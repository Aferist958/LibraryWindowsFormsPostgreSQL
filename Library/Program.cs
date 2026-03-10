using Npgsql;
using dotenv.net;
using Library.Data;


namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try
            {
                DotEnv.Load(options: new DotEnvOptions(
                    envFilePaths: new[] { "../.env" }
                ));
                string host = Environment.GetEnvironmentVariable("HOST");
                int port = int.Parse(Environment.GetEnvironmentVariable("PORT"));
                string database = Environment.GetEnvironmentVariable("DATABASE");
                string username = Environment.GetEnvironmentVariable("USERNAME");
                string password = Environment.GetEnvironmentVariable("PASSWORD");

                EnsureDatabseCreated(host, port, database, username, password);
                using AppDbContext db = new AppDbContext();
                db.Database.EnsureCreated();
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            catch(Exception ex) 
            { 
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        public static void EnsureDatabseCreated(
            string host, int port, string databaseName, string username, string password)
        {
            string connectionString = $"Host={host};Port={port};Database=postgres;Username={username};Password={password}";
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            var checkCommand = new NpgsqlCommand(
            @"SELECT 1
            FROM pg_database
            WHERE datname = @databaseName",
            connection);
            checkCommand.Parameters.AddWithValue("@databaseName", databaseName);
            bool exists = checkCommand.ExecuteScalar() != null;

            if (!exists)
            {
                var createCmd = new NpgsqlCommand($@"
                    CREATE DATABASE ""{databaseName}""
                    ENCODING 'UTF8'
                    LC_COLLATE 'ru_RU.UTF-8'
                    LC_CTYPE 'ru_RU.UTF-8'
                    TEMPLATE template0;",
                    connection);
                createCmd.ExecuteNonQuery();
            }
        }
    }
}