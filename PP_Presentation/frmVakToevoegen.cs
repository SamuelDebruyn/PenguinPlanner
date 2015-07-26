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
    public partial class FrmVakToevoegen : MetroForm
    {
        public FrmVakToevoegen()
        {
            InitializeComponent();
            Closed += FrmVakToevoegen_Closed;
        }

        public Form Referer { get; set; }

        private void FrmVakToevoegen_Closed(object sender, EventArgs e)
        {
            Referer.Show();
        }

        private void btnVakAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
            lbMelding.Text = "";
            tbVakNaam.Text = "";
            tbVakBeschrijving.Text = "";
            tbVakStudiePunten.Text = "";
        }

        private void btnVakToevoegen_Click(object sender, EventArgs e)
        {
            lbMelding.Text = "";
            if (String.IsNullOrWhiteSpace(tbVakNaam.Text))
            {
                lbMelding.Text = Resources.VakNaamInvullen;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(tbVakBeschrijving.Text))
                {
                    lbMelding.Text = Resources.VakBeschrijvingInvullen;
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(tbVakStudiePunten.Text))
                    {
                        lbMelding.Text = Resources.VakSTPInvullen;
                    }
                    else
                    {
                        byte result;
                        if (Byte.TryParse(tbVakStudiePunten.Text, out result))
                        {
                            Vak nieuwVak = new Vak(0, tbVakNaam.Text, tbVakBeschrijving.Text, result);
                            try
                            {
                                if (Database.Vakken.VakToevoegen(nieuwVak))
                                {
                                    Close();
                                    lbMelding.Text = "";
                                    tbVakNaam.Text = "";
                                    tbVakBeschrijving.Text = "";
                                    tbVakStudiePunten.Text = "";
                                }
                                else
                                {
                                    lbMelding.Text = Resources.VakOpslaanMislukt;
                                }
                            }
                            catch (Exception)
                            {
                                lbMelding.Text = Resources.VakOpslaanMislukt;
                            }
                        }
                        else
                        {
                            lbMelding.Text = Resources.STPParseFout;
                        }
                    }
                }
            }
        }

        private void tbVakStudiePunten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}