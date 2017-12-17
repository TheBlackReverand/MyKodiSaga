using MyKodiSaga.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyKodiSaga
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MySql.Connect();

            foreach (string dataBase in MySql.ListMovieDataBase)
            {
                cmbDataBases.Items.Add(dataBase);
            }

            if (cmbDataBases.Items.Count > 0)
            {
                cmbDataBases.SelectedIndex = 0;
            }
        }

        private void cmdConnecterEtScanner_Click(object sender, EventArgs e)
        {
            MySql.SelectDataBase(cmbDataBases.SelectedItem as string);

            if (!MySql.CheckIfSagaMonitoringTableExist())
            {
                MySql.CreateSagaMonitoringTable();
            }

            RefreshListSaga();
            RefreshListMovie();

            pnlPrincipal.Enabled = true;
        }

        private void cmdCreerSaga_Click(object sender, EventArgs e)
        {
            MySql.CreateSaga(txtNomNouvelleSaga.Text);

            RefreshListSaga();
        }

        private void cmdSupprimerSaga_Click(object sender, EventArgs e)
        {
            MySql.DeleteSaga((Saga)lstSaga.SelectedItem);

            RefreshListSaga();

            cmdSupprimerSaga.Enabled = false;
        }

        private void RefreshListSaga()
        {
            lstSaga.Items.Clear();

            foreach (Saga saga in MySql.ListSaga)
            {
                if (saga.Name.ToUpper().Contains(txtFiltreSaga.Text.ToUpper()))
                {
                    lstSaga.Items.Add(saga);
                }
            }
        }
        private void RefreshListMovie()
        {
            lstFilmAjoutable.Items.Clear();

            foreach (Movie movie in MySql.ListFilm())
            {
                if (movie.Name.ToUpper().Contains(txtFiltreFilm.Text.ToUpper()))
                {
                    lstFilmAjoutable.Items.Add(movie);
                }
            }
        }

        #region Override design of LstSaga Item

        private void lstSaga_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 18;
        }

        private void lstSaga_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(lstSaga.Items[e.Index].ToString(),
                                  new Font("Arial", 10, ((Saga)lstSaga.Items[e.Index]).IsPersonnalSaga ? FontStyle.Bold : FontStyle.Regular),
                                  Brushes.Black,
                                  e.Bounds);
            e.DrawFocusRectangle();
        }

        #endregion

        private void lstSaga_SelectedValueChanged(object sender, EventArgs e)
        {
            cmdSupprimerSaga.Enabled = ((Saga)lstSaga.SelectedItem).IsPersonnalSaga;

            lstContenuSaga.Items.Clear();
            foreach (Movie movie in MySql.ListFilm((Saga)lstSaga.SelectedItem))
            {
                lstContenuSaga.Items.Add(movie);
            }
        }

        private void txtFiltreSaga_TextChanged(object sender, EventArgs e)
        {
            RefreshListSaga();
        }

        private void txtFiltreFilm_TextChanged(object sender, EventArgs e)
        {
            RefreshListMovie();
        }

        private void cmdTransferer_Click(object sender, EventArgs e)
        {
            MySql.CopyMovieInSaga((Movie)lstFilmAjoutable.SelectedItem, (Saga)lstSaga.SelectedItem);

            txtFiltreFilm_TextChanged(null, EventArgs.Empty);
            lstSaga_SelectedValueChanged(null, EventArgs.Empty);
        }
    }
}