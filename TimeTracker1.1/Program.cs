using Newtonsoft.Json;

namespace TimeTracker1._1
{
    internal static class Program
    {
        
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class JsonChangeTracker
    {

    }
}