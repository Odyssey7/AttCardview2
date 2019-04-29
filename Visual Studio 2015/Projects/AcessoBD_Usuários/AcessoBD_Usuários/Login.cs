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

namespace AcessoBD_Usuários
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttAcessar_Click(object sender, EventArgs e)
        {
            frmCadatro frmCA= new frmCadatro();
            frmCA.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}