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
    public partial class FrmGebruikerAanmaken : MetroForm
    {
        private Gebruiker _nieuweGebruiker;

        public FrmGebruikerAanmaken()
        {
            InitializeComponent();
            Load += FrmGebruikerAanmaken_Load;
            Closed += FrmGebruikerAanmaken_Closed;

            foreach (var taal in Enum.GetValues(typeof (Taal)))
            {
                cmboTalen.Items.Add(taal);
            }
        }

        public Form Referer { get; set; }

        private void FrmGebruikerAanmaken_Load(object sender, EventArgs e)
        {
            cmboTalen.SelectedIndex = 0;
        }

        private void FrmGebruikerAanmaken_Closed(object sender, EventArgs e)
        {
            Referer.Show();
        }

        private void cmdAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
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
                        .FrmGebruikerAanmaken_cmdOpslagen_Click_Gelieve_een_geboortedatum_in_het_verleden_aan_te_duiden_;
            }
            else
            {
                lblMelding.Text = "";
                _nieuweGebruiker = new Gebruiker
                {
                    Voornaam = tbVoornaam.Text,
                    Achternaam = tbNaam.Text,
                    Email = tbEmail.Text,
                    Wachtwoord = tbPaswoord.Text,
                    Geboortedatum = dtpGeboortedatum.Value,
                    Taal = (Taal) Enum.Parse(typeof (Taal), cmboTalen.SelectedItem.ToString())
                };

                if (Database.Gebruikers.GebruikerToevoegen(_nieuweGebruiker))
                {
                    MessageBox.Show(
                        Resources.FrmGebruikerAanmaken_cmdOpslagen_Click_De_gebruiker_werd_succesvol_toegevoegd_);
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        Resources
                            .FrmGebruikerAanmaken_cmdOpslagen_Click_De_gebruiker_kon_niet_worden_opgeslagen__Probeer_het_later_opnieuw_);
                }
            }
        }
    }
}