// ###############################################################################
// #                     Δημιουργήθηκε από τον Σταύρο Δήμου                      #
// #                        GNU - General Public License                         #
// #                                  © 2016                                     #
// ###############################################################################


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Joker
{
    public partial class Form1 : Form
    {
        public static string currentVersion = "0.0.1.0";
        DateTime rightNow;

        public Form1()
        {
            InitializeComponent();
            rightNow = DateTime.Now;
            label1.Text = string.Format("{0:dd/MM/yy     H:mm}", rightNow);  //timeNow;
        }

        private void NeoDeltioButton_Click(object sender, EventArgs e)
        {
            this.NeoDeltio();
        }

        #region Neo Deltio ()
        private void NeoDeltio()
        {
            Random RanGen = new Random();
            List<byte> result = new List<byte>();
            for (byte i = 0; i < 5; i++)
            {
                byte curValue = (byte)RanGen.Next(1, 45);
                while (result.Exists(value => value == curValue))
                {
                    curValue = (byte)RanGen.Next(1, 45);
                }
                result.Add(curValue);
            }

            byte arithmosJoker = (byte)RanGen.Next(1, 20);

            result.Sort();

            ProtosArithmos.Text = Convert.ToString(result[0]);
            DefterosArithmos.Text = Convert.ToString(result[1]);
            TritosArithmos.Text = Convert.ToString(result[2]);
            TetartosArithmos.Text = Convert.ToString(result[3]);
            PemptosArithmos.Text = Convert.ToString(result[4]);
            JokerArithmos.Text = Convert.ToString(arithmosJoker);
        }
        #endregion
        
        private void πληροφορίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoWindow newWindow = new infoWindow();
            newWindow.Show();
        }
        
        private void InfoButton_Click(object sender, EventArgs e)
        {
            infoWindow newWindow = new infoWindow();
            newWindow.Show();
        }
    }
}
