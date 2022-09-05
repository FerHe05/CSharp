using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps3
{
    public partial class FormCaraCoroa : Form
    {
        public FormCaraCoroa()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sorteio = Convert.ToInt32(rnd.Next(2));
            switch (sorteio)
            {
                case 0:
                    pbxResultado.Image = Properties.Resources.moeda_cara;
                    lblResultado.Text = "Cara";
                    break;
                case 1:
                    pbxResultado.Image = Properties.Resources.moeda_coroa;
                    lblResultado.Text = "Coroa";
                    break;
            }
        }
    }
}
