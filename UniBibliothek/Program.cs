using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniBibliothek
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }catch(Exception ex)
            {
                MessageBox.Show("Es ist ein unbehandelteter Fehler aufgetreten\nStarten sie dei Applikation neu", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
            }
        }
    }
}
