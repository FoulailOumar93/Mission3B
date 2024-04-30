
namespace Mission3_GSB
{
    partial class FrmSupprimer
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
            this.components = new System.ComponentModel.Container();
            this.grBxSuppr = new System.Windows.Forms.GroupBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.lblConf = new System.Windows.Forms.Label();
            this.dtgSuppr = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgSourceDelM = new System.Windows.Forms.BindingSource(this.components);
            this.grBxSuppr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuppr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceDelM)).BeginInit();
            this.SuspendLayout();
            // 
            // grBxSuppr
            // 
            this.grBxSuppr.Controls.Add(this.btnFermer);
            this.grBxSuppr.Controls.Add(this.button2);
            this.grBxSuppr.Controls.Add(this.txtConf);
            this.grBxSuppr.Controls.Add(this.lblConf);
            this.grBxSuppr.Location = new System.Drawing.Point(3, 12);
            this.grBxSuppr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBxSuppr.Name = "grBxSuppr";
            this.grBxSuppr.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBxSuppr.Size = new System.Drawing.Size(904, 527);
            this.grBxSuppr.TabIndex = 12;
            this.grBxSuppr.TabStop = false;
            this.grBxSuppr.Text = "Supprimer";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(745, 450);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(139, 50);
            this.btnFermer.TabIndex = 12;
            this.btnFermer.Text = "Annuler";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtConf
            // 
            this.txtConf.Location = new System.Drawing.Point(580, 379);
            this.txtConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConf.Name = "txtConf";
            this.txtConf.Size = new System.Drawing.Size(316, 22);
            this.txtConf.TabIndex = 10;
            this.txtConf.UseSystemPasswordChar = true;
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Location = new System.Drawing.Point(461, 383);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(87, 16);
            this.lblConf.TabIndex = 9;
            this.lblConf.Text = "Confirmation :";
            // 
            // dtgSuppr
            // 
            this.dtgSuppr.AutoGenerateColumns = false;
            this.dtgSuppr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSuppr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn,
            this.offrirDataGridViewTextBoxColumn});
            this.dtgSuppr.DataSource = this.bdgSourceDelM;
            this.dtgSuppr.Location = new System.Drawing.Point(21, 34);
            this.dtgSuppr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgSuppr.Name = "dtgSuppr";
            this.dtgSuppr.RowHeadersWidth = 51;
            this.dtgSuppr.Size = new System.Drawing.Size(884, 319);
            this.dtgSuppr.TabIndex = 13;
            this.dtgSuppr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSuppr_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            this.nomCommercialDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomCommercialDataGridViewTextBoxColumn.Width = 125;
            // 
            // idFamilleDataGridViewTextBoxColumn
            // 
            this.idFamilleDataGridViewTextBoxColumn.DataPropertyName = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.HeaderText = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFamilleDataGridViewTextBoxColumn.Name = "idFamilleDataGridViewTextBoxColumn";
            this.idFamilleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFamilleDataGridViewTextBoxColumn.Width = 125;
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            this.compositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.compositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            this.effetsDataGridViewTextBoxColumn.ReadOnly = true;
            this.effetsDataGridViewTextBoxColumn.Width = 125;
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            this.contreIndicationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.contreIndicationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "famille";
            this.familleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            this.familleDataGridViewTextBoxColumn.Visible = false;
            this.familleDataGridViewTextBoxColumn.Width = 125;
            // 
            // offrirDataGridViewTextBoxColumn
            // 
            this.offrirDataGridViewTextBoxColumn.DataPropertyName = "offrir";
            this.offrirDataGridViewTextBoxColumn.HeaderText = "offrir";
            this.offrirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offrirDataGridViewTextBoxColumn.Name = "offrirDataGridViewTextBoxColumn";
            this.offrirDataGridViewTextBoxColumn.Visible = false;
            this.offrirDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdgSourceDelM
            // 
            this.bdgSourceDelM.DataSource = typeof(Mission3_GSB.medicament);
            // 
            // FrmSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 551);
            this.Controls.Add(this.dtgSuppr);
            this.Controls.Add(this.grBxSuppr);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSupprimer";
            this.Text = "FrmDelete";
            this.grBxSuppr.ResumeLayout(false);
            this.grBxSuppr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuppr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceDelM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxSuppr;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.DataGridView dtgSuppr;
        private System.Windows.Forms.BindingSource bdgSourceDelM;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirDataGridViewTextBoxColumn;
    }
}