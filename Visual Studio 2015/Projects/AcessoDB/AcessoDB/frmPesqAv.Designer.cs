namespace AcessoDB
{
    partial class frmPesqAv
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
            this.bttFechar = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttPesqAv = new System.Windows.Forms.Button();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.rbtUF = new System.Windows.Forms.RadioButton();
            this.rbtEstado = new System.Windows.Forms.RadioButton();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.lblPalavraChave = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // bttFechar
            // 
            this.bttFechar.Image = global::AcessoDB.Properties.Resources.exit;
            this.bttFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttFechar.Location = new System.Drawing.Point(541, 18);
            this.bttFechar.Name = "bttFechar";
            this.bttFechar.Size = new System.Drawing.Size(75, 70);
            this.bttFechar.TabIndex = 1;
            this.bttFechar.Text = "Fechar";
            this.bttFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttFechar.UseVisualStyleBackColor = true;
            this.bttFechar.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Image = global::AcessoDB.Properties.Resources.clear;
            this.bttLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttLimpar.Location = new System.Drawing.Point(460, 18);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 70);
            this.bttLimpar.TabIndex = 14;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // bttPesqAv
            // 
            this.bttPesqAv.Image = global::AcessoDB.Properties.Resources.search;
            this.bttPesqAv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttPesqAv.Location = new System.Drawing.Point(379, 18);
            this.bttPesqAv.Name = "bttPesqAv";
            this.bttPesqAv.Size = new System.Drawing.Size(75, 70);
            this.bttPesqAv.TabIndex = 13;
            this.bttPesqAv.Text = "Pesquisar";
            this.bttPesqAv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttPesqAv.UseVisualStyleBackColor = true;
            this.bttPesqAv.Click += new System.EventHandler(this.bttPesqAv_Click);
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbtUF);
            this.gbxTipo.Controls.Add(this.rbtEstado);
            this.gbxTipo.Controls.Add(this.rbtCodigo);
            this.gbxTipo.Location = new System.Drawing.Point(12, 12);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(361, 52);
            this.gbxTipo.TabIndex = 15;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Pesquisar por:";
            // 
            // rbtUF
            // 
            this.rbtUF.AutoSize = true;
            this.rbtUF.Location = new System.Drawing.Point(306, 19);
            this.rbtUF.Name = "rbtUF";
            this.rbtUF.Size = new System.Drawing.Size(39, 17);
            this.rbtUF.TabIndex = 2;
            this.rbtUF.Text = "UF";
            this.rbtUF.UseVisualStyleBackColor = true;
            // 
            // rbtEstado
            // 
            this.rbtEstado.AutoSize = true;
            this.rbtEstado.Location = new System.Drawing.Point(157, 19);
            this.rbtEstado.Name = "rbtEstado";
            this.rbtEstado.Size = new System.Drawing.Size(58, 17);
            this.rbtEstado.TabIndex = 1;
            this.rbtEstado.Text = "Estado";
            this.rbtEstado.UseVisualStyleBackColor = true;
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Checked = true;
            this.rbtCodigo.Location = new System.Drawing.Point(6, 19);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtCodigo.TabIndex = 0;
            this.rbtCodigo.TabStop = true;
            this.rbtCodigo.Text = "Código";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            // 
            // lblPalavraChave
            // 
            this.lblPalavraChave.AutoSize = true;
            this.lblPalavraChave.Location = new System.Drawing.Point(9, 75);
            this.lblPalavraChave.Name = "lblPalavraChave";
            this.lblPalavraChave.Size = new System.Drawing.Size(79, 13);
            this.lblPalavraChave.TabIndex = 16;
            this.lblPalavraChave.Text = "Palavra chave:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(94, 70);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(279, 20);
            this.txtPalavra.TabIndex = 17;
            this.txtPalavra.Text = "1";
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToResizeColumns = false;
            this.dgvPesquisa.AllowUserToResizeRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 96);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(604, 235);
            this.dgvPesquisa.TabIndex = 18;
            // 
            // frmPesqAv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 345);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblPalavraChave);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttPesqAv);
            this.Controls.Add(this.bttFechar);
            this.Name = "frmPesqAv";
            this.Text = "Pesquisas Avançadas";
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttFechar;
        private System.Windows.Forms.Button bttPesqAv;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.RadioButton rbtUF;
        private System.Windows.Forms.RadioButton rbtEstado;
        private System.Windows.Forms.RadioButton rbtCodigo;
        private System.Windows.Forms.Label lblPalavraChave;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.DataGridView dgvPesquisa;
    }
}