namespace CircodeApps3
{
    partial class FormConversorMoeda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversorMoeda));
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.lblLibra2 = new System.Windows.Forms.Label();
            this.lblLibra = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblIene2 = new System.Windows.Forms.Label();
            this.lblIene = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(426, 25);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(149, 70);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(29, 24);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(197, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Digite um valor(R$)";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(24, 52);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(219, 26);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(426, 120);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(149, 70);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(29, 145);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(91, 25);
            this.lblDolar.TabIndex = 4;
            this.lblDolar.Text = "Dólar($)";
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.Location = new System.Drawing.Point(154, 145);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(0, 20);
            this.lblDolar2.TabIndex = 5;
            // 
            // lblLibra2
            // 
            this.lblLibra2.AutoSize = true;
            this.lblLibra2.Location = new System.Drawing.Point(154, 197);
            this.lblLibra2.Name = "lblLibra2";
            this.lblLibra2.Size = new System.Drawing.Size(0, 20);
            this.lblLibra2.TabIndex = 7;
            // 
            // lblLibra
            // 
            this.lblLibra.AutoSize = true;
            this.lblLibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibra.Location = new System.Drawing.Point(29, 197);
            this.lblLibra.Name = "lblLibra";
            this.lblLibra.Size = new System.Drawing.Size(88, 25);
            this.lblLibra.TabIndex = 6;
            this.lblLibra.Text = "Libra(£)";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(154, 252);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(0, 20);
            this.lblEuro2.TabIndex = 9;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(29, 252);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(85, 25);
            this.lblEuro.TabIndex = 8;
            this.lblEuro.Text = "Euro(€)";
            // 
            // lblIene2
            // 
            this.lblIene2.AutoSize = true;
            this.lblIene2.Location = new System.Drawing.Point(154, 305);
            this.lblIene2.Name = "lblIene2";
            this.lblIene2.Size = new System.Drawing.Size(0, 20);
            this.lblIene2.TabIndex = 11;
            // 
            // lblIene
            // 
            this.lblIene.AutoSize = true;
            this.lblIene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIene.Location = new System.Drawing.Point(29, 305);
            this.lblIene.Name = "lblIene";
            this.lblIene.Size = new System.Drawing.Size(82, 25);
            this.lblIene.TabIndex = 10;
            this.lblIene.Text = "Iene(¥)";
            // 
            // FormConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 353);
            this.Controls.Add(this.lblIene2);
            this.Controls.Add(this.lblIene);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblLibra2);
            this.Controls.Add(this.lblLibra);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnConverter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversorMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Moeda";
            this.Load += new System.EventHandler(this.FormConversorMoeda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblDolar2;
        private System.Windows.Forms.Label lblLibra2;
        private System.Windows.Forms.Label lblLibra;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblIene2;
        private System.Windows.Forms.Label lblIene;
    }
}