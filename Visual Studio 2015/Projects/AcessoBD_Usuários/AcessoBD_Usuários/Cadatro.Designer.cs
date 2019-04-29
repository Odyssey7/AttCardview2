namespace AcessoBD_Usuários
{
    partial class frmCadatro
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
            this.lblMeuNome = new System.Windows.Forms.Label();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.bttCadastrar = new System.Windows.Forms.Button();
            this.bttFechar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMeuNome
            // 
            this.lblMeuNome.AutoSize = true;
            this.lblMeuNome.Location = new System.Drawing.Point(12, 239);
            this.lblMeuNome.Name = "lblMeuNome";
            this.lblMeuNome.Size = new System.Drawing.Size(121, 13);
            this.lblMeuNome.TabIndex = 1;
            this.lblMeuNome.Text = "Gustavo Santos Ferreira";
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.Location = new System.Drawing.Point(96, 36);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(88, 20);
            this.lblBoasVindas.TabIndex = 2;
            this.lblBoasVindas.Text = "Bem-vindo!";
            // 
            // bttCadastrar
            // 
            this.bttCadastrar.Location = new System.Drawing.Point(88, 108);
            this.bttCadastrar.Name = "bttCadastrar";
            this.bttCadastrar.Size = new System.Drawing.Size(106, 42);
            this.bttCadastrar.TabIndex = 3;
            this.bttCadastrar.Text = "&Realize o seu cadastro!";
            this.bttCadastrar.UseVisualStyleBackColor = true;
            this.bttCadastrar.Click += new System.EventHandler(this.bttCadastrar_Click);
            // 
            // bttFechar1
            // 
            this.bttFechar1.Location = new System.Drawing.Point(197, 229);
            this.bttFechar1.Name = "bttFechar1";
            this.bttFechar1.Size = new System.Drawing.Size(75, 23);
            this.bttFechar1.TabIndex = 7;
            this.bttFechar1.Text = "&Fechar";
            this.bttFechar1.UseVisualStyleBackColor = true;
            this.bttFechar1.Click += new System.EventHandler(this.bttFechar1_Click);
            // 
            // frmCadatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttFechar1);
            this.Controls.Add(this.bttCadastrar);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.lblMeuNome);
            this.Name = "frmCadatro";
            this.Text = "Cadatro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeuNome;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Button bttCadastrar;
        private System.Windows.Forms.Button bttFechar1;
    }
}