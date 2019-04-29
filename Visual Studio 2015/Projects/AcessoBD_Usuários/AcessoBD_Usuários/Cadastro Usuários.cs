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
    public partial class frmCadastroUsuários : Form
    {
        public frmCadastroUsuários()
        {
            InitializeComponent();
        }

        private void bttFechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}