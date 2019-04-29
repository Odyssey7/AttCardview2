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
    public partial class frmCadatro : Form
    {
        public frmCadatro()
        {
            InitializeComponent();
        }

        private void bttFechar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttCadastrar_Click(object sender, EventArgs e)
            {
                frmCadastroUsuários frmCAU = new frmCadastroUsuários();
                frmCAU.ShowDialog();
            }
    }
}