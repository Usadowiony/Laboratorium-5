using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MojeCentrumPowiadomien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void NaszDelegata(string wiadomosc);
        NaszDelegata naszaZmiennaDelegaty;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxZawiadomienie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (naszaZmiennaDelegaty != null)
            {
                naszaZmiennaDelegaty(textBoxZawiadomienie.Text);
            }
        }

        void DodanieInforamcjiDoOkienkaPolicji(String dane)
        {
            if (checkBoxPolicja.Checked)
            {
                textBoxPolicja.Text += dane + "\r\n";
            }
        }
        void DodanieInforamcjiDoOkienkaStrazyPozarnej(String dane)
        {
            if (checkBox3StrazPozarna.Checked)
            {
                textBoxStrazPozarna.Text += dane + "\r\n";
            }
        }
        void DodanieInforamcjiDoOkienkaPogotowiaMedycznego(String dane)
        {
            if (checkBoxPogotowieMedyczne.Checked)
            {
                textBoxPogotowieMedyczne.Text += dane + "\r\n";
            }
        }

        private void checkBoxPolicja_CheckedChanged(object sender, EventArgs e)
        {
            naszaZmiennaDelegaty = DodanieInforamcjiDoOkienkaPolicji;
        }

        private void checkBox3StrazPozarna_CheckedChanged(object sender, EventArgs e)
        {
            naszaZmiennaDelegaty = DodanieInforamcjiDoOkienkaStrazyPozarnej;
        }

        private void checkBoxPogotowieMedyczne_CheckedChanged(object sender, EventArgs e)
        {
            naszaZmiennaDelegaty = DodanieInforamcjiDoOkienkaPogotowiaMedycznego;
        }

        private void clearPolicja_Click(object sender, EventArgs e)
        {
            textBoxPolicja.Text = "";
        }

        private void clearStrazPozarna_Click(object sender, EventArgs e)
        {
            textBoxStrazPozarna.Text = "";
        }

        private void clearPogotowieRatownicze_Click(object sender, EventArgs e)
        {
            textBoxPogotowieMedyczne.Text = "";
        }
    }
}
