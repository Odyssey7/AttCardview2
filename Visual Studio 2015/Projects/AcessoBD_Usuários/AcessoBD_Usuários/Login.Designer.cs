namespace AcessoBD_Usuários
{
    partial class frmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttAcessar = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMeuNome
            // 
            this.lblMeuNome.AutoSize = true;
            this.lblMeuNome.Location = new System.Drawing.Point(12, 239);
            this.lblMeuNome.Name = "lblMeuNome";
            this.lblMeuNome.Size = new System.Drawing.Size(121, 13);
            this.lblMeuNome.TabIndex = 0;
            this.lblMeuNome.Text = "Gustavo Santos Ferreira";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(26, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(68, 25);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(169, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(26, 78);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 4;
            // 
            // bttAcessar
            // 
            this.bttAcessar.Location = new System.Drawing.Point(103, 150);
            this.bttAcessar.Name = "bttAcessar";
            this.bttAcessar.Size = new System.Drawing.Size(75, 23);
            this.bttAcessar.TabIndex = 5;
            this.bttAcessar.Text = "&Acessar";
            this.bttAcessar.UseVisualStyleBackColor = true;
            this.bttAcessar.Click += new System.EventHandler(this.bttAcessar_Click);
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(197, 229);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(75, 23);
            this.bttExit.TabIndex = 6;
            this.bttExit.Text = "&Sair";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttAcessar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblMeuNome);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeuNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttAcessar;
        private System.Windows.Forms.Button bttExit;
    }
}