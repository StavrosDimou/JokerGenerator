// ###############################################################################
// #                     Δημιουργήθηκε από τον Σταύρο Δήμου                      #
// #                        GNU - General Public License                         #
// #                                  © 2016                                     #
// ###############################################################################

using System;
using System.Windows.Forms;

namespace Joker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
