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
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Método pesquisa (para os botões de navegação)
        private void pesquisa(string consulta)
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
                    txtCodCli.Text = dr["cod_cli"].ToString();
                    txtNome.Text = dr["nome_cli"].ToString();
                    if (dr["sexo_cli"].ToString() == "M")
                    {
                        rbtMasculino.Checked = true;
                    }
                    else if (dr["sexo_cli"].ToString() == "F")
                    {
                        rbtFeminino.Checked = true;
                    }
                }
                dr.Close();
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
        #endregion
        #region Método modifica (para Delete, Update e insert)
        private void modifica(string sql)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();

            try
            {
                if (MessageBox.Show("Deseja executar esta ação", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        #endregion

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string apaga = String.Format("DELETE FROM tbclientes WHERE cliente = {0}", txtCodCli.Text);
            modifica(apaga);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            string sexo = null;
            if (rbtMasculino.Checked == true)
            {
                sexo = "M";
            }
            else if (rbtFeminino.Checked == true)
            {
                sexo = "F";
            }
            string novo = String.Format("INSERT INTO tbclientes VALUES({0},'{1}','{2}')", txtCodCli.Text, txtNome.Text, sexo);
            modifica(novo);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sexo = null;
            if (rbtMasculino.Checked == true)
            {
                sexo = "M";
            }
            else if (rbtFeminino.Checked == true)
            {
                sexo = "F";
            }
            string atualiza = String.Format("UPDATE tbclientes SET nome = '{0}', sexo = '{1}' WHERE cliente = {2}", txtNome.Text, sexo, txtCodCli.Text);
            modifica(atualiza);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            string primeiro = String.Format("SELECT * FROM tbclientes LIMIT 1");
            pesquisa(primeiro);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            string ultimo = String.Format("SELECT * FROM tbclientes ORDER BY Cliente DESC LIMIT 1");
            pesquisa(ultimo);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            string anterior = String.Format("SELECT * FROM tbclientes WHERE Cliente < {0} ORDER BY Cliente DESC LIMIT 1", txtCodCli.Text);
            pesquisa(anterior);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string proximo = String.Format("SELECT * FROM tbclientes WHERE Cliente > {0} LIMIT 1", txtCodCli.Text);
            pesquisa(proximo);
        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {
            string primeiro = String.Format("SELECT * FROM tbclientes LIMIT 1");
            pesquisa(primeiro);
        }

        private void btnPesqAv_Click(object sender, EventArgs e)
        {
            frmPesquisaAv frmPA = new frmPesquisaAv();
            frmPA.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            pddVisualizaImpressa.ShowDialog();
        }

        private void pdcImprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int X = 50;
            int Y = 50;

            Font minhafonte = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString(this.Text, minhafonte, Brushes.Blue, X, Y);
            e.Graphics.DrawString(DateTime.Now.ToString(), minhafonte, Brushes.Blue, X + 500, Y);
            minhafonte = new Font("Arial", 12, FontStyle.Bold);

            Y = Y + 100;
            e.Graphics.DrawString("Cliente dos Clientes", minhafonte, Brushes.Black, X, Y);
            e.Graphics.DrawString("Nome dos Clientes", minhafonte, Brushes.Black, X + 250, Y);
            e.Graphics.DrawString("Sexo dos Clientes", minhafonte, Brushes.Black, X + 500, Y);

            minhafonte = new Font("Arial", 12, FontStyle.Regular);

            string consulta = "SELECT * FROM Clientes";

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