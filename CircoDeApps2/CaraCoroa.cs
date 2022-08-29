using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircoDeApps2
{
    public partial class CaraCoroa : Form
    {
        public CaraCoroa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sorteio = Convert.ToInt32(rnd.Next(2));
            /*switch (sorteio) {
                case 0:
                    pbxResultado.image = Properties.Resources.moeda_cara;
                    lblResultado.Text = "Cara";
                    break;
                case 1:
                    pbxResultado.Image = Properties.Resources.moeda_coroa;
                    lblResultado.Text = "Coroa";
                    break;
            }*/
        }
    }
}
