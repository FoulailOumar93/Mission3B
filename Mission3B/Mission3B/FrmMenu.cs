using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3_GSB
{
    public partial class FrmMenu : Form
    {
        private gsbrapportEntities mesDonneesEF;
        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonneesEF = new gsbrapportEntities();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutMedic add = new FrmAjoutMedic(this.mesDonneesEF);
            add.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMAJ update = new FrmMAJ(this.mesDonneesEF);
            update.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupprimer del = new FrmSupprimer(this.mesDonneesEF) ;
            del.ShowDialog();
        }

        private void visiualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVoirMedic show = new FrmVoirMedic(this.mesDonneesEF);
            show.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
