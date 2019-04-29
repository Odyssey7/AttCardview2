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

namespace AcessoDB
{
    public partial class frmPesqAv : Form
    {
        public frmPesqAv()
        {
            InitializeComponent();
        }
        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bttPesqAv_Click(object sender, EventArgs e)
        {
            string consulta;
            if (rbtCodigo.Checked)
            {
                consulta = String.Format("SELECT * FROM Estados WHERE Codigo = {0}", txtPalavra.Text);
            }
            else if (rbtEstado.Checked)
            {
                consulta = String.Format("SELECT * FROM Estados WHERE Estado LIKE = '%{0}%", txtPalavra.Text);
            }
            else
            {
                consulta = String.Format("SELECT * FROM Estados WHERE UF LIKE = '%{0}%", txtPalavra.Text);
            }
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            try
            {
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataTable estados = new DataTable();
                DA.Fill(estados);
                dgvPesquisa.DataSource = estados;
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
        private void bttLimpar_Click(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = null;
        }
    }
}