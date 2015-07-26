#region

using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Forms;
using PP_Business;
using PP_Entity;
using PP_Presentation.Properties;

#endregion

namespace PP_Presentation
{
    public partial class FrmVakAanpassenAdvanced : MetroForm
    {
        private readonly Vak _vak;

        public FrmVakAanpassenAdvanced(Vak vak)
        {
            InitializeComponent();
            _vak = vak;
            Closed += FrmVakAanpassenAdvanced_Closed;
        }

        public Form Referer { get; set; }

        private void FrmVakAanpassenAdvanced_Closed(object sender, EventArgs e)
        {
            Referer.Show();
        }

        private void frmVakAanpassenAdvanced_Load(object sender, EventArgs e)
        {
            try
            {
                dgrvLessen.DataSource = Database.Lessen.LessenPerVak(_vak);
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
            dgrvLessen.AutoGenerateColumns = true;
            dgrvLessen.Columns[0].Visible = false;

            dgrvLessen.Sort(dgrvLessen.Columns[2], ListSortDirection.Ascending);
        }

        private void cmdLesVerwijderen_Click(object sender, EventArgs e)
        {
            Lokaal lokaal = new Lokaal(0, 0);
            Les les = new Les((int) dgrvLessen.SelectedRows[0].Cells[0].Value,
                DateTimeOffset.Parse(dgrvLessen.SelectedRows[0].Cells[2].Value.ToString()),
                DateTimeOffset.Parse(dgrvLessen.SelectedRows[0].Cells[3].Value.ToString()), lokaal);

            MessageBox.Show(Database.Lessen.LesVerwijderen(les)
                ? Resources.FrmVakAanpassenAdvanced_cmdLesVerwijderen_Click_De_les_werd_succesvol_verwijderd_
                : Resources
                    .FrmVakAanpassenAdvanced_cmdLesVerwijderen_Click_De_les_kon_niet_verwijderd_worden__Probeer_het_later_opnieuw_);
        }

        private void tpBeginDatum_ValueChanged(object sender, EventArgs e)
        {
            tpEindDatum.Value = tpBeginDatum.Value.AddHours(2);
            MessageBox.Show(tpBeginDatum.Value.ToString());
            MessageBox.Show(tpEindDatum.Value.ToString());
            try
            {
                bsLokalenLijst.DataSource = Database.Lokalen.BeschikbareLokalen(tpBeginDatum.Value, tpEindDatum.Value);
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
            cbLokalen.DataSource = bsLokalenLijst.DataSource;
            cbLokalen.DisplayMember = "Id";
            cbLokalen.ValueMember = "Id";
        }

        private void cmdLesAanmaken_Click(object sender, EventArgs e)
        {
            try
            {
                if (Database.Lokalen.BeschikbareLokalen(tpBeginDatum.Value, tpEindDatum.Value).Count == 0)
                {
                    MessageBox.Show(
                        Resources.FrmVakAanpassenAdvanced_cmdLesAanmaken_Click_Er_zijn_geen_beschikbare_lokalen_);
                }
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
            foreach (Lokaal item in Database.Lokalen.BeschikbareLokalen(tpBeginDatum.Value, tpEindDatum.Value))
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}