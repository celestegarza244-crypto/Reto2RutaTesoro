namespace Reto2RutaTesoro
{
    /// <summary>
    /// Application entry point.
    /// </summary>
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmRutaTesoro());
        }
    }
}
