namespace CircoDeApps2
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblCaraCoroa = new System.Windows.Forms.Label();
            this.pbxConversorMoeda = new System.Windows.Forms.PictureBox();
            this.lblConversor = new System.Windows.Forms.Label();
            this.pbxBuscaCep = new System.Windows.Forms.PictureBox();
            this.lblBuscaCep = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.pbxCaraCoroa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversorMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaraCoroa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaraCoroa
            // 
            this.lblCaraCoroa.AutoSize = true;
            this.lblCaraCoroa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaraCoroa.Location = new System.Drawing.Point(112, 246);
            this.lblCaraCoroa.Name = "lblCaraCoroa";
            this.lblCaraCoroa.Size = new System.Drawing.Size(115, 24);
            this.lblCaraCoroa.TabIndex = 0;
            this.lblCaraCoroa.Text = "Cara/Coroa";
            // 
            // pbxConversorMoeda
            // 
            this.pbxConversorMoeda.Image = global::CircoDeApps2.Properties.Resources.moeda;
            this.pbxConversorMoeda.Location = new System.Drawing.Point(357, 12);
            this.pbxConversorMoeda.Name = "pbxConversorMoeda";
            this.pbxConversorMoeda.Size = new System.Drawing.Size(253, 231);
            this.pbxConversorMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConversorMoeda.TabIndex = 3;
            this.pbxConversorMoeda.TabStop = false;
            this.pbxConversorMoeda.Click += new System.EventHandler(this.pbxConversorMoeda_Click);
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(387, 248);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(206, 24);
            this.lblConversor.TabIndex = 2;
            this.lblConversor.Text = "Conversor de Moeda";
            // 
            // pbxBuscaCep
            // 
            this.pbxBuscaCep.Image = global::CircoDeApps2.Properties.Resources.cep;
            this.pbxBuscaCep.Location = new System.Drawing.Point(42, 275);
            this.pbxBuscaCep.Name = "pbxBuscaCep";
            this.pbxBuscaCep.Size = new System.Drawing.Size(253, 231);
            this.pbxBuscaCep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuscaCep.TabIndex = 5;
            this.pbxBuscaCep.TabStop = false;
            this.pbxBuscaCep.Click += new System.EventHandler(this.pbxBuscaCep_Click);
            // 
            // lblBuscaCep
            // 
            this.lblBuscaCep.AutoSize = true;
            this.lblBuscaCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCep.Location = new System.Drawing.Point(112, 509);
            this.lblBuscaCep.Name = "lblBuscaCep";
            this.lblBuscaCep.Size = new System.Drawing.Size(114, 24);
            this.lblBuscaCep.TabIndex = 4;
            this.lblBuscaCep.Text = "Busca CEP";
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::CircoDeApps2.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(357, 275);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(253, 231);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 6;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(461, 509);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(46, 24);
            this.lblSair.TabIndex = 7;
            this.lblSair.Text = "Sair";
            // 
            // pbxCaraCoroa
            // 
            this.pbxCaraCoroa.Image = global::CircoDeApps2.Properties.Resources.logo;
            this.pbxCaraCoroa.Location = new System.Drawing.Point(42, 12);
            this.pbxCaraCoroa.Name = "pbxCaraCoroa";
            this.pbxCaraCoroa.Size = new System.Drawing.Size(253, 231);
            this.pbxCaraCoroa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCaraCoroa.TabIndex = 1;
            this.pbxCaraCoroa.TabStop = false;
            this.pbxCaraCoroa.Click += new System.EventHandler(this.pbxCaraCoroa_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxBuscaCep);
            this.Controls.Add(this.lblBuscaCep);
            this.Controls.Add(this.pbxConversorMoeda);
            this.Controls.Add(this.lblConversor);
            this.Controls.Add(this.pbxCaraCoroa);
            this.Controls.Add(this.lblCaraCoroa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            ((System.ComponentModel.ISupportInitialize)(this.pbxConversorMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaraCoroa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaraCoroa;
        private System.Windows.Forms.PictureBox pbxConversorMoeda;
        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.PictureBox pbxBuscaCep;
        private System.Windows.Forms.Label lblBuscaCep;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.PictureBox pbxCaraCoroa;
    }
}

