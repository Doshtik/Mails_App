using MailsApp.Forms;

namespace MailsApp
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
            ApplicationConfiguration.Initialize();
            Application.Run(new FormAuthorization());
        }

        #region Методы работы с конфигом
        public static void CreateConfigFile()
        {
            using (StreamWriter sw = File.CreateText("config.txt"))
            {
                sw.WriteLine("phone_number = ");
                sw.WriteLine("password = ");
            }
        }
        public static T GetValueFromConfigFile<T>(string field)
        {
            using (var sr = new StreamReader("config.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine()?.Trim();

                    if (string.IsNullOrEmpty(line))
                        continue;

                    string[] parts = line.Split(" = ");

                    if (typeof(T) != typeof(string))
                    {
                        if (parts[0].Equals(field, StringComparison.OrdinalIgnoreCase))
                        {
                            return (T)Convert.ChangeType(parts[1], typeof(T));
                        }
                    }
                    else
                    {
                        if (parts[0].Equals(field, StringComparison.OrdinalIgnoreCase))
                        {
                            return (T)(object)parts[1];
                        }
                    }
                }
            }
            return default(T);
        }
        public static void SetValueToConfigFile<T>(string field, T value)
        {
            string filename = "config.txt";
            using (var sr = new StreamReader(filename))
            using (var sw = new StreamWriter(filename + ".tmp", false))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        if (sr.EndOfStream)
                        {
                            if (line.Split(" = ")[0].Equals(field, StringComparison.OrdinalIgnoreCase))
                            {
                                sw.Write(field + " = " + value);
                            }
                            else
                            {
                                sw.Write(line);
                            }
                        }
                        else
                        {
                            if (line.Split(" = ")[0].Equals(field, StringComparison.OrdinalIgnoreCase))
                            {
                                sw.WriteLine(field + " = " + value);
                            }
                            else
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
            }
            File.Delete(filename);
            File.Move(filename + ".tmp", filename);
        }
        #endregion
    }
}