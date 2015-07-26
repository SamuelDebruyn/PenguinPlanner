#region

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using PP_Business;
using PP_Entity;
using PP_Presentation.Properties;

#endregion

namespace PP_Presentation
{
    public partial class FrmBeheerder : MetroForm
    {
        private readonly OpenFileDialog _openFd;
        private StreamReader _strmReader;

        public FrmBeheerder()
        {
            InitializeComponent();

            _openFd = new OpenFileDialog();

            List<Vak> lst = Database.Vakken.AlleVakken;
            lstVakken.DataSource = lst;
            lstVakken.DisplayMember = "Naam";
            lstVakken.ValueMember = "Naam";

            DataTable tbl = Database.Gebruikers.sp_AlleGebruikersEenmalig();
            if (tbl == null)
            {
                Utilities.ConnectionLost();
            }

            dgrvGebruikers.DataSource = tbl;
            dgrvGebruikers.AutoGenerateColumns = true;
            dgrvGebruikers.Columns[0].Visible = false;
            dgrvGebruikers.Columns[1].HeaderText = Resources.Voornaam;
            dgrvGebruikers.Columns[2].HeaderText = Resources.Achternaam;
            dgrvGebruikers.Columns[3].HeaderText = Resources.Email;
            dgrvGebruikers.Columns[4].HeaderText = Resources.Geboortedatum;
        }

        public Form Referer { get; set; }

        private void frmBeheerder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referer.Show();
        }

        private void lstVakken_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgrvDocentenBijVakken.DataSource = Database.Gebruikers.sp_AlleGebruikersPerVak(
                (Vak)lstVakken.SelectedItem, Rol.Docent);

            dgrvDocentenBijVakken.AutoGenerateColumns = true;
            dgrvDocentenBijVakken.Columns[0].Visible = false;
            dgrvDocentenBijVakken.Columns[1].HeaderText = Resources.Voornaam;
            dgrvDocentenBijVakken.Columns[2].HeaderText = Resources.Achternaam;
            dgrvDocentenBijVakken.Columns[3].HeaderText = Resources.Email;

            dgrvStudentenBijVak.DataSource =
                Database.Gebruikers.sp_AlleGebruikersPerVak((Vak)lstVakken.SelectedItem,
                    Rol.Student);
            dgrvStudentenBijVak.AutoGenerateColumns = true;
            dgrvStudentenBijVak.Columns[0].Visible = false;
            dgrvStudentenBijVak.Columns[1].HeaderText = Resources.Voornaam;
            dgrvStudentenBijVak.Columns[2].HeaderText = Resources.Achternaam;
            dgrvStudentenBijVak.Columns[3].HeaderText = Resources.Email;
        }

        private void cmdVakToevoegen_Click(object sender, EventArgs e)
        {
            FrmVakToevoegen frmvaktoevoegen = new FrmVakToevoegen { Referer = this };
            frmvaktoevoegen.ShowDialog();
            lstVakken.DataSource = Database.Vakken.AlleVakken;
            lstVakken.DisplayMember = "Naam";
            lstVakken.ValueMember = "Naam";
        }

        private void cmdVakVerwijderen_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdVakVerwijderen_Click_Bent_u_zeker_dat_u_dit_vak_wilt_verwijderen_,
                    Resources.Bevestiging, MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                Vak vak = (Vak)lstVakken.SelectedItem;
                if (Database.Vakken.VakVerwijderen(vak))
                {
                    MessageBox.Show(Resources.FrmBeheerder_cmdVakVerwijderen_Click_Het_vak_is_succesvol_verwijderd_,
                        Resources.Verwijderd,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstVakken.DataSource = Database.Vakken.AlleVakken;
                    lstVakken.DisplayMember = "Naam";
                    lstVakken.ValueMember = "Naam";
                }
                else
                {
                    MessageBox.Show(
                        Resources
                            .FrmBeheerder_cmdVakVerwijderen_Click_Het_vak_kon_niet_verwijderd_worden__Probeer_het_later_opnieuw_,
                        Resources.Mislukt, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdVakAanpassen_Click(object sender, EventArgs e)
        {
            FrmVakAanpassen frmvakaanpassen = new FrmVakAanpassen((Vak)lstVakken.SelectedItem) { Referer = this };
            frmvakaanpassen.ShowDialog();
            lstVakken.DataSource = Database.Vakken.AlleVakken;
            lstVakken.DisplayMember = "Naam";
            lstVakken.ValueMember = "Naam";
        }

        private void frmBeheerder_Enter(object sender, EventArgs e)
        {
            lstVakken.DataSource = Database.Vakken.AlleVakken;
            lstVakken.DisplayMember = "Naam";
            lstVakken.ValueMember = "Naam";
        }


        private void radBeheerders_CheckedChanged(object sender, EventArgs e)
        {
            lstRollen.DataSource = null;
            dgrvGebruikers.DataSource = Database.Gebruikers.sp_AlleGebruikersPerRol(Rol.Beheerder);
            dgrvGebruikers.Columns[0].Visible = false;
        }

        private void radDocenten_CheckedChanged(object sender, EventArgs e)
        {
            lstRollen.DataSource = null;
            dgrvGebruikers.DataSource = Database.Gebruikers.sp_AlleGebruikersPerRol(Rol.Docent);
            dgrvGebruikers.Columns[0].Visible = false;
        }

        private void radStudenten_CheckedChanged(object sender, EventArgs e)
        {
            lstRollen.DataSource = null;
            dgrvGebruikers.DataSource = Database.Gebruikers.sp_AlleGebruikersPerRol(Rol.Student);
            dgrvGebruikers.Columns[0].Visible = false;
        }

        private void radAlleGebruikers_CheckedChanged(object sender, EventArgs e)
        {
            lstRollen.DataSource = null;
            dgrvGebruikers.DataSource = Database.Gebruikers.sp_AlleGebruikersEenmalig();
            dgrvGebruikers.Columns[0].Visible = false;
        }

        private void cmdGebruikerToevoegen_Click(object sender, EventArgs e)
        {
            FrmGebruikerAanmaken frmNieuweGebruiker = new FrmGebruikerAanmaken { Referer = this };
            frmNieuweGebruiker.FormClosed += RefreshContent;
            frmNieuweGebruiker.ShowDialog();
        }

        private void cmdGebruikerAanpassen_Click(object sender, EventArgs e)
        {
            if (dgrvGebruikers.CurrentRow == null)
            {
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdGebruikerAanpassen_Click_Gelieve_eerst_een_gebruiker_te_selecteren_);
                return;
            }
            int rowindex = dgrvGebruikers.CurrentRow.Index;
            int gebruikerId = Convert.ToInt32(dgrvGebruikers.Rows[rowindex].Cells[0].Value.ToString());

            if (gebruikerId <= 0)
            {
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdGebruikerAanpassen_Click_Gelieve_eerst_een_gebruiker_te_selecteren_);
                return;
            }
            Gebruiker aanTePassenGebruiker = Database.Gebruikers.ZoekGebruikerViaId(gebruikerId);
            if (aanTePassenGebruiker == null)
            {
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdGebruikerAanpassen_Click_Gelieve_eerst_een_gebruiker_te_selecteren_);
                return;
            }
            FrmGebruikerAanpassen frmGebruikerAanpassen = new FrmGebruikerAanpassen(aanTePassenGebruiker)
            {
                Referer = this
            };
            frmGebruikerAanpassen.FormClosed += RefreshContent;
            frmGebruikerAanpassen.ShowDialog();
        }

        private void cmdGebruikersToevoegenUitCSV_Click(object sender, EventArgs e)
        {
            if (_openFd.ShowDialog() != DialogResult.OK) return;
            List<Gebruiker> lijstGebruikers = new List<Gebruiker>();

            string fname = _openFd.FileName;
            using (_strmReader = new StreamReader(fname))
            {
                while (!_strmReader.EndOfStream)
                {
                    string line = _strmReader.ReadLine();
                    if (line == null) continue;
                    string[] colValue = line.Split(',');

                    string taalStr = colValue[5];
                    Taal taal = (Taal)Enum.Parse(typeof(Taal), taalStr);

                    Gebruiker gebruiker = new Gebruiker(colValue[0], colValue[1], colValue[2], colValue[3],
                        Convert.ToDateTime(colValue[4]), taal);
                    lijstGebruikers.Add(gebruiker);
                }
            }
            if (Database.Gebruikers.GebruikersUitCsvToevoegen(lijstGebruikers))
            {
                RefreshContent();
            }
            else
            {
                MessageBox.Show(
                    Resources
                        .FrmBeheerder_cmdGebruikersToevoegenUitCSV_Click_De_gebruikers_uit_het_CSV_bestand_konden_niet_worden_toegevoegd_aan_de_gegevensbank__Probeer_het_later_opnieuw_);
            }
        }

        private void cmdGebruikerVerwijderen_Click(object sender, EventArgs e)
        {
            if (dgrvGebruikers.CurrentRow == null)
            {
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdGebruikerAanpassen_Click_Gelieve_eerst_een_gebruiker_te_selecteren_);
                return;
            }
            int rowindex = dgrvGebruikers.CurrentRow.Index;
            int gebruikerId = Convert.ToInt32(dgrvGebruikers.Rows[rowindex].Cells[0].Value.ToString());

            if (gebruikerId <= 0)
            {
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdGebruikerAanpassen_Click_Gelieve_eerst_een_gebruiker_te_selecteren_);
                return;
            }
            if (Database.Gebruikers.GebruikerVerwijderen(gebruikerId))
            {
                MessageBox.Show(Resources.FrmBeheerder_cmdGebruikerVerwijderen_Click_Gebruiker_verwijderd_);
                RefreshContent();
            }
            else
            {
                MessageBox.Show(
                    Resources
                        .FrmBeheerder_cmdGebruikerVerwijderen_Click_De_gebruiker_kon_momenteel_niet_verwijderd_worden__Probeer_het_later_opnieuw_);
            }
        }

        private void cmdGebruikerInschrijven_Click(object sender, EventArgs e)
        {
            if (dgrvGebruikers.CurrentRow == null)
            {
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdGebruikerAanpassen_Click_Gelieve_eerst_een_gebruiker_te_selecteren_);
                return;
            }
            int rowindex = dgrvGebruikers.CurrentRow.Index;
            int gebruikerId = Convert.ToInt32(dgrvGebruikers.Rows[rowindex].Cells[0].Value.ToString());

            if (gebruikerId <= 0)
            {
                MessageBox.Show(
                    Resources.FrmBeheerder_cmdGebruikerAanpassen_Click_Gelieve_eerst_een_gebruiker_te_selecteren_);
                return;
            }
            Gebruiker inTeSchrijvenGebruiker = Database.Gebruikers.ZoekGebruikerViaId(gebruikerId);
            if (inTeSchrijvenGebruiker == null)
            {
                MessageBox.Show(Resources.FrmBeheerder_cmdGebruikerInschrijven_Click_Deze_gebruiker_werd_niet_teruggevonden_in_de_gegevensbank_,
                    Resources.FrmBeheerder_cmdGebruikerInschrijven_Click_Gebruiker_niet_gevonden, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmGebruikerInschrijven frmGebruikerInschrijven = new FrmGebruikerInschrijven(inTeSchrijvenGebruiker)
            {
                Referer = this
            };
            frmGebruikerInschrijven.ShowDialog();
            frmGebruikerInschrijven.FormClosed += RefreshContent;
        }

        private void RefreshContent(object sender, FormClosedEventArgs e)
        {
            RefreshContent();
        }

        private void RefreshContent()
        {
            dgrvGebruikers.DataSource = Database.Gebruikers.sp_AlleGebruikersEenmalig();
            dgrvGebruikers.AutoGenerateColumns = true;
            dgrvGebruikers.Columns[0].Visible = false;
        }

        private void dgrvGebruikers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrvGebruikers.CurrentRow == null) return;
            int rowindex = dgrvGebruikers.CurrentRow.Index;
            int gebruikerId = Convert.ToInt32(dgrvGebruikers.Rows[rowindex].Cells[0].Value.ToString());
            if (gebruikerId <= 0) return;
            try
            {
                lstRollen.DataSource = Database.Gebruikers.sp_AlleRollenPerGebruiker(gebruikerId);
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
            lstRollen.DisplayMember = "ROL_Naam";
            lstRollen.ValueMember = "ROL_Naam";
        }
    }
}