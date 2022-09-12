namespace CircodeApps3
{
    partial class FormBuscaCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaCep));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEndereco2 = new System.Windows.Forms.Label();
            this.lblComplemento2 = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro2 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade2 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf2 = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(436, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(203, 70);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(27, 19);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(285, 25);
            this.lblCep.TabIndex = 1;
            this.lblCep.Text = "Digite o CEP(Ex: 11111111)";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(29, 50);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(299, 26);
            this.txtCep.TabIndex = 2;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(436, 137);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(203, 70);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(38, 137);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(104, 25);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblEndereco2
            // 
            this.lblEndereco2.AutoSize = true;
            this.lblEndereco2.Location = new System.Drawing.Point(160, 137);
            this.lblEndereco2.Name = "lblEndereco2";
            this.lblEndereco2.Size = new System.Drawing.Size(0, 20);
            this.lblEndereco2.TabIndex = 5;
            // 
            // lblComplemento2
            // 
            this.lblComplemento2.AutoSize = true;
            this.lblComplemento2.Location = new System.Drawing.Point(203, 187);
            this.lblComplemento2.Name = "lblComplemento2";
            this.lblComplemento2.Size = new System.Drawing.Size(0, 20);
            this.lblComplemento2.TabIndex = 7;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(38, 187);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(145, 25);
            this.lblComplemento.TabIndex = 6;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairro2
            // 
            this.lblBairro2.AutoSize = true;
            this.lblBairro2.Location = new System.Drawing.Point(160, 245);
            this.lblBairro2.Name = "lblBairro2";
            this.lblBairro2.Size = new System.Drawing.Size(0, 20);
            this.lblBairro2.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(38, 245);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(69, 25);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade2
            // 
            this.lblCidade2.AutoSize = true;
            this.lblCidade2.Location = new System.Drawing.Point(160, 304);
            this.lblCidade2.Name = "lblCidade2";
            this.lblCidade2.Size = new System.Drawing.Size(0, 20);
            this.lblCidade2.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(38, 304);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(81, 25);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            // 
            // lblUf2
            // 
            this.lblUf2.AutoSize = true;
            this.lblUf2.Location = new System.Drawing.Point(151, 357);
            this.lblUf2.Name = "lblUf2";
            this.lblUf2.Size = new System.Drawing.Size(0, 20);
            this.lblUf2.TabIndex = 13;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(37, 357);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(40, 25);
            this.lblUf.TabIndex = 12;
            this.lblUf.Text = "UF";
            // 
            // FormBuscaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.lblUf2);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade2);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro2);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento2);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblEndereco2);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscaCep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca CEP";
            this.Load += new System.EventHandler(this.FormBuscaCep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEndereco2;
        private System.Windows.Forms.Label lblComplemento2;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro2;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade2;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf2;
        private System.Windows.Forms.Label lblUf;
    }
}