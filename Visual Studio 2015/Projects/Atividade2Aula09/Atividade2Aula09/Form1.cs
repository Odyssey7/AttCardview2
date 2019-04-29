using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2Aula09
{
    public partial class frmNota10 : Form
    {
        public frmNota10()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.BackColor = Color.Red;
        }

        private void btnNo_MouseEnter(object sender, EventArgs e)
        {
            btnNo.BackColor = Color.LightCoral;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Então continue estudando!!!");
        }

        private void btnYes_MouseEnter(object sender, EventArgs e)
        {
            int x, y;
            Random rnd = new Random();
            x = rnd.Next(1, 540);
            y = rnd.Next(1, 350);
            btnYes.Location = new Point(x, y);
        }
    }
}
