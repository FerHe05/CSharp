using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       

        public double n1  { get; set; }
    public double n2 { get; set; }
        public double resultado { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void botaofechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaomais_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(texto1.Text);
            n2 = Convert.ToDouble(texto2.Text);
            resultado = n1 + n2;
            resultado2.Text = Convert.ToString(Math.Round(resultado,2));
            texto1.Text = "";
            texto2.Text = "";

        }

        private void botaomenos_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(texto1.Text);
            n2 = Convert.ToDouble(texto2.Text);
            resultado = n1 - n2;
            resultado2.Text = Convert.ToString(Math.Round(resultado, 2));
            texto1.Text = "";
            texto2.Text = "";

        }

        private void botaovezes_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(texto1.Text);
            n2 = Convert.ToDouble(texto2.Text);
            resultado = n1 * n2;
            resultado2.Text = Convert.ToString(Math.Round(resultado, 2));
            texto1.Text = "";
            texto2.Text = "";
        }

        private void botaodivisao_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(texto1.Text);
            n2 = Convert.ToDouble(texto2.Text);
            resultado = n1 / n2;
            resultado2.Text = Convert.ToString(Math.Round(resultado, 2));
            texto1.Text = "";
            texto2.Text = "";
        }
    }
}
