﻿namespace CircodeApps3
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblEndereco2 = new System.Windows.Forms.Label();
            this.lblComplemento2 = new System.Windows.Forms.Label();
            this.lblBairro2 = new System.Windows.Forms.Label();
            this.lblCidade2 = new System.Windows.Forms.Label();
            this.lblUf2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(587, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 38);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(587, 115);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(107, 38);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(84, 72);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(223, 20);
            this.txtCep.TabIndex = 2;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCep.Location = new System.Drawing.Point(81, 45);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(134, 24);
            this.lblCep.TabIndex = 3;
            this.lblCep.Text = "Digite o CEP:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndereco.Location = new System.Drawing.Point(81, 177);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(108, 24);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComplemento.Location = new System.Drawing.Point(81, 234);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(146, 24);
            this.lblComplemento.TabIndex = 5;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBairro.Location = new System.Drawing.Point(81, 295);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(71, 24);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCidade.Location = new System.Drawing.Point(81, 350);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(82, 24);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblUf
            // 
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUf.Location = new System.Drawing.Point(81, 398);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(43, 24);
            this.lblUf.TabIndex = 8;
            this.lblUf.Text = "UF:";
            // 
            // lblEndereco2
            // 
            this.lblEndereco2.AutoSize = true;
            this.lblEndereco2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndereco2.Location = new System.Drawing.Point(195, 185);
            this.lblEndereco2.Name = "lblEndereco2";
            this.lblEndereco2.Size = new System.Drawing.Size(0, 13);
            this.lblEndereco2.TabIndex = 9;
            // 
            // lblComplemento2
            // 
            this.lblComplemento2.AutoSize = true;
            this.lblComplemento2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComplemento2.Location = new System.Drawing.Point(233, 242);
            this.lblComplemento2.Name = "lblComplemento2";
            this.lblComplemento2.Size = new System.Drawing.Size(0, 13);
            this.lblComplemento2.TabIndex = 10;
            // 
            // lblBairro2
            // 
            this.lblBairro2.AutoSize = true;
            this.lblBairro2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBairro2.Location = new System.Drawing.Point(158, 303);
            this.lblBairro2.Name = "lblBairro2";
            this.lblBairro2.Size = new System.Drawing.Size(0, 13);
            this.lblBairro2.TabIndex = 11;
            // 
            // lblCidade2
            // 
            this.lblCidade2.AutoSize = true;
            this.lblCidade2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCidade2.Location = new System.Drawing.Point(169, 358);
            this.lblCidade2.Name = "lblCidade2";
            this.lblCidade2.Size = new System.Drawing.Size(0, 13);
            this.lblCidade2.TabIndex = 12;
            // 
            // lblUf2
            // 
            this.lblUf2.AutoSize = true;
            this.lblUf2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUf2.Location = new System.Drawing.Point(130, 406);
            this.lblUf2.Name = "lblUf2";
            this.lblUf2.Size = new System.Drawing.Size(0, 13);
            this.lblUf2.TabIndex = 13;
            // 
            // FormBuscaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUf2);
            this.Controls.Add(this.lblCidade2);
            this.Controls.Add(this.lblBairro2);
            this.Controls.Add(this.lblComplemento2);
            this.Controls.Add(this.lblEndereco2);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormBuscaCep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Cep";
            this.Load += new System.EventHandler(this.FormBuscaCep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblEndereco2;
        private System.Windows.Forms.Label lblComplemento2;
        private System.Windows.Forms.Label lblBairro2;
        private System.Windows.Forms.Label lblCidade2;
        private System.Windows.Forms.Label lblUf2;
    }
}