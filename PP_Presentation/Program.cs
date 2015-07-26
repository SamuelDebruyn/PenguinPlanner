#region

using System;
using System.Threading;
using System.Windows.Forms;
using PP_Presentation.Properties;

#endregion

namespace PP_Presentation
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInloggen());

            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            UnHandledExceptionHandler();
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            UnHandledExceptionHandler();
        }

        private static void UnHandledExceptionHandler()
        {
            MessageBox.Show(
                Resources
                    .Program_Application_ThreadException_Er_trad_een_onbekende_fout_op__Neem_aub_contact_op_met_Penguin_Studio__De_applicatie_zal_zo_meteen_herstart_worden_,
                Resources.Program_Application_ThreadException_Onbekende_fout, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Application.Restart();
        }
    }
}