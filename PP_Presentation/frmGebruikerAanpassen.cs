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
    public partial class FrmGebruikerAanpassen : MetroForm
    {
        private readonly Gebruiker _aanTePassenGebruiker;

        public FrmGebruikerAanpassen(Gebruiker aanTePassenGebruiker)
        {
            InitializeComponent();
            _aanTePassenGebruiker = aanTePassenGebruiker;
            Closed += FrmGebruikerAanpassen_Closed;

            foreach (var taal in Enum.GetValues(typeof (Taal)))
            {
                cmboTalen.Items.Add(taal);
            }
        }

        public Form Referer { get; set; }

        private void FrmGebruikerAanpassen_Closed(object sender, EventArgs e)
        {
            Referer.Show();
        }

        private void frmGebruikerAanpassenOfVerwijderen_Load(object sender, EventArgs e)
        {
            lblNaamAanTePassenGebruiker.Text = _aanTePassenGebruiker.Achternaam;
            tbVoornaam.Text = _aanTePassenGebruiker.Voornaam;
            tbNaam.Text = _aanTePassenGebruiker.Achternaam;
            tbEmail.Text = _aanTePassenGebruiker.Email;
            tbPaswoord.Text = _aanTePassenGebruiker.Wachtwoord;
            dtpGeboortedatum.Value = _aanTePassenGebruiker.Geboortedatum;
            cmboTalen.SelectedIndex = (int) _aanTePassenGebruiker.Taal;
        }

        private void cmdOpslagen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbVoornaam.Text) || tbVoornaam.Text.Length > 50)
            {
                lblMelding.Text =
                    Resources
                        .FrmGebruikerAanmaken_cmdOpslagen_Click_Gelieve_een_geldige_voornaam_in_te_vullen__minder_dan_50_karakters__;
            }
            else if (String.IsNullOrEmpty(tbNaam.Text) || tbNaam.Text.Length > 50)
            {
                lblMelding.Text =
                    Resources
                        .FrmGebruikerAanmaken_cmdOpslagen_Click_Gelieve_een_geldige_achternaam_in_te_vullen__minder_dan_50_karakters__;
            }
            else if (String.IsNullOrEmpty(tbEmail.Text) || tbEmail.Text.Length > 60)
            {
                lblMelding.Text =
                    Resources
                        .FrmGebruikerAanmaken_cmdOpslagen_Click_Gelieve_een_geldig_e_mailadres_in_te_vullen__minder_dan_60_karakters__;
            }
            else if (String.IsNullOrEmpty(tbPaswoord.Text) || tbPaswoord.Text.Length > 60)
            {
                lblMelding.Text =
                    Resources
                        .FrmGebruikerAanmaken_cmdOpslagen_Click_Gelieve_een_geldig_wachtwoord_in_te_vullen__minder_dan_60_karakters__;
            }
            else if (dtpGeboortedatum.Value >= DateTime.Now)
            {
                lblMelding.Text =
                    Resources
                        .FrmGebruikerAanmaken_cmdOpslagen_Click_Gelieve_een_geldig_wachtwoord_in_te_vullen__minder_dan_60_karakters__;
            }
            else
            {
                lblMelding.Text = "";
                Gebruiker toUpdate = new Gebruiker
                {
                    Id = _aanTePassenGebruiker.Id,
                    Voornaam = tbVoornaam.Text,
                    Achternaam = tbNaam.Text,
                    Email = tbEmail.Text,
                    Wachtwoord = tbPaswoord.Text,
                    Geboortedatum = dtpGeboortedatum.Value,
                    Taal = (Taal) Enum.Parse(typeof (Taal), cmboTalen.SelectedItem.ToString())
                };

                if (Database.Gebruikers.GebruikerUpdaten(toUpdate))
                {
                    MessageBox.Show(
                        Resources.FrmGebruikerAanpassen_cmdOpslagen_Click_De_gebruiker_werd_succesvol_aangepast_);
                    Close();
                }
                else
                {
                    MessageBox.Show(Resources.FrmGebruikerAanpassen_cmdOpslagen_Click_Er_trad_een_fout_op_bij_het_opslaan_van_de_gebruiker__Probeer_het_later_opnieuw_);
                }
            }
        }

        private void cmdAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdVerwijderen_Click(object sender, EventArgs e)
        {
            if (Database.Gebruikers.GebruikerVerwijderen(_aanTePassenGebruiker.Id))
            {
                MessageBox.Show(Resources.FrmBeheerder_cmdGebruikerVerwijderen_Click_Gebruiker_verwijderd_);
                Close();
            }
            else
            {
                MessageBox.Show(
                    Resources
                        .FrmGebruikerAanpassen_cmdVerwijderen_Click_De_gebruiker_kon_niet_verwijderd_worden__Probeer_het_later_opnieuw_);
            }
        }
    }
}