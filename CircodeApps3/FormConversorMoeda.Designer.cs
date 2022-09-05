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
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblLibra = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblIene = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblLibra2 = new System.Windows.Forms.Label();
            this.lblIene2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.Fuchsia;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(573, 47);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(146, 64);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.DarkBlue;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(53, 47);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(194, 24);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Digite um valor(R$):";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(57, 74);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(229, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Crimson;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(573, 134);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(146, 64);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.BackColor = System.Drawing.Color.Violet;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(101, 238);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(83, 20);
            this.lblDolar.TabIndex = 5;
            this.lblDolar.Text = "Dollar($):";
            // 
            // lblLibra
            // 
            this.lblLibra.AutoSize = true;
            this.lblLibra.BackColor = System.Drawing.Color.MediumOrchid;
            this.lblLibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibra.Location = new System.Drawing.Point(102, 269);
            this.lblLibra.Name = "lblLibra";
            this.lblLibra.Size = new System.Drawing.Size(76, 20);
            this.lblLibra.TabIndex = 6;
            this.lblLibra.Text = "Libra(£):";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.BackColor = System.Drawing.Color.DarkViolet;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(101, 304);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(74, 20);
            this.lblEuro.TabIndex = 7;
            this.lblEuro.Text = "Euro(€):";
            // 
            // lblIene
            // 
            this.lblIene.AutoSize = true;
            this.lblIene.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblIene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIene.Location = new System.Drawing.Point(101, 337);
            this.lblIene.Name = "lblIene";
            this.lblIene.Size = new System.Drawing.Size(72, 20);
            this.lblIene.TabIndex = 8;
            this.lblIene.Text = "Iene(¥):";
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.Location = new System.Drawing.Point(193, 245);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(0, 13);
            this.lblDolar2.TabIndex = 9;
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(193, 311);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(0, 13);
            this.lblEuro2.TabIndex = 10;
            // 
            // lblLibra2
            // 
            this.lblLibra2.AutoSize = true;
            this.lblLibra2.Location = new System.Drawing.Point(193, 276);
            this.lblLibra2.Name = "lblLibra2";
            this.lblLibra2.Size = new System.Drawing.Size(0, 13);
            this.lblLibra2.TabIndex = 11;
            // 
            // lblIene2
            // 
            this.lblIene2.AutoSize = true;
            this.lblIene2.Location = new System.Drawing.Point(193, 344);
            this.lblIene2.Name = "lblIene2";
            this.lblIene2.Size = new System.Drawing.Size(0, 13);
            this.lblIene2.TabIndex = 12;
            // 
            // FormConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIene2);
            this.Controls.Add(this.lblLibra2);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblIene);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblLibra);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnConverter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private System.Windows.Forms.Label lblLibra;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblIene;
        private System.Windows.Forms.Label lblDolar2;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblLibra2;
        private System.Windows.Forms.Label lblIene2;
    }
}