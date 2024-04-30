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
    public partial class FrmAjoutMedic : Form
    {
        private gsbrapportEntities mesDonneesEF;
        public FrmAjoutMedic(gsbrapportEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgFamille.DataSource = this.mesDonneesEF.medicament.ToList();
            this.bdgFamille.DataSource = this.mesDonneesEF.famille.ToList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                this.mesDonneesEF.medicament.Add(nvxMedicament());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Votre médicaments a été ajouter");
                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        
        private string RandomString(int length)
        {
            Random random = new Random();
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

     

        private medicament nvxMedicament()
        {

              int num = new Random().Next(6, 15);
             string id = RandomString(num);
           
            string nomM = txtNameAdd.Text;
            string nomF = cmbFamille.Text;
            string Compo = txtCompo.Text;
            string Contre = txtContradiction.Text;
            string Effets = txtEffets.Text;
            medicament medicament = new medicament();
            medicament.id =id;
            medicament.nomCommercial = nomM;
            medicament.idFamille = nomF.ToString();
            medicament.composition = Compo;
            medicament.effets = Effets;
            medicament.contreIndications = Contre;
            
            return medicament;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAjoutFamille fam = new FrmAjoutFamille(this.mesDonneesEF);
            fam.ShowDialog();
            this.Close();
        }

        private void FrmAjoutMedic_Load(object sender, EventArgs e)
        {

        }
    }
}
