namespace AcessoBD_Usuários
{
    partial class Form1
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
            this.bttExit = new System.Windows.Forms.Button();
            this.bttAcessar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMeuNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(197, 221);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(75, 23);
            this.bttExit.TabIndex = 13;
            this.bttExit.Text = "&Sair";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttAcessar
            // 
            this.bttAcessar.Location = new System.Drawing.Point(103, 142);
            this.bttAcessar.Name = "bttAcessar";
            this.bttAcessar.Size = new System.Drawing.Size(75, 23);
            this.bttAcessar.TabIndex = 12;
            this.bttAcessar.Text = "&Acessar";
            this.bttAcessar.UseVisualStyleBackColor = true;
            this.bttAcessar.Click += new System.EventHandler(this.bttAcessar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 11;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(26, 70);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(68, 17);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(169, 20);
            this.txtLogin.TabIndex = 9;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(26, 20);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login:";
            // 
            // lblMeuNome
            // 
            this.lblMeuNome.AutoSize = true;
            this.lblMeuNome.Location = new System.Drawing.Point(12, 231);
            this.lblMeuNome.Name = "lblMeuNome";
            this.lblMeuNome.Size = new System.Drawing.Size(121, 13);
            this.lblMeuNome.TabIndex = 7;
            this.lblMeuNome.Text = "Gustavo Santos Ferreira";
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Button bttAcessar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMeuNome;
    }
}

