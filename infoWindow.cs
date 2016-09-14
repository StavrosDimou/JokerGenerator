// ###############################################################################
// #                     Δημιουργήθηκε από τον Σταύρο Δήμου                      #
// #                        GNU - General Public License                         #
// #                                  © 2016                                     #
// ###############################################################################



using System;
using System.Windows.Forms;

namespace Joker
{
    public partial class infoWindow : Form
    {
        public infoWindow()
        {
            InitializeComponent();
            label2.Text = Form1.currentVersion;
            label3.Text = "© 2016 Σταύρος Δήμου";
            label4.Text = "Η παρούσα εφαρμογή αποτελεί Ελεύθερο \nΛογισμικό, και διατίθεται με την άδεια \nGNU - General Public License.";
            pictureBox1.Image = Properties.Resources.JOKERGEN;
        }

        private void infoWindow_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gnu.org/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://stavrosdimou.blogspot.gr/");
        }
    }
}
