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

namespace CircodeApps3
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            //imagem de inicialização. 3 seg de duração
            InitializeComponent();
            FormSplash splash = new FormSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void pbxCaraCoroa_Click(object sender, EventArgs e)
        {
            FormCaraCoroa caraCoroa = new FormCaraCoroa();
            caraCoroa.Show();
        }

        private void pbxConversorMoeda_Click(object sender, EventArgs e)
        {
            FormConversorMoeda moeda = new FormConversorMoeda();
            moeda.Show();
        }

        private void pbxBuscaCep_Click(object sender, EventArgs e)
        {
            FormBuscaCep buscaCep = new FormBuscaCep();
            buscaCep.Show();
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
