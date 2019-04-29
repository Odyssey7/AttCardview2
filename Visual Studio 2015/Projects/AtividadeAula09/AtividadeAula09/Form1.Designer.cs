namespace AtividadeAula09
{
    partial class frmPlace
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
            this.lstPlace = new System.Windows.Forms.ListBox();
            this.picPlace = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // bttExit
            // 
            this.bttExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttExit.Location = new System.Drawing.Point(70, 314);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(75, 23);
            this.bttExit.TabIndex = 0;
            this.bttExit.Text = "&Sair";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // lstPlace
            // 
            this.lstPlace.BackColor = System.Drawing.SystemColors.Window;
            this.lstPlace.FormattingEnabled = true;
            this.lstPlace.Items.AddRange(new object[] {
            "Brasil",
            "Estados Unidos",
            "Egito",
            "Índia",
            "Inglaterra",
            "China",
            "Paris"});
            this.lstPlace.Location = new System.Drawing.Point(13, 12);
            this.lstPlace.Name = "lstPlace";
            this.lstPlace.Size = new System.Drawing.Size(200, 277);
            this.lstPlace.TabIndex = 3;
            this.lstPlace.SelectedIndexChanged += new System.EventHandler(this.lstPlace_SelectedIndexChanged);
            // 
            // picPlace
            // 
            this.picPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlace.Location = new System.Drawing.Point(231, 12);
            this.picPlace.Name = "picPlace";
            this.picPlace.Size = new System.Drawing.Size(390, 325);
            this.picPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlace.TabIndex = 2;
            this.picPlace.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(228, 355);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Gustavo Santos Ferreira";
            // 
            // frmPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(633, 377);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstPlace);
            this.Controls.Add(this.picPlace);
            this.Controls.Add(this.bttExit);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmPlace";
            this.Text = "O Programa Localidades";
            ((System.ComponentModel.ISupportInitialize)(this.picPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.PictureBox picPlace;
        private System.Windows.Forms.ListBox lstPlace;
        private System.Windows.Forms.Label lblName;
    }
}

