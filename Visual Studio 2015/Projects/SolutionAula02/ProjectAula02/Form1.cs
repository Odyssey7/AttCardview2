using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAula02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bttExibir_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = txtFrase.Text;
        }

        private void bttApagar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }

        private void bttVermelho_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Red;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Red;

        }

        private void bttPreto_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Black;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Black;
        }

        private void bttVerde_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Green;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Green;
        }

        private void bttAmarelo_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Yellow;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Yellow;
        }

        private void bttRosa_Click(object sender, EventArgs e)
        {
            ////bttExibir.ForeColor = BackColor;
            ////bttApagar.ForeColor = BackColor;
            ////this.BackColor = Color.Pink;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Pink;
        }

        private void bttBranco_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.White;
            lblMensagem.Text = txtFrase.Text;
            lblMensagem.ForeColor = Color.Black;
            this.ForeColor = Color.White;
        }

        private void bttRoxo_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Indigo;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Indigo;
        }

        private void bttCiano_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Cyan;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Cyan;
        }

        private void bttCinza_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Gray;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Gray;
        }

        private void bttSienna_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Sienna;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Sienna;
        }

        private void bttTomato_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Tomato;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Tomato;
        }

        private void bttDourado_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Gold;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Gold;
        }

        private void bttTurquesa_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Turquoise;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Turquoise;
        }

        private void bttAzul_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.DodgerBlue;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.DodgerBlue;
        }

        private void bttRosaPink_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.DeepPink;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.DeepPink;
        }

        private void bttVerdeLimão_Click(object sender, EventArgs e)
        {
            //bttExibir.ForeColor = BackColor;
            //bttApagar.ForeColor = BackColor;
            //this.BackColor = Color.Lime;
            lblMensagem.Text = txtFrase.Text;
            this.ForeColor = Color.Lime;
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
