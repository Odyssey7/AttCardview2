namespace AcessoDB
{
    partial class frmSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQL));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.btnPesAvan = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNov = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pdcImprimir = new System.Drawing.Printing.PrintDocument();
            this.pddViualizaImpressao = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Código:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 63);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(89, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Nome do Estado:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(12, 117);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 2;
            this.lblUF.Text = "UF:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(15, 133);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(49, 20);
            this.txtUF.TabIndex = 5;
            // 
            // btnPesAvan
            // 
            this.btnPesAvan.Image = global::AcessoDB.Properties.Resources.advsearch;
            this.btnPesAvan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesAvan.Location = new System.Drawing.Point(238, 180);
            this.btnPesAvan.Name = "btnPesAvan";
            this.btnPesAvan.Size = new System.Drawing.Size(145, 70);
            this.btnPesAvan.TabIndex = 15;
            this.btnPesAvan.Text = "Pesquisa Avançada";
            this.btnPesAvan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesAvan.UseVisualStyleBackColor = true;
            this.btnPesAvan.Click += new System.EventHandler(this.btnPesAvan_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = global::AcessoDB.Properties.Resources.ultimo;
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUltimo.Location = new System.Drawing.Point(313, 256);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(70, 70);
            this.btnUltimo.TabIndex = 14;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::AcessoDB.Properties.Resources.proximo;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProximo.Location = new System.Drawing.Point(237, 256);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(70, 70);
            this.btnProximo.TabIndex = 13;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::AcessoDB.Properties.Resources.anterior;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnterior.Location = new System.Drawing.Point(161, 256);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(70, 70);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Image = global::AcessoDB.Properties.Resources.primeiro;
            this.btnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimeiro.Location = new System.Drawing.Point(85, 256);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(70, 70);
            this.btnPrimeiro.TabIndex = 11;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::AcessoDB.Properties.Resources.atualizar;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(85, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 70);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNov
            // 
            this.btnNov.Image = global::AcessoDB.Properties.Resources.adicionar;
            this.btnNov.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNov.Location = new System.Drawing.Point(161, 332);
            this.btnNov.Name = "btnNov";
            this.btnNov.Size = new System.Drawing.Size(70, 70);
            this.btnNov.TabIndex = 9;
            this.btnNov.Text = "Novo";
            this.btnNov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNov.UseVisualStyleBackColor = true;
            this.btnNov.Click += new System.EventHandler(this.btnNov_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::AcessoDB.Properties.Resources.erase;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDel.Location = new System.Drawing.Point(238, 332);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 70);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Apagar";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::AcessoDB.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(313, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 70);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::AcessoDB.Properties.Resources.imprimir;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(313, 334);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(70, 70);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pdcImprimir
            // 
            this.pdcImprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdcImprimir_PrintPage_1);
            // 
            // pddViualizaImpressao
            // 
            this.pddViualizaImpressao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pddViualizaImpressao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pddViualizaImpressao.ClientSize = new System.Drawing.Size(400, 300);
            this.pddViualizaImpressao.Document = this.pdcImprimir;
            this.pddViualizaImpressao.Enabled = true;
            this.pddViualizaImpressao.Icon = ((System.Drawing.Icon)(resources.GetObject("pddViualizaImpressao.Icon")));
            this.pddViualizaImpressao.Name = "pddViualizaImpressao";
            this.pddViualizaImpressao.Visible = false;
            // 
            // frmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 416);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesAvan);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNov);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNome);
            this.Name = "frmSQL";
            this.Text = "Acesso MySQL";
            this.Load += new System.EventHandler(this.frmSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNov;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPesAvan;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument pdcImprimir;
        private System.Windows.Forms.PrintPreviewDialog pddViualizaImpressao;
    }
}