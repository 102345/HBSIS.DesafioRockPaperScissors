namespace HBSIS.DesafioRockPaperScissors
{
    partial class frmJogo
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblJSONJogo = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnEscolherArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(485, 224);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(577, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblJSONJogo
            // 
            this.lblJSONJogo.AutoSize = true;
            this.lblJSONJogo.Location = new System.Drawing.Point(12, 63);
            this.lblJSONJogo.Name = "lblJSONJogo";
            this.lblJSONJogo.Size = new System.Drawing.Size(100, 13);
            this.lblJSONJogo.TabIndex = 1;
            this.lblJSONJogo.Text = "Arquivo JSON Jogo";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(129, 59);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.ReadOnly = true;
            this.txtArquivo.Size = new System.Drawing.Size(372, 20);
            this.txtArquivo.TabIndex = 2;
            // 
            // btnEscolherArquivo
            // 
            this.btnEscolherArquivo.Location = new System.Drawing.Point(516, 58);
            this.btnEscolherArquivo.Name = "btnEscolherArquivo";
            this.btnEscolherArquivo.Size = new System.Drawing.Size(119, 23);
            this.btnEscolherArquivo.TabIndex = 0;
            this.btnEscolherArquivo.Text = "Selecionar arquivo...";
            this.btnEscolherArquivo.UseVisualStyleBackColor = true;
            this.btnEscolherArquivo.Click += new System.EventHandler(this.btnEscolherArquivo_Click);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 263);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.lblJSONJogo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEscolherArquivo);
            this.Controls.Add(this.btnJogar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo - Rock - Paper - Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblJSONJogo;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnEscolherArquivo;
    }
}

