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
    public partial class FrmMAJ : Form
    {
        private gsbrapportEntities mesDonneesEF;
        public FrmMAJ(gsbrapportEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonnees;
            this.bdgMedicament.DataSource = this.mesDonneesEF.medicament.ToList();
            this.bdgFamille.DataSource = this.mesDonneesEF.famille.ToList();
        }

    
      

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.bdgMedicament.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
