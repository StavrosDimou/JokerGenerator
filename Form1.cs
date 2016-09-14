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
        public static string currentVersion = "0.0.1.2";
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = string.Format("{0:dd/MM/yy     H:mm}", DateTime.Now);  //timeNow;
        }

        private void NeoDeltioButton_Click(object sender, EventArgs e)
        {
            #region
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
            
            result.Sort();

            ProtosArithmos.Text = Convert.ToString(result[0]);
            DefterosArithmos.Text = Convert.ToString(result[1]);
            TritosArithmos.Text = Convert.ToString(result[2]);
            TetartosArithmos.Text = Convert.ToString(result[3]);
            PemptosArithmos.Text = Convert.ToString(result[4]);
            JokerArithmos.Text = Convert.ToString(RanGen.Next(1,20));
            #endregion
        }
        private void πληροφορίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewInfoWindow();
        }
        
        private void InfoButton_Click(object sender, EventArgs e)
        {
            ShowNewInfoWindow();
        }
        private void ShowNewInfoWindow()
        {
            infoWindow newWindow = new infoWindow();
            newWindow.Show();
        }
    }
}
