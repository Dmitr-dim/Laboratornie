using System;
using System.Windows.Forms;

namespace ProductManager
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalendarForm());
        }
    }
}