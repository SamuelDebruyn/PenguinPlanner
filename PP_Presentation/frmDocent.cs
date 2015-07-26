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
    public partial class FrmDocent : MetroForm
    {
        public FrmDocent()
        {
            InitializeComponent();

            /*
             *  Studenten weergeven
             */
            dgrvStudenten.DataSource = Database.Gebruikers.sp_AlleGebruikersPerVak(Database.Vakken.Lijst[0], Rol.Student);
            dgrvStudenten.AutoGenerateColumns = true;
            dgrvStudenten.Columns[0].Visible = false;
            dgrvStudenten.Columns[1].HeaderText = Resources.Voornaam;
            dgrvStudenten.Columns[2].HeaderText = Resources.Achternaam;
            dgrvStudenten.Columns[3].HeaderText = Resources.Email;
            dgrvStudenten.Columns[4].HeaderText = Resources.Geboortedatum;

            /*
             *  Mededelingen weergeven
             */
            dgrvMededelingen.DataSource = Database.Opdrachten.MededelingenPerGebruiker;
            dgrvMededelingen.AutoGenerateColumns = true;
            dgrvMededelingen.Columns[0].Visible = false;
            dgrvMededelingen.Columns[2].Visible = false;
            dgrvMededelingen.Columns[1].HeaderText = Resources.Vak;
            dgrvMededelingen.Columns[3].HeaderText = Resources.Beschrijving;
            dgrvMededelingen.Columns[4].HeaderText = Resources.Einddatum;
            dgrvMededelingen.Columns[5].HeaderText = Resources.Begindatum;

            /*
             *  Taken weergeven
             */
            dgrvTaken.DataSource = Database.Opdrachten.TakenPerGebruiker;
            dgrvTaken.AutoGenerateColumns = true;
            dgrvTaken.Columns[0].Visible = false;
            dgrvTaken.Columns[2].Visible = false;
            dgrvTaken.Columns[1].HeaderText = Resources.Vak;
            dgrvTaken.Columns[3].HeaderText = Resources.Beschrijving;
            dgrvTaken.Columns[4].HeaderText = Resources.Einddatum;
            dgrvTaken.Columns[5].HeaderText = Resources.Begindatum;

            /*
             *  Testen weergeven
             */
            dgrvTesten.DataSource = Database.Opdrachten.TestenPerGebruiker;
            dgrvTesten.AutoGenerateColumns = true;
            dgrvTesten.Columns[0].Visible = false;
            dgrvTesten.Columns[2].Visible = false;
            dgrvTesten.Columns[1].HeaderText = Resources.Vak;
            dgrvTesten.Columns[3].HeaderText = Resources.Beschrijving;
            dgrvTesten.Columns[4].HeaderText = Resources.Einddatum;
            dgrvTesten.Columns[5].HeaderText = Resources.Begindatum;

            /*
             *  Alles van mededelingtoevoegen hiden
             */
            lblBeginDatum.Hide();
            lblEindDatum.Hide();
            tbBeschrijving.Hide();
            comboVakken.Hide();
            dtpBeginDatum.Hide();
            dtpEindDatum.Hide();

            /*
             *  Alles van taaktoevoegen hiden
             */
            lblBeginDatumTaak.Hide();
            lblEindDatumTaak.Hide();
            txtboxTaakOmschrijving.Hide();
            cmboxVakkenTaken.Hide();
            dtpBeginDatumTaak.Hide();
            dtpEindDatumTaak.Hide();

            /*
             *  Alles van testtoevoegen hiden
             */
            lblBeginDatumTest.Hide();
            lblEindDatumTest.Hide();
            txtboxTestOmschrijving.Hide();
            cmBoxVakkenTesten.Hide();
            dtpBeginDatumTest.Hide();
            dtpEindDatumTest.Hide();

            /*
            *  Combobox vakken(Taken) opvullen
            */
            bsVakkenLijst.DataSource = Database.Vakken.Lijst;
            cmboxVakkenTaken.DataSource = bsVakkenLijst.DataSource;
            cmboxVakkenTaken.DisplayMember = "Naam";
            cmboxVakkenTaken.ValueMember = "Naam";

            /*
            *  Combobox vakken (Testen) opvullen
            */
            bsVakkenLijst.DataSource = Database.Vakken.Lijst;
            cmBoxVakkenTesten.DataSource = bsVakkenLijst.DataSource;
            cmBoxVakkenTesten.DisplayMember = "Naam";
            cmBoxVakkenTesten.ValueMember = "Naam";

            /*
            *  Combobox vakken (Studenten) opvullen
            */
            bsVakkenLijst.DataSource = Database.Vakken.Lijst;
            cmboVakkenDieStudentenVolgen.DataSource = bsVakkenLijst.DataSource;
            cmboVakkenDieStudentenVolgen.DisplayMember = "Naam";
            cmboVakkenDieStudentenVolgen.ValueMember = "Naam";

            /*
            *  Combobox vakken opvullen (Mededeling toevoegen)
            */
            bsVakkenLijst.DataSource = Database.Vakken.Lijst;
            comboVakken.DataSource = bsVakkenLijst.DataSource;
            comboVakken.DisplayMember = "Naam";
            comboVakken.ValueMember = "Naam";

            lblFoutMededeling.Hide();
        }

        public Form Referer { get; set; }

        private void cmdMededelingToevoegen_Click(object sender, EventArgs e)
        {
            tbBeschrijving.Show();
            if (String.IsNullOrWhiteSpace(tbBeschrijving.Text))
            {
                /*
                 *  Controls weergeven
                 */
                lblBeginDatum.Show();
                lblEindDatum.Show();
                tbBeschrijving.Show();
                comboVakken.Show();
                dtpBeginDatum.Show();
                dtpEindDatum.Show();
            }
            else if (tbBeschrijving.Text.Length > 250)
            {
                lblFoutMededeling.Show();
                lblFoutMededeling.Text =
                    Resources
                        .FrmDocent_cmdMededelingToevoegen_Click_Gelieve_een_beschrijving_op_te_geven_die_langer_is_dan_250_tekens_;
            }
            else if (comboVakken.SelectedIndex == -1)
            {
                lblFoutMededeling.Show();
                lblFoutMededeling.Text =
                    Resources.FrmDocent_cmdMededelingToevoegen_Click_Gelieve_eerst_een_vak_te_selecteren_;
            }
            else
            {
                Opdracht mededeling = new Opdracht(0, tbBeschrijving.Text, dtpBeginDatum.Value,
                    dtpEindDatum.Value, (Vak)comboVakken.SelectedItem);
                try
                {
                    if (Database.Opdrachten.OpdrachtToevoegen(mededeling, OpdrachtSoort.Mededeling))
                    {
                        tbBeschrijving.Text = "";
                        lblFoutMededeling.Show();
                        lblFoutMededeling.Text =
                            Resources
                                .FrmDocent_cmdMededelingToevoegen_Click_De_mededeling_werd_succesvol_toegevoegd_;
                        dgrvMededelingen.DataSource = Database.Opdrachten.MededelingenPerGebruiker;
                    }
                    else
                    {
                        lblFoutMededeling.Show();
                        lblFoutMededeling.Text =
                            Resources
                                .FrmDocent_cmdMededelingToevoegen_Click_De_mededeling_kon_niet_worden_toegevoegd_;
                    }
                }
                catch (Exception)
                {
                    lblFoutMededeling.Show();
                    lblFoutMededeling.Text =
                        Resources
                            .FrmDocent_cmdMededelingToevoegen_Click_De_mededeling_kon_niet_worden_toegevoegd_;
                }
            }
        }

        private void cmdTakenToevoegen_Click(object sender, EventArgs e)
        {
            txtboxTaakOmschrijving.Show();
            if (txtboxTaakOmschrijving.Text == "")
            {
                /*
                 *  Controls weergeven
                 */
                lblBeginDatumTaak.Show();
                lblEindDatumTaak.Show();
                txtboxTaakOmschrijving.Show();
                cmboxVakkenTaken.Show();
                dtpBeginDatumTaak.Show();
                dtpEindDatumTaak.Show();
            }
            else if (txtboxTaakOmschrijving.Text.Length > 250)
            {
                lblFoutTaak.Show();
                lblFoutTaak.Text =
                    Resources
                        .FrmDocent_cmdMededelingToevoegen_Click_Gelieve_een_beschrijving_op_te_geven_die_langer_is_dan_250_tekens_;
            }
            else if (cmboxVakkenTaken.SelectedIndex == -1)
            {
                lblFoutTaak.Show();
                lblFoutTaak.Text =
                    Resources.FrmDocent_cmdMededelingToevoegen_Click_Gelieve_eerst_een_vak_te_selecteren_;
            }
            else
            {
                Opdracht taak = new Opdracht(0, txtboxTaakOmschrijving.Text, dtpBeginDatumTaak.Value,
                    dtpEindDatumTaak.Value, (Vak)cmboxVakkenTaken.SelectedItem);
                try
                {
                    if (Database.Opdrachten.OpdrachtToevoegen(taak, OpdrachtSoort.Taak))
                    {
                        txtboxTaakOmschrijving.Text = "";
                        lblFoutTaak.Show();
                        lblFoutTaak.Text =
                            Resources.FrmDocent_cmdTakenToevoegen_Click_De_taak_werd_succesvol_toegevoegd_;
                        dgrvTaken.DataSource = Database.Opdrachten.TakenPerGebruiker;
                    }
                    else
                    {
                        lblFoutTaak.Show();
                        lblFoutTaak.Text =
                            Resources.FrmDocent_cmdTakenToevoegen_Click_De_taak_kon_niet_worden_toegevoegd_;
                    }
                }
                catch (Exception)
                {
                    lblFoutTaak.Show();
                    lblFoutTaak.Text =
                        Resources.FrmDocent_cmdTakenToevoegen_Click_De_taak_kon_niet_worden_toegevoegd_;
                }
            }
        }

        private void cmdTestToevoegen_Click(object sender, EventArgs e)
        {
            txtboxTestOmschrijving.Show();
            if (txtboxTestOmschrijving.Text == "")
            {
                /*
                 *  Controls weergeven
                 */
                lblBeginDatumTest.Show();
                lblEindDatumTaak.Show();
                txtboxTestOmschrijving.Show();
                cmBoxVakkenTesten.Show();
                dtpBeginDatumTest.Show();
                dtpEindDatumTest.Show();
            }
            else if (txtboxTestOmschrijving.Text.Length > 250)
            {
                lblFoutTest.Show();
                lblFoutTest.Text =
                    Resources
                        .FrmDocent_cmdMededelingToevoegen_Click_Gelieve_een_beschrijving_op_te_geven_die_langer_is_dan_250_tekens_;
            }
            else if (cmBoxVakkenTesten.SelectedIndex == -1)
            {
                lblFoutTest.Show();
                lblFoutTest.Text =
                    Resources.FrmDocent_cmdMededelingToevoegen_Click_Gelieve_eerst_een_vak_te_selecteren_;
            }
            else
            {
                Opdracht test = new Opdracht(0, txtboxTestOmschrijving.Text, dtpBeginDatumTest.Value,
                    dtpEindDatumTest.Value, (Vak)cmBoxVakkenTesten.SelectedItem);
                try
                {
                    if (Database.Opdrachten.OpdrachtToevoegen(test, OpdrachtSoort.Test))
                    {
                        txtboxTestOmschrijving.Text = "";
                        lblFoutTest.Show();
                        lblFoutTest.Text =
                            Resources.FrmDocent_cmdTestToevoegen_Click_De_test_werd_succesvol_ingepland_;
                        dgrvTesten.DataSource = Database.Opdrachten.TestenPerGebruiker;
                    }
                    else
                    {
                        lblFoutTest.Show();
                        lblFoutTest.Text =
                            Resources
                                .FrmDocent_cmdTestToevoegen_Click_De_test_kon_niet_worden_toegevoegd__Probeer_het_later_opnieuw_;
                    }
                }
                catch (Exception)
                {
                    lblFoutTest.Show();
                    lblFoutTest.Text =
                        Resources
                            .FrmDocent_cmdTestToevoegen_Click_De_test_kon_niet_worden_toegevoegd__Probeer_het_later_opnieuw_;
                }
            }
        }
        private void bttnMededelingCancel_Click(object sender, EventArgs e)
        {
            /*
             *  Beschrijving leegmaken en controls verbergen
             */
            lblBeginDatum.Hide();
            lblEindDatum.Hide();
            tbBeschrijving.Hide();
            tbBeschrijving.Text = "";
            comboVakken.Hide();
            dtpBeginDatum.Hide();
            dtpEindDatum.Hide();
            lblFoutMededeling.Hide();
        }


        private void cmdTaakCancel_Click(object sender, EventArgs e)
        {
            /*
             *  Beschrijving leegmaken en controls verbergen
             */
            lblBeginDatumTaak.Hide();
            lblEindDatumTaak.Hide();
            txtboxTaakOmschrijving.Hide();
            txtboxTaakOmschrijving.Text = "";
            cmboxVakkenTaken.Hide();
            dtpBeginDatumTaak.Hide();
            dtpEindDatumTaak.Hide();
            lblFoutTaak.Hide();
        }

        private void cmdTestCancel_Click(object sender, EventArgs e)
        {
            /*
             *  Beschrijving leegmaken en controls verbergen
             */
            lblBeginDatumTest.Hide();
            lblEindDatumTest.Hide();
            txtboxTestOmschrijving.Hide();
            txtboxTestOmschrijving.Text = "";
            cmBoxVakkenTesten.Hide();
            dtpBeginDatumTest.Hide();
            dtpEindDatumTest.Hide();
            lblFoutTest.Hide();
        }


        private void frmDocent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referer.Show();
        }

        private void cmboVakkenDieStudentenVolgen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgrvStudenten.DataSource =
                    Database.Gebruikers.sp_AlleGebruikersPerVak((Vak)cmboVakkenDieStudentenVolgen.SelectedItem,
                        Rol.Student);
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
            dgrvStudenten.AutoGenerateColumns = true;
            dgrvStudenten.Columns[0].Visible = false;
        }
    }
}