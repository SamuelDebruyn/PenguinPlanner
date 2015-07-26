#region

using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using PP_Business;
using PP_Presentation.Properties;

#endregion

namespace PP_Presentation
{
    public partial class FrmInloggen : MetroForm
    {
        public FrmInloggen()
        {
            InitializeComponent();
            LoginStage(0);
        }

        private void cmdInloggen_Click(object sender, EventArgs e)
        {
            LoginStage(1);
        }

        private void LoginStage(byte stage)
        {
            /*
             *  0 = Nog niet ingelogged
             *  1 = Login gegevens invullen
             *  2 = Wel ingelogged 
            */
            switch (stage)
            {
                case 0:
                    cmdInloggen.Show();
                    pbPenguin.Show();
                    cmdOfficieelInloggen.Hide();
                    txtGebruikersnaam.Hide();
                    txtWachtwoord.Hide();
                    lblGebruikersnaam.Hide();
                    lblWachtwoord.Hide();
                    break;
                case 1:
                    cmdOfficieelInloggen.Show();
                    txtGebruikersnaam.Show();
                    txtWachtwoord.Show();
                    lblGebruikersnaam.Show();
                    lblWachtwoord.Show();
                    cmdInloggen.Hide();
                    pbPenguin.Hide();
                    break;
                case 2:
                    cmdInloggen.Hide();
                    cmdOfficieelInloggen.Hide();
                    txtGebruikersnaam.Hide();
                    txtWachtwoord.Hide();
                    lblGebruikersnaam.Hide();
                    lblWachtwoord.Hide();
                    pbPenguin.Hide();
                    break;
            }
        }

        private void cmdOfficieelInloggen_Click(object sender, EventArgs e)
        {
            string gebruikersnaam = txtGebruikersnaam.Text;
            string wachtwoord = txtWachtwoord.Text;
            try
            {
                if (Database.Gebruikers.FindInDatabase(gebruikersnaam, wachtwoord) == null)
                {
                    MessageBox.Show(
                        Resources
                            .FrmInloggen_cmdOfficieelInloggen_Click_Uw_gebruikersnaam_of_wachtwoord_is_fout__Kijk_deze_na_en_probeer_het_opnieuw_,
                        Resources.FrmInloggen_cmdOfficieelInloggen_Click_Gegevens_onjuist, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    languageControl1.ChangeLanguage(Database.Gebruikers.InlogGebruiker.Taal);
                    FrmHoofdvenster hfdVenster = new FrmHoofdvenster { Referer = this };
                    hfdVenster.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    Resources
                        .FrmInloggen_cmdOfficieelInloggen_Click_Er_kon_geen_verbinding_gemaakt_worden_met_de_gegevensbank__Probeer_het_later_opnieuw_,
                    Resources.FrmInloggen_cmdOfficieelInloggen_Click_Geen_verbinding, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtWachtwoord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtWachtwoord.ContainsFocus)
                cmdOfficieelInloggen_Click(sender, e);
            e.Handled = true;
        }
    }
}