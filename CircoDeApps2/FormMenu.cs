using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CircoDeApps2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            FormSplash splash = new FormSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void pbxCaraCoroa_Click(object sender, EventArgs e)
        {
            CaraCoroa caraCoroa = new CaraCoroa();
            caraCoroa.Show();
        }

        private void pbxConversorMoeda_Click(object sender, EventArgs e)
        {
            ConversorMoeda moeda = new ConversorMoeda();
            moeda.Show();
        }

        private void pbxBuscaCep_Click(object sender, EventArgs e)
        {
            BuscaCep  buscacep = new BuscaCep();
            buscacep.Show();
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
