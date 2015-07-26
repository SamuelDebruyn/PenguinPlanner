#region

using System.Windows.Forms;
using PP_Presentation.Properties;

#endregion

namespace PP_Presentation
{
    public static class Utilities
    {
        public static void ConnectionLost()
        {
            MessageBox.Show(
                Resources
                    .Utilities_ConnectionLost_De_verbinding_met_de_gegevensbank_is_verbroken__De_applicatie_zal_herstart_worden_waarna_u_kan_proberen_om_opnieuw_verbinding_te_maken_,
                Resources.Utilities_ConnectionLost_Verbinding_verbroken, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Application.Restart();
        }
    }
}