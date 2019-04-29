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
    public partial class frmSQL : Form
    {
        public frmSQL()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Método pesquisa (para os botões de navegação)
        private void pesquisa (string consulta)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            MySqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodigo.Text = dr["codigo"].ToString();
                    txtNome.Text = dr["nome"].ToString();
                    txtUF.Text = dr["uf"].ToString();
                }
                dr.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        private void Modifica(string sql)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conexao.abreConexao();
            try
            {
                if (MessageBox.Show("Deseja executar esta ação?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Ação realizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao realizar esta ação!");
                    }
                    cmd.Dispose();
                }
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            string apaga = String.Format("DELETE FROM ESTADOS WHERE Codigo = {0}", txtCodigo.Text);
            //MessageBox.Show(apaga);
            Modifica(apaga);
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            string novo = String.Format("INSERT INTO ESTADOS VALUES({0},'{1}','{2}')", txtCodigo.Text, txtNome.Text, txtUF.Text);
            //MessageBox.Show(novo);
            Modifica(novo);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string atualiza = String.Format("UPDATE Estados SET Nome = '{0}', UF = '{1}' WHERE Codigo ={2}", txtNome.Text, txtUF.Text, txtCodigo.Text);
            Modifica(atualiza);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            string primeiro = string.Format("SELECT * FROM estados LIMIT 1"); pesquisa(primeiro);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            string ultimo = string.Format("SELECT * FROM estados ORDER BY codigo DESC LIMIT 1"); pesquisa(ultimo);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            string anterior = String.Format("SELECT * FROM estados WHERE codigo < {0} ORDER BY codigo DESC LIMIT 1", txtCodigo.Text); pesquisa(anterior);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string proximo = String.Format("SELECT * FROM estados WHERE codigo > {0} LIMIT 1", txtCodigo.Text); pesquisa(proximo);
        }

        private void frmSQL_Load(object sender, EventArgs e)
        {
            string primeiro = String.Format("SELECT * FROM estados LIMIT 1"); pesquisa(primeiro);
        }

        private void btnPesAvan_Click(object sender, EventArgs e)
        {
            frmPesqAv frmPA = new frmPesqAv();
            frmPA.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            pddViualizaImpressao.ShowDialog();
        }
        private void pdcImprimir_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int X = 50;
            int Y = 50;

            Font minhafonte = new Font("Arial", 14, FontStyle.Bold);

            e.Graphics.DrawString(this.Text, minhafonte, Brushes.Blue, X, Y);
            e.Graphics.DrawString(DateTime.Now.ToString(), minhafonte, Brushes.Blue, X + 500, Y);
            minhafonte = new Font("Arial", 12, FontStyle.Bold);
            Y = Y + 100;
            e.Graphics.DrawString("Código do Estado", minhafonte, Brushes.Black, X, Y);
            e.Graphics.DrawString("Nome do Estado", minhafonte, Brushes.Black, X + 250, Y);
            e.Graphics.DrawString("Sigla do Estado", minhafonte, Brushes.Black, X + 500, Y);

            minhafonte = new Font("Arial", 12, FontStyle.Regular);

            string consulta = "SELECT * FROM Estados";

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = consulta;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();

            MySqlDataReader DR;

            try
            {
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Y = Y + 30;
                    e.Graphics.DrawString(DR.GetValue(0).ToString(), minhafonte, Brushes.Black, X, Y);
                    e.Graphics.DrawString(DR.GetValue(1).ToString(), minhafonte, Brushes.Black, X + 250, Y);
                    e.Graphics.DrawString(DR.GetValue(2).ToString(), minhafonte, Brushes.Black, X + 500, Y);
                }
                DR.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
    }
}