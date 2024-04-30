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
    public partial class FrmSupprimer : Form
    {
        private gsbrapportEntities mesDonneesEf;
        public FrmSupprimer(gsbrapportEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonneesEf = mesDonnees;
            this.bdgSourceDelM.DataSource = this.mesDonneesEf.medicament.ToList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            string conf = "Oui";
            if (this.txtConf.Text== conf)
            {
                MessageBox.Show("Votre médicament a bien été supprimer !");
            }
            else
            {
                MessageBox.Show("Veuiller bien noter Confirmation !!");
            }
        }

        private void dtgSuppr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
