namespace MyKodiSaga
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDataBases = new System.Windows.Forms.ComboBox();
            this.lblChoixBase = new System.Windows.Forms.Label();
            this.cmdConnecterEtScanner = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.gpbGestionSaga = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomNouvelleSaga = new System.Windows.Forms.Label();
            this.txtNomNouvelleSaga = new System.Windows.Forms.TextBox();
            this.cmdCreerSaga = new System.Windows.Forms.Button();
            this.gpbContenuSaga = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdSupprimerSaga = new System.Windows.Forms.Button();
            this.lstContenuSaga = new System.Windows.Forms.ListBox();
            this.gpbAjoutFilmSaga = new System.Windows.Forms.GroupBox();
            this.lstFilmAjoutable = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmdTransferer = new System.Windows.Forms.Button();
            this.txtFiltreFilm = new System.Windows.Forms.TextBox();
            this.lstSaga = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFiltreSaga = new System.Windows.Forms.TextBox();
            this.pnlPrincipal.SuspendLayout();
            this.gpbGestionSaga.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbContenuSaga.SuspendLayout();
            this.gpbAjoutFilmSaga.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDataBases
            // 
            this.cmbDataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBases.FormattingEnabled = true;
            this.cmbDataBases.Location = new System.Drawing.Point(88, 12);
            this.cmbDataBases.Name = "cmbDataBases";
            this.cmbDataBases.Size = new System.Drawing.Size(152, 21);
            this.cmbDataBases.TabIndex = 0;
            // 
            // lblChoixBase
            // 
            this.lblChoixBase.AutoSize = true;
            this.lblChoixBase.Location = new System.Drawing.Point(12, 15);
            this.lblChoixBase.Name = "lblChoixBase";
            this.lblChoixBase.Size = new System.Drawing.Size(55, 13);
            this.lblChoixBase.TabIndex = 1;
            this.lblChoixBase.Text = "Base SQL";
            // 
            // cmdConnecterEtScanner
            // 
            this.cmdConnecterEtScanner.Location = new System.Drawing.Point(246, 11);
            this.cmdConnecterEtScanner.Name = "cmdConnecterEtScanner";
            this.cmdConnecterEtScanner.Size = new System.Drawing.Size(136, 23);
            this.cmdConnecterEtScanner.TabIndex = 2;
            this.cmdConnecterEtScanner.Text = "Connecter && scanner";
            this.cmdConnecterEtScanner.UseVisualStyleBackColor = true;
            this.cmdConnecterEtScanner.Click += new System.EventHandler(this.cmdConnecterEtScanner_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.gpbAjoutFilmSaga);
            this.pnlPrincipal.Controls.Add(this.panel3);
            this.pnlPrincipal.Controls.Add(this.gpbContenuSaga);
            this.pnlPrincipal.Controls.Add(this.panel2);
            this.pnlPrincipal.Controls.Add(this.gpbGestionSaga);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrincipal.Enabled = false;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 40);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(8);
            this.pnlPrincipal.Size = new System.Drawing.Size(613, 466);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // gpbGestionSaga
            // 
            this.gpbGestionSaga.Controls.Add(this.cmdSupprimerSaga);
            this.gpbGestionSaga.Controls.Add(this.cmdCreerSaga);
            this.gpbGestionSaga.Controls.Add(this.txtNomNouvelleSaga);
            this.gpbGestionSaga.Controls.Add(this.lblNomNouvelleSaga);
            this.gpbGestionSaga.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbGestionSaga.Location = new System.Drawing.Point(246, 8);
            this.gpbGestionSaga.Name = "gpbGestionSaga";
            this.gpbGestionSaga.Padding = new System.Windows.Forms.Padding(8);
            this.gpbGestionSaga.Size = new System.Drawing.Size(359, 79);
            this.gpbGestionSaga.TabIndex = 5;
            this.gpbGestionSaga.TabStop = false;
            this.gpbGestionSaga.Text = "Gestion des sagas personnelles";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstSaga);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.panel1.Size = new System.Drawing.Size(238, 450);
            this.panel1.TabIndex = 6;
            // 
            // lblNomNouvelleSaga
            // 
            this.lblNomNouvelleSaga.AutoSize = true;
            this.lblNomNouvelleSaga.Location = new System.Drawing.Point(11, 21);
            this.lblNomNouvelleSaga.Name = "lblNomNouvelleSaga";
            this.lblNomNouvelleSaga.Size = new System.Drawing.Size(81, 13);
            this.lblNomNouvelleSaga.TabIndex = 0;
            this.lblNomNouvelleSaga.Text = "Nom de la saga";
            // 
            // txtNomNouvelleSaga
            // 
            this.txtNomNouvelleSaga.Location = new System.Drawing.Point(98, 18);
            this.txtNomNouvelleSaga.Name = "txtNomNouvelleSaga";
            this.txtNomNouvelleSaga.Size = new System.Drawing.Size(187, 20);
            this.txtNomNouvelleSaga.TabIndex = 1;
            // 
            // cmdCreerSaga
            // 
            this.cmdCreerSaga.Location = new System.Drawing.Point(291, 16);
            this.cmdCreerSaga.Name = "cmdCreerSaga";
            this.cmdCreerSaga.Size = new System.Drawing.Size(55, 23);
            this.cmdCreerSaga.TabIndex = 2;
            this.cmdCreerSaga.Text = "Créer";
            this.cmdCreerSaga.UseVisualStyleBackColor = true;
            this.cmdCreerSaga.Click += new System.EventHandler(this.cmdCreerSaga_Click);
            // 
            // gpbContenuSaga
            // 
            this.gpbContenuSaga.Controls.Add(this.lstContenuSaga);
            this.gpbContenuSaga.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbContenuSaga.Location = new System.Drawing.Point(246, 95);
            this.gpbContenuSaga.Name = "gpbContenuSaga";
            this.gpbContenuSaga.Padding = new System.Windows.Forms.Padding(8);
            this.gpbContenuSaga.Size = new System.Drawing.Size(359, 131);
            this.gpbContenuSaga.TabIndex = 7;
            this.gpbContenuSaga.TabStop = false;
            this.gpbContenuSaga.Text = "Contenu de la Saga";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(246, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 8);
            this.panel2.TabIndex = 8;
            // 
            // cmdSupprimerSaga
            // 
            this.cmdSupprimerSaga.Enabled = false;
            this.cmdSupprimerSaga.Location = new System.Drawing.Point(247, 45);
            this.cmdSupprimerSaga.Name = "cmdSupprimerSaga";
            this.cmdSupprimerSaga.Size = new System.Drawing.Size(99, 23);
            this.cmdSupprimerSaga.TabIndex = 3;
            this.cmdSupprimerSaga.Text = "Supprimer";
            this.cmdSupprimerSaga.UseVisualStyleBackColor = true;
            this.cmdSupprimerSaga.Click += new System.EventHandler(this.cmdSupprimerSaga_Click);
            // 
            // lstContenuSaga
            // 
            this.lstContenuSaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstContenuSaga.FormattingEnabled = true;
            this.lstContenuSaga.Location = new System.Drawing.Point(8, 21);
            this.lstContenuSaga.Name = "lstContenuSaga";
            this.lstContenuSaga.Size = new System.Drawing.Size(343, 102);
            this.lstContenuSaga.TabIndex = 0;
            // 
            // gpbAjoutFilmSaga
            // 
            this.gpbAjoutFilmSaga.Controls.Add(this.lstFilmAjoutable);
            this.gpbAjoutFilmSaga.Controls.Add(this.panel6);
            this.gpbAjoutFilmSaga.Controls.Add(this.panel4);
            this.gpbAjoutFilmSaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbAjoutFilmSaga.Location = new System.Drawing.Point(246, 234);
            this.gpbAjoutFilmSaga.Name = "gpbAjoutFilmSaga";
            this.gpbAjoutFilmSaga.Padding = new System.Windows.Forms.Padding(8);
            this.gpbAjoutFilmSaga.Size = new System.Drawing.Size(359, 224);
            this.gpbAjoutFilmSaga.TabIndex = 9;
            this.gpbAjoutFilmSaga.TabStop = false;
            this.gpbAjoutFilmSaga.Text = "Films transférable";
            // 
            // lstFilmAjoutable
            // 
            this.lstFilmAjoutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFilmAjoutable.FormattingEnabled = true;
            this.lstFilmAjoutable.Location = new System.Drawing.Point(8, 52);
            this.lstFilmAjoutable.Name = "lstFilmAjoutable";
            this.lstFilmAjoutable.Size = new System.Drawing.Size(343, 133);
            this.lstFilmAjoutable.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(246, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 8);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtFiltreFilm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 31);
            this.panel4.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cmdTransferer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(8, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 31);
            this.panel6.TabIndex = 13;
            // 
            // cmdTransferer
            // 
            this.cmdTransferer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdTransferer.Location = new System.Drawing.Point(0, 8);
            this.cmdTransferer.Name = "cmdTransferer";
            this.cmdTransferer.Size = new System.Drawing.Size(343, 23);
            this.cmdTransferer.TabIndex = 2;
            this.cmdTransferer.Text = "Transférer";
            this.cmdTransferer.UseVisualStyleBackColor = true;
            // 
            // txtFiltreFilm
            // 
            this.txtFiltreFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFiltreFilm.Location = new System.Drawing.Point(0, 0);
            this.txtFiltreFilm.Name = "txtFiltreFilm";
            this.txtFiltreFilm.Size = new System.Drawing.Size(343, 20);
            this.txtFiltreFilm.TabIndex = 13;
            this.txtFiltreFilm.TextChanged += new System.EventHandler(this.txtFiltreFilm_TextChanged);
            // 
            // lstSaga
            // 
            this.lstSaga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSaga.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstSaga.FormattingEnabled = true;
            this.lstSaga.Location = new System.Drawing.Point(0, 31);
            this.lstSaga.Name = "lstSaga";
            this.lstSaga.Size = new System.Drawing.Size(230, 419);
            this.lstSaga.TabIndex = 5;
            this.lstSaga.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstSaga_DrawItem);
            this.lstSaga.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstSaga_MeasureItem);
            this.lstSaga.SelectedValueChanged += new System.EventHandler(this.lstSaga_SelectedValueChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtFiltreSaga);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 31);
            this.panel5.TabIndex = 12;
            // 
            // txtFiltreSaga
            // 
            this.txtFiltreSaga.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFiltreSaga.Location = new System.Drawing.Point(0, 0);
            this.txtFiltreSaga.Name = "txtFiltreSaga";
            this.txtFiltreSaga.Size = new System.Drawing.Size(230, 20);
            this.txtFiltreSaga.TabIndex = 13;
            this.txtFiltreSaga.TextChanged += new System.EventHandler(this.txtFiltreSaga_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 506);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.cmdConnecterEtScanner);
            this.Controls.Add(this.lblChoixBase);
            this.Controls.Add(this.cmbDataBases);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "MyKodiSaga";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.gpbGestionSaga.ResumeLayout(false);
            this.gpbGestionSaga.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpbContenuSaga.ResumeLayout(false);
            this.gpbAjoutFilmSaga.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDataBases;
        private System.Windows.Forms.Label lblChoixBase;
        private System.Windows.Forms.Button cmdConnecterEtScanner;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.GroupBox gpbGestionSaga;
        private System.Windows.Forms.Button cmdCreerSaga;
        private System.Windows.Forms.TextBox txtNomNouvelleSaga;
        private System.Windows.Forms.Label lblNomNouvelleSaga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbContenuSaga;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdSupprimerSaga;
        private System.Windows.Forms.ListBox lstContenuSaga;
        private System.Windows.Forms.GroupBox gpbAjoutFilmSaga;
        private System.Windows.Forms.ListBox lstFilmAjoutable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button cmdTransferer;
        private System.Windows.Forms.TextBox txtFiltreFilm;
        private System.Windows.Forms.ListBox lstSaga;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtFiltreSaga;
    }
}

