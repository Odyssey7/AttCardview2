using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAula09
{
    public partial class frmPlace : Form
    {
        public frmPlace()
        {
            InitializeComponent();
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstPlace.SelectedIndex)
            {
                case 0:
                    picPlace.Image = Properties.Resources.brasil;
                    break;
                case 1:
                    picPlace.Image = Properties.Resources.eua;
                    break;
                case 2:
                    picPlace.Image = Properties.Resources.egito;
                    break;
                case 3:
                    picPlace.Image = Properties.Resources.india;
                    break;
                case 4:
                    picPlace.Image = Properties.Resources.inglaterra;
                    break;
                case 5:
                    picPlace.Image = Properties.Resources.china;
                    break;
                case 6:
                    picPlace.Image = Properties.Resources.paris;
                    break;
            }
        }
    }
}
