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
    public partial class FrmVakAanpassen : MetroForm
    {
        private readonly Vak _vak;

        public FrmVakAanpassen(Vak vak)
        {
            InitializeComponent();
            _vak = vak;
            Closed += FrmVakAanpassen_Closed;
        }

        public Form Referer { get; set; }

        private void FrmVakAanpassen_Closed(object sender, EventArgs e)
        {
            Referer.Show();
        }

        private void frmVakAanpassen_Load(object sender, EventArgs e)
        {
            tbBeschrijving.Text = _vak.Beschrijving;
            tbNaam.Text = _vak.Naam;
            tbStudiepunten.Text = _vak.Studiepunten.ToString();
        }

        private void cmdAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
            lbMelding.Text = "";
        }

        private void cmdOpslagen_Click(object sender, EventArgs e)
        {
            lbMelding.Text = "";
            if (tbNaam.Text == "" || tbNaam.Text.Length > 50)
            {
                lbMelding.Text = Resources.VakNaamInvullen;
            }
            else
            {
                if (tbBeschrijving.Text == "" || tbBeschrijving.Text.Length > 250)
                {
                    lbMelding.Text = Resources.VakBeschrijvingInvullen;
                }
                else
                {
                    if (tbStudiepunten.Text == "")
                    {
                        lbMelding.Text = Resources.VakSTPInvullen;
                    }
                    else
                    {
                        byte result;
                        if (Byte.TryParse(tbStudiepunten.Text, out result))
                        {
                            if (Database.Vakken.VakAanpassen(_vak, tbNaam.Text, tbBeschrijving.Text, result))
                            {
                                Close();
                            }
                            else
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

        private void cmdAdvanced_Click(object sender, EventArgs e)
        {
            FrmVakAanpassenAdvanced frmvakaanpassenadvanced = new FrmVakAanpassenAdvanced(_vak) {Referer = this};
            frmvakaanpassenadvanced.ShowDialog();
        }
    }
}