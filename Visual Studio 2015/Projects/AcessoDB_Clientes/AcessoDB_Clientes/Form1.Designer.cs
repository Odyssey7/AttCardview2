namespace AcessoDB_Clientes
{
    partial class frmPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoa));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.btnPesqAv = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.bttSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pdcImprimir = new System.Drawing.Printing.PrintDocument();
            this.pddVisualizaImpressa = new System.Windows.Forms.PrintPreviewDialog();
            this.lblMeuNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(12, 90);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(15, 28);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(116, 20);
            this.txtCodCli.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 20);
            this.txtNome.TabIndex = 6;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFeminino.Location = new System.Drawing.Point(15, 106);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(31, 17);
            this.rbtFeminino.TabIndex = 7;
            this.rbtFeminino.Text = "F";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.Location = new System.Drawing.Point(15, 127);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(34, 17);
            this.rbtMasculino.TabIndex = 8;
            this.rbtMasculino.Text = "M";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // btnPesqAv
            // 
            this.btnPesqAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqAv.Image = global::AcessoDB_Clientes.Properties.Resources.advsearch;
            this.btnPesqAv.Location = new System.Drawing.Point(210, 127);
            this.btnPesqAv.Name = "btnPesqAv";
            this.btnPesqAv.Size = new System.Drawing.Size(144, 70);
            this.btnPesqAv.TabIndex = 17;
            this.btnPesqAv.Text = "Pes&quisa Avançada";
            this.btnPesqAv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesqAv.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Image = global::AcessoDB_Clientes.Properties.Resources.ultimo;
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUltimo.Location = new System.Drawing.Point(286, 203);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(70, 70);
            this.btnUltimo.TabIndex = 16;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Image = global::AcessoDB_Clientes.Properties.Resources.proximo;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProximo.Location = new System.Drawing.Point(210, 203);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(70, 70);
            this.btnProximo.TabIndex = 15;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Image = global::AcessoDB_Clientes.Properties.Resources.anterior;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnterior.Location = new System.Drawing.Point(134, 203);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(70, 70);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.Image = global::AcessoDB_Clientes.Properties.Resources.primeiro;
            this.btnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimeiro.Location = new System.Drawing.Point(58, 203);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(70, 70);
            this.btnPrimeiro.TabIndex = 13;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = global::AcessoDB_Clientes.Properties.Resources.erase;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagar.Location = new System.Drawing.Point(210, 279);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(70, 70);
            this.btnApagar.TabIndex = 12;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::AcessoDB_Clientes.Properties.Resources.adicionar;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(134, 279);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 70);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::AcessoDB_Clientes.Properties.Resources.atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(58, 279);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(70, 70);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualiza";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // bttSair
            // 
            this.bttSair.BackColor = System.Drawing.SystemColors.Control;
            this.bttSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSair.Image = global::AcessoDB_Clientes.Properties.Resources.exit;
            this.bttSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttSair.Location = new System.Drawing.Point(286, 12);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(70, 70);
            this.bttSair.TabIndex = 0;
            this.bttSair.Text = "&Sair";
            this.bttSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttSair.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::AcessoDB_Clientes.Properties.Resources.imprimir;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(286, 279);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(70, 70);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // pdcImprimir
            // 
            this.pdcImprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdcImprimir_PrintPage);
            // 
            // pddVisualizaImpressa
            // 
            this.pddVisualizaImpressa.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pddVisualizaImpressa.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pddVisualizaImpressa.ClientSize = new System.Drawing.Size(400, 300);
            this.pddVisualizaImpressa.Document = this.pdcImprimir;
            this.pddVisualizaImpressa.Enabled = true;
            this.pddVisualizaImpressa.Icon = ((System.Drawing.Icon)(resources.GetObject("pddVisualizaImpressa.Icon")));
            this.pddVisualizaImpressa.Name = "pddVisualizaImpressa";
            this.pddVisualizaImpressa.Visible = false;
            // 
            // lblMeuNome
            // 
            this.lblMeuNome.AutoSize = true;
            this.lblMeuNome.Location = new System.Drawing.Point(15, 380);
            this.lblMeuNome.Name = "lblMeuNome";
            this.lblMeuNome.Size = new System.Drawing.Size(144, 13);
            this.lblMeuNome.TabIndex = 19;
            this.lblMeuNome.Text = "Gustavo Santos Ferreira";
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 405);
            this.Controls.Add(this.lblMeuNome);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesqAv);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.rbtFeminino);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.bttSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPessoa";
            this.Text = "Acesso Cliente";
            this.Load += new System.EventHandler(this.frmPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPesqAv;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument pdcImprimir;
        private System.Windows.Forms.PrintPreviewDialog pddVisualizaImpressa;
        private System.Windows.Forms.Label lblMeuNome;
    }
}

