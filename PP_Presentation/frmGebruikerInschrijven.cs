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
    public partial class FrmGebruikerInschrijven : MetroForm
    {
        private readonly Gebruiker _inTeSchrijvenGebruiker;

        public FrmGebruikerInschrijven(Gebruiker inTeSchrijvenGebruiker)
        {
            InitializeComponent();

            _inTeSchrijvenGebruiker = inTeSchrijvenGebruiker;

            /*
            *  Combobox vakken opvullen
            */
            //bsVakkenLijst.DataSource = Database.Vakken.AlleVakken;
            //cmboVakken.DataSource = bsVakkenLijst.DataSource;
            cmboVakken.DataSource = Database.Vakken.AlleVakken;
            cmboVakken.DisplayMember = "Naam";
            cmboVakken.ValueMember = "Naam";

            lblVoornaam.Text = _inTeSchrijvenGebruiker.Voornaam;
            lblAchternaam.Text = _inTeSchrijvenGebruiker.Achternaam;

            Closed += FrmGebruikerInschrijven_Closed;
        }

        public Form Referer { get; set; }

        private void FrmGebruikerInschrijven_Closed(object sender, EventArgs e)
        {
            Referer.Show();
        }

        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cmboVakken.Visible = false;
        }

        private void cmdAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radDocent_CheckedChanged(object sender, EventArgs e)
        {
            cmboVakken.Visible = true;
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            cmboVakken.Visible = true;
        }

        private void cmdInschrijven_Click(object sender, EventArgs e)
        {
            //Een gebruiker inschrijven als Admin, Student of Docent
            Rol rol = 0;


            int gebruikerId = _inTeSchrijvenGebruiker.Id;
            Vak vak = (Vak) cmboVakken.SelectedItem;

            if (radAdmin.Checked)
            {
                //Gebruiker inschrijven als admin
                rol = Rol.Beheerder;
                vak.Id = 0;
            }
            else if (radDocent.Checked)
            {
                //Gebruiker inschrijven als docent
                rol = Rol.Docent;
            }
            else if (radStudent.Checked)
            {
                //Gebruiker inschrijven als student
                rol = Rol.Student;
            }
            else
            {
                MessageBox.Show(
                    Resources.FrmGebruikerInschrijven_cmdInschrijven_Click_Gelieve_eerst_een_rol_te_selecteren_);
                Close();
            }

            if (Database.Gebruikers.sp_GebruikerInschrijven(gebruikerId, rol, vak))
            {
                MessageBox.Show(
                    Resources.FrmGebruikerInschrijven_cmdInschrijven_Click_De_gebruiker_werd_succesvol_ingeschreven_);
                Close();
            }
            else
            {
                MessageBox.Show(
                    Resources
                        .FrmGebruikerInschrijven_cmdInschrijven_Click_De_gebruiker_kon_niet_worden_ingeschreven__Probeer_het_later_opnieuw_);
            }
        }
    }
}