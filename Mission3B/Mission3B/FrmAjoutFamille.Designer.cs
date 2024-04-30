
namespace Mission3_GSB
{
    partial class FrmAjoutFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grBxLibelle = new System.Windows.Forms.GroupBox();
            this.txtNameF = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.grBxId = new System.Windows.Forms.GroupBox();
            this.txtAbrev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grBxLibelle.SuspendLayout();
            this.grBxId.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBxLibelle
            // 
            this.grBxLibelle.Controls.Add(this.txtNameF);
            this.grBxLibelle.Controls.Add(this.lblLibelle);
            this.grBxLibelle.Location = new System.Drawing.Point(12, 12);
            this.grBxLibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBxLibelle.Name = "grBxLibelle";
            this.grBxLibelle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBxLibelle.Size = new System.Drawing.Size(395, 114);
            this.grBxLibelle.TabIndex = 0;
            this.grBxLibelle.TabStop = false;
            this.grBxLibelle.Text = "Libelle";
            // 
            // txtNameF
            // 
            this.txtNameF.Location = new System.Drawing.Point(141, 52);
            this.txtNameF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameF.Name = "txtNameF";
            this.txtNameF.Size = new System.Drawing.Size(247, 22);
            this.txtNameF.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(21, 52);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(108, 16);
            this.lblLibelle.TabIndex = 0;
            this.lblLibelle.Text = "Nom de Famille :";
            // 
            // grBxId
            // 
            this.grBxId.Controls.Add(this.txtAbrev);
            this.grBxId.Controls.Add(this.label1);
            this.grBxId.Location = new System.Drawing.Point(12, 133);
            this.grBxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBxId.Name = "grBxId";
            this.grBxId.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBxId.Size = new System.Drawing.Size(395, 114);
            this.grBxId.TabIndex = 2;
            this.grBxId.TabStop = false;
            this.grBxId.Text = "Id";
            // 
            // txtAbrev
            // 
            this.txtAbrev.Location = new System.Drawing.Point(141, 52);
            this.txtAbrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAbrev.Name = "txtAbrev";
            this.txtAbrev.Size = new System.Drawing.Size(247, 22);
            this.txtAbrev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abréviation :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(201, 286);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 48);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(307, 286);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 48);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Annuler";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmAjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 354);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.grBxId);
            this.Controls.Add(this.grBxLibelle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAjoutFamille";
            this.Text = "FrmAjoutFamille";
            this.Load += new System.EventHandler(this.FrmAjoutFamille_Load);
            this.grBxLibelle.ResumeLayout(false);
            this.grBxLibelle.PerformLayout();
            this.grBxId.ResumeLayout(false);
            this.grBxId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxLibelle;
        private System.Windows.Forms.TextBox txtNameF;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.GroupBox grBxId;
        private System.Windows.Forms.TextBox txtAbrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
    }
}