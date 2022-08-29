namespace WindowsFormsApp1
{
    partial class Form1
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
            this.botaofechar = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.TextBox();
            this.texto2 = new System.Windows.Forms.TextBox();
            this.botaomais = new System.Windows.Forms.Button();
            this.botaodivisao = new System.Windows.Forms.Button();
            this.botaomenos = new System.Windows.Forms.Button();
            this.botaovezes = new System.Windows.Forms.Button();
            this.resultado1 = new System.Windows.Forms.Label();
            this.resultado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaofechar
            // 
            this.botaofechar.BackColor = System.Drawing.Color.Red;
            this.botaofechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaofechar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.botaofechar.Location = new System.Drawing.Point(564, 294);
            this.botaofechar.Name = "botaofechar";
            this.botaofechar.Size = new System.Drawing.Size(115, 47);
            this.botaofechar.TabIndex = 0;
            this.botaofechar.Text = "Fechar";
            this.botaofechar.UseVisualStyleBackColor = false;
            this.botaofechar.Click += new System.EventHandler(this.botaofechar_Click);
            // 
            // numero1
            // 
            this.numero1.AutoSize = true;
            this.numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(69, 62);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(128, 16);
            this.numero1.TabIndex = 1;
            this.numero1.Text = "Primeiro Número:";
            // 
            // numero2
            // 
            this.numero2.AutoSize = true;
            this.numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.Location = new System.Drawing.Point(240, 62);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(132, 16);
            this.numero2.TabIndex = 2;
            this.numero2.Text = "Segundo Número:";
            // 
            // texto1
            // 
            this.texto1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.texto1.Location = new System.Drawing.Point(72, 91);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(125, 20);
            this.texto1.TabIndex = 3;
            // 
            // texto2
            // 
            this.texto2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.texto2.Location = new System.Drawing.Point(243, 91);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(129, 20);
            this.texto2.TabIndex = 4;
            // 
            // botaomais
            // 
            this.botaomais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botaomais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaomais.Location = new System.Drawing.Point(564, 132);
            this.botaomais.Name = "botaomais";
            this.botaomais.Size = new System.Drawing.Size(53, 47);
            this.botaomais.TabIndex = 5;
            this.botaomais.Text = "+";
            this.botaomais.UseVisualStyleBackColor = false;
            this.botaomais.Click += new System.EventHandler(this.botaomais_Click);
            // 
            // botaodivisao
            // 
            this.botaodivisao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botaodivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaodivisao.Location = new System.Drawing.Point(623, 183);
            this.botaodivisao.Name = "botaodivisao";
            this.botaodivisao.Size = new System.Drawing.Size(54, 50);
            this.botaodivisao.TabIndex = 6;
            this.botaodivisao.Text = "/";
            this.botaodivisao.UseVisualStyleBackColor = false;
            this.botaodivisao.Click += new System.EventHandler(this.botaodivisao_Click);
            // 
            // botaomenos
            // 
            this.botaomenos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botaomenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaomenos.Location = new System.Drawing.Point(623, 131);
            this.botaomenos.Name = "botaomenos";
            this.botaomenos.Size = new System.Drawing.Size(54, 48);
            this.botaomenos.TabIndex = 7;
            this.botaomenos.Text = "-";
            this.botaomenos.UseVisualStyleBackColor = false;
            this.botaomenos.Click += new System.EventHandler(this.botaomenos_Click);
            // 
            // botaovezes
            // 
            this.botaovezes.AllowDrop = true;
            this.botaovezes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botaovezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaovezes.Location = new System.Drawing.Point(564, 183);
            this.botaovezes.Name = "botaovezes";
            this.botaovezes.Size = new System.Drawing.Size(53, 50);
            this.botaovezes.TabIndex = 8;
            this.botaovezes.Text = "X";
            this.botaovezes.UseVisualStyleBackColor = false;
            this.botaovezes.Click += new System.EventHandler(this.botaovezes_Click);
            // 
            // resultado1
            // 
            this.resultado1.AutoSize = true;
            this.resultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado1.Location = new System.Drawing.Point(69, 325);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(83, 16);
            this.resultado1.TabIndex = 9;
            this.resultado1.Text = "Resultado:";
            // 
            // resultado2
            // 
            this.resultado2.AutoSize = true;
            this.resultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado2.Location = new System.Drawing.Point(158, 325);
            this.resultado2.Name = "resultado2";
            this.resultado2.Size = new System.Drawing.Size(53, 16);
            this.resultado2.TabIndex = 10;
            this.resultado2.Text = "XXXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.botaovezes);
            this.Controls.Add(this.botaomenos);
            this.Controls.Add(this.botaodivisao);
            this.Controls.Add(this.botaomais);
            this.Controls.Add(this.texto2);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.botaofechar);
            this.Name = "Form1";
            this.Text = "k";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaofechar;
        private System.Windows.Forms.Label numero1;
        private System.Windows.Forms.Label numero2;
        private System.Windows.Forms.TextBox texto1;
        private System.Windows.Forms.TextBox texto2;
        private System.Windows.Forms.Button botaomais;
        private System.Windows.Forms.Button botaodivisao;
        private System.Windows.Forms.Button botaomenos;
        private System.Windows.Forms.Button botaovezes;
        private System.Windows.Forms.Label resultado1;
        private System.Windows.Forms.Label resultado2;
    }
}

