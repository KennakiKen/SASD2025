namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  By Tinnapop ID 139
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            ApplicationConfiguration.Initialize();
            // Application.Run(new KitchenForm()); //Åº·Ôé§
            if (args.Length > 0 && args[0].ToLower() == "-k")
                Application.Run(new kitchenFrom());
            else
                Application.Run(new WaiterFrom());
        }
    }
}