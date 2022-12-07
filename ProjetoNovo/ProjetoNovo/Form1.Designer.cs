namespace ProjetoNovo
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
            this.botao = new System.Windows.Forms.Button();
            this.primeiraMensagem = new System.Windows.Forms.Label();
            this.botao2 = new System.Windows.Forms.Button();
            this.segundaMensgem = new System.Windows.Forms.Label();
            this.botao3 = new System.Windows.Forms.Button();
            this.terceiraMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao
            // 
            this.botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao.ForeColor = System.Drawing.Color.Black;
            this.botao.Location = new System.Drawing.Point(279, 12);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(340, 141);
            this.botao.TabIndex = 0;
            this.botao.Text = "Clique Aqui!";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // primeiraMensagem
            // 
            this.primeiraMensagem.AutoSize = true;
            this.primeiraMensagem.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraMensagem.Location = new System.Drawing.Point(275, 165);
            this.primeiraMensagem.Name = "primeiraMensagem";
            this.primeiraMensagem.Size = new System.Drawing.Size(132, 24);
            this.primeiraMensagem.TabIndex = 1;
            this.primeiraMensagem.Text = "Mensagem1";
            this.primeiraMensagem.Click += new System.EventHandler(this.primeiraMensagem_Click);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botao2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botao2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.ForeColor = System.Drawing.Color.White;
            this.botao2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao2.Location = new System.Drawing.Point(12, 237);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(340, 141);
            this.botao2.TabIndex = 2;
            this.botao2.Text = "Clique Aqui!";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // segundaMensgem
            // 
            this.segundaMensgem.AutoSize = true;
            this.segundaMensgem.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundaMensgem.Location = new System.Drawing.Point(110, 391);
            this.segundaMensgem.Name = "segundaMensgem";
            this.segundaMensgem.Size = new System.Drawing.Size(132, 24);
            this.segundaMensgem.TabIndex = 3;
            this.segundaMensgem.Text = "Mensagem2";
            this.segundaMensgem.Click += new System.EventHandler(this.segundaMensgem_Click);
            // 
            // botao3
            // 
            this.botao3.BackColor = System.Drawing.Color.Aqua;
            this.botao3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao3.Location = new System.Drawing.Point(452, 240);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(340, 141);
            this.botao3.TabIndex = 4;
            this.botao3.Text = "Clique Aqui DENOVO!";
            this.botao3.UseVisualStyleBackColor = false;
            this.botao3.Click += new System.EventHandler(this.botao3_Click);
            // 
            // terceiraMensagem
            // 
            this.terceiraMensagem.AutoSize = true;
            this.terceiraMensagem.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terceiraMensagem.Location = new System.Drawing.Point(507, 391);
            this.terceiraMensagem.Name = "terceiraMensagem";
            this.terceiraMensagem.Size = new System.Drawing.Size(227, 24);
            this.terceiraMensagem.TabIndex = 5;
            this.terceiraMensagem.Text = "CHEGAAAAAAAAA";
            this.terceiraMensagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(899, 666);
            this.Controls.Add(this.terceiraMensagem);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.segundaMensgem);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.primeiraMensagem);
            this.Controls.Add(this.botao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label primeiraMensagem;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label segundaMensgem;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Label terceiraMensagem;
    }
}

