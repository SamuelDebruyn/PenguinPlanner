#region

using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using PP_Business;
using PP_Entity;
using PP_Presentation.Properties;

#endregion

namespace PP_Presentation
{
    public partial class FrmStudent : MetroForm
    {
        public FrmStudent()
        {
            InitializeComponent();

            dgrvMededelingen.DataSource = Database.Opdrachten.MededelingenPerGebruiker;
            dgrvMededelingen.AutoGenerateColumns = true;
            dgrvMededelingen.Columns[0].Visible = false;
            dgrvMededelingen.Columns[2].Visible = false;
            dgrvMededelingen.Columns[1].HeaderText = Resources.Vak;
            dgrvMededelingen.Columns[3].HeaderText = Resources.Beschrijving;
            dgrvMededelingen.Columns[4].HeaderText = Resources.Einddatum;
            dgrvMededelingen.Columns[5].HeaderText = Resources.Begindatum;
            lstMededelingen.Hide();

            dgrvTaken.DataSource = Database.Opdrachten.TakenPerGebruiker;
            dgrvTaken.AutoGenerateColumns = true;
            dgrvTaken.Columns[0].Visible = false;
            dgrvTaken.Columns[2].Visible = false;
            dgrvTaken.Columns[1].HeaderText = Resources.Vak;
            dgrvTaken.Columns[3].HeaderText = Resources.Beschrijving;
            dgrvTaken.Columns[4].HeaderText = Resources.Einddatum;
            dgrvTaken.Columns[5].HeaderText = Resources.Begindatum;
            DataGridViewColumn colTaken = dgrvTaken.Columns[4];
            if (colTaken != null) colTaken.SortMode = DataGridViewColumnSortMode.Automatic;


            dgrvTesten.DataSource = Database.Opdrachten.TestenPerGebruiker;
            dgrvTesten.AutoGenerateColumns = true;
            dgrvTesten.Columns[0].Visible = false;
            dgrvTesten.Columns[2].Visible = false;
            dgrvTesten.Columns[1].HeaderText = Resources.Vak;
            dgrvTesten.Columns[3].HeaderText = Resources.Beschrijving;
            dgrvTesten.Columns[4].HeaderText = Resources.Einddatum;
            dgrvTesten.Columns[5].HeaderText = Resources.Begindatum;
            DataGridViewColumn colTesten = dgrvTesten.Columns[4];
            if (colTesten != null) colTesten.SortMode = DataGridViewColumnSortMode.Automatic;


            lstVakken.DataSource = Database.Vakken.Lijst;
            lstVakken.DisplayMember = "Naam";
            lstVakken.ValueMember = "Naam";
        }

        public Form Referer { get; set; }

        private void frmStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referer.Show();
        }

        private void lstVakken_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdMemoOpslagen.PerformClick();
            Vak vak = lstVakken.SelectedItem as Vak;

            Gebruiker gevondenDocent = Database.Gebruikers.ZoekenDocentViaVak(vak);
            if (gevondenDocent == null) return;

            lblNaamInhoud.Text = gevondenDocent.Voornaam;
            lblAchternaamInhoud.Text = gevondenDocent.Achternaam;
            lblEmailInhoud.Text = gevondenDocent.Email;

            if (vak != null)
            {
                dgrvMemo.DataSource = Database.Memos.MemoPerGebruikerPerVak(Database.Gebruikers.InlogGebruiker.Id,
                    vak.Id);


                rtxtMemo.Text =
                    Database.Memos.MemoPerGebruikerPerVak(Database.Gebruikers.InlogGebruiker.Id, vak.Id).Rows.Count != 0
                        ? dgrvMemo.Rows[0].Cells[0].Value.ToString()
                        : "";
            }
        }

        private void cmdMemoOpslagen_Click(object sender, EventArgs e)
        {
            Vak vak = lstVakken.SelectedItem as Vak;
            if (vak != null &&
                Database.Memos.MemoPerGebruikerPerVak(Database.Gebruikers.InlogGebruiker.Id, vak.Id).Rows.Count != 0)
            {
                int memid = (int)dgrvMemo.Rows[0].Cells[1].Value;
                if (!Database.Memos.MemoUpdaten(memid, rtxtMemo.Text))
                {
                    MessageBox.Show(Resources.FrmStudent_cmdMemoOpslagen_Click_De_memo_kon_niet_worden_opgeslagen__Probeer_het_later_opnieuw_);
                }
            }
            else if (vak != null)
            {
                if (!Database.Memos.MemoToevoegen(Database.Gebruikers.InlogGebruiker.Id, vak.Id, rtxtMemo.Text))
                {
                    MessageBox.Show(Resources.FrmStudent_cmdMemoOpslagen_Click_De_memo_kon_niet_worden_opgeslagen__Probeer_het_later_opnieuw_);
                }
            }

        }
    }
}