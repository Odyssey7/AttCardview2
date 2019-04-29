using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcessoDB_Clientes
{
    public partial class frmPesquisaAv : Form
    {
        public frmPesquisaAv()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesqAv_Click(object sender, EventArgs e)
        {
            string consulta;
            if (rbtcliente.Checked)
            {
                consulta = String.Format("SELECT * FROM clientes WHERE cliente = {0}", txtPalavra.Text);
            }
            else if (rbtnome.Checked)
            {
                consulta = String.Format("SELECT * FROM clientes WHERE nome LIKE '%{0}'", txtPalavra.Text);
            }
            else
            {
                consulta = String.Format("SELECT * FROM clientes WHERE sexo LIKE '%{0}'", txtPalavra.Text);
            }
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            try
            {
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataTable clientes = new DataTable();
                DA.Fill(clientes);
                dgvPesquisa.DataSource = clientes;
                cmd.Dispose();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = null;
        }

        private DataGridView dgvPesquisa;
        private Button btnFechar;
        private Button btnLimpar;
        private Button btnPesqAv;
        private TextBox txtPalavra;
        private Label lblPalavraChave;
        private GroupBox grbtipo;
        private RadioButton rbtSexo;
        private RadioButton rbtcliente;
        private RadioButton rbtnome;

        private void InitializeComponent()
        {
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesqAv = new System.Windows.Forms.Button();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblPalavraChave = new System.Windows.Forms.Label();
            this.grbtipo = new System.Windows.Forms.GroupBox();
            this.rbtSexo = new System.Windows.Forms.RadioButton();
            this.rbtcliente = new System.Windows.Forms.RadioButton();
            this.rbtnome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.grbtipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToResizeColumns = false;
            this.dgvPesquisa.AllowUserToResizeRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPesquisa.Location = new System.Drawing.Point(18, 109);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(570, 270);
            this.dgvPesquisa.TabIndex = 13;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = global::AcessoDB_Clientes.Properties.Resources.exit;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(487, 15);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(70, 70);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::AcessoDB_Clientes.Properties.Resources.clear;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(411, 15);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesqAv
            // 
            this.btnPesqAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqAv.Image = global::AcessoDB_Clientes.Properties.Resources.search;
            this.btnPesqAv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesqAv.Location = new System.Drawing.Point(335, 15);
            this.btnPesqAv.Name = "btnPesqAv";
            this.btnPesqAv.Size = new System.Drawing.Size(70, 70);
            this.btnPesqAv.TabIndex = 10;
            this.btnPesqAv.Text = "&Pesquisar";
            this.btnPesqAv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesqAv.UseVisualStyleBackColor = true;
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(149, 69);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra.TabIndex = 9;
            this.txtPalavra.Text = "1";
            // 
            // lblPalavraChave
            // 
            this.lblPalavraChave.AutoSize = true;
            this.lblPalavraChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavraChave.Location = new System.Drawing.Point(49, 72);
            this.lblPalavraChave.Name = "lblPalavraChave";
            this.lblPalavraChave.Size = new System.Drawing.Size(94, 13);
            this.lblPalavraChave.TabIndex = 8;
            this.lblPalavraChave.Text = "Palavra-Chave:";
            // 
            // grbtipo
            // 
            this.grbtipo.Controls.Add(this.rbtSexo);
            this.grbtipo.Controls.Add(this.rbtcliente);
            this.grbtipo.Controls.Add(this.rbtnome);
            this.grbtipo.Location = new System.Drawing.Point(49, 12);
            this.grbtipo.Name = "grbtipo";
            this.grbtipo.Size = new System.Drawing.Size(280, 48);
            this.grbtipo.TabIndex = 7;
            this.grbtipo.TabStop = false;
            this.grbtipo.Text = "Pesquisa por:";
            // 
            // rbtSexo
            // 
            this.rbtSexo.AutoSize = true;
            this.rbtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSexo.Location = new System.Drawing.Point(188, 19);
            this.rbtSexo.Name = "rbtSexo";
            this.rbtSexo.Size = new System.Drawing.Size(53, 17);
            this.rbtSexo.TabIndex = 3;
            this.rbtSexo.Text = "Sexo";
            this.rbtSexo.UseVisualStyleBackColor = true;
            // 
            // rbtcliente
            // 
            this.rbtcliente.AutoSize = true;
            this.rbtcliente.Checked = true;
            this.rbtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtcliente.Location = new System.Drawing.Point(6, 19);
            this.rbtcliente.Name = "rbtcliente";
            this.rbtcliente.Size = new System.Drawing.Size(64, 17);
            this.rbtcliente.TabIndex = 1;
            this.rbtcliente.TabStop = true;
            this.rbtcliente.Text = "Cliente";
            this.rbtcliente.UseVisualStyleBackColor = true;
            // 
            // rbtnome
            // 
            this.rbtnome.AutoSize = true;
            this.rbtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnome.Location = new System.Drawing.Point(100, 19);
            this.rbtnome.Name = "rbtnome";
            this.rbtnome.Size = new System.Drawing.Size(57, 17);
            this.rbtnome.TabIndex = 2;
            this.rbtnome.Text = "Nome";
            this.rbtnome.UseVisualStyleBackColor = true;
            // 
            // frmPesquisaAv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 391);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesqAv);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblPalavraChave);
            this.Controls.Add(this.grbtipo);
            this.Name = "frmPesquisaAv";
            this.Text = "Pesquisas Avançadas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.grbtipo.ResumeLayout(false);
            this.grbtipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}