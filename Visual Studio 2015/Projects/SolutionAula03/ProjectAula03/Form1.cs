using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAula03
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void bttBrasil_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.brasil;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            picImagem.Image = BackgroundImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Twian;
        }

        private void bttBolívia_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Bolívia;
        }

        private void bttJamaica_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Jamaica;
        }

        private void bttAlemanha_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Alemanha;
        }

        private void bttAustrália_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Austrália;
        }

        private void bttÁfricadoSul_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.África_do_Sul;
        }

        private void bttChile_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Chile;
        }

        private void bttEgito_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Egito;
        }

        private void bttEspanha_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Espanha;
        }

        private void bttFranca_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.França;
        }

        private void bttEstadosUnidos_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Estados_Unidos;
        }

        private void bttIndia_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.India;
        }

        private void bttIrlanda_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Irlanda;
        }

        private void bttIslandia_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Islândia;
        }

        private void bttJapao_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Japão;
        }

        private void bttNovaZelandia_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Nova_Zelândia;
        }

        private void bttNorouega_Click(object sender, EventArgs e)
        {
            picImagem.Image = Properties.Resources.Norouega;
        }
    }
}
