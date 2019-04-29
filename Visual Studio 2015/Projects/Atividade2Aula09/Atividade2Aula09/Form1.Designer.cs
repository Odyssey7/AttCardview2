namespace Atividade2Aula09
{
    partial class frmNota10
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
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblPergunta.Location = new System.Drawing.Point(39, 25);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(500, 181);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "Você quer ganhar uma nota 10,0 nesta matéria?";
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.LawnGreen;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnYes.Location = new System.Drawing.Point(113, 245);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "SIM";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            this.btnYes.MouseEnter += new System.EventHandler(this.btnYes_MouseEnter);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.LightCoral;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNo.Location = new System.Drawing.Point(387, 245);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NÃO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.btnNo.MouseEnter += new System.EventHandler(this.btnNo_MouseEnter);
            this.btnNo.MouseLeave += new System.EventHandler(this.btnNo_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(234, 339);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Gustavo Santos Ferreira";
            // 
            // frmNota10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblPergunta);
            this.Name = "frmNota10";
            this.Text = "O Programa Nota 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblName;
    }
}

