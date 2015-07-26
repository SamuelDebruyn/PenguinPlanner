#region

using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using PP_Business;
using PP_Entity;

#endregion

namespace PP_Presentation
{
    /// <summary>
    ///     Language control om de huidige taal aan te passen.
    /// </summary>
    public partial class LanguageControl : UserControl
    {
        private CultureInfo _currentLanguage;

        /// <summary>
        ///     De standaardtaal is Nederlands.
        /// </summary>
        public LanguageControl()
        {
            InitializeComponent();
            _currentLanguage = new CultureInfo("NL");
        }

        private void UpdateUserInDatabase(Taal nieuw)
        {
            try
            {
                if (Database.Gebruikers.InlogGebruiker != null)
                {
                    Database.Gebruikers.InlogGebruiker.Taal = nieuw;
                    Database.Gebruikers.GebruikerUpdaten(Database.Gebruikers.InlogGebruiker);
                }
            }
            catch (Exception)
            {
                //NOP: user is not logged in or connection lost
            }
        }

        public void ChangeLanguage(Taal newLanguage)
        {
            switch (newLanguage)
            {
                default:
                    // ReSharper disable once RedundantCaseLabel
                case Taal.Nederlands:
                    _currentLanguage = new CultureInfo("NL");
                    break;
                case Taal.Engels:
                    _currentLanguage = new CultureInfo("EN");
                    break;
            }

            Thread.CurrentThread.CurrentUICulture = _currentLanguage;

            /* Zorgt voor ontbrekende LanguageControl in hoofdvenster
             * 
            foreach (Form openForm in Application.OpenForms)
            {
                UpdateForm(openForm);
            }
             */

            Form parent = Parent as Form;
            UpdateForm(parent);

            UpdateUserInDatabase(newLanguage);
        }

        private void UpdateForm(Form form)
        {
            if (form != null)
            {
                form.SuspendLayout();

                ComponentResourceManager rm = new ComponentResourceManager(Parent.GetType());

                foreach (Control ctrl in form.Controls)
                    RefreshControls(ctrl, rm);

                rm.ApplyResources(form, form.Name, _currentLanguage);

                form.ResumeLayout();
            }
        }

        /// <summary>
        ///     De gebruiker kiest ervoor om de taal te wijzigen. We wijzigen de taal en zorgen ervoor dat de controls de nieuwe
        ///     taal gebruiken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.Text)
            {
                default:
                    // ReSharper disable once RedundantCaseLabel
                case "NL":
                    ChangeLanguage(Taal.Nederlands);
                    break;
                case "EN":
                    ChangeLanguage(Taal.Engels);
                    break;
            }
        }

        /// <summary>
        ///     De huidige geladen controls moeten de nieuwe resource (taal) gebruiken.
        /// </summary>
        /// <param name="ctrl">De control die we willen bijwerken.</param>
        /// <param name="res">De resources die we gebruiken bij de control.</param>
        private void RefreshControls(Control ctrl, ComponentResourceManager res)
        {
            ctrl.SuspendLayout();

            res.ApplyResources(ctrl, ctrl.Name, _currentLanguage);
            foreach (Control subCtrl in ctrl.Controls)
                RefreshControls(subCtrl, res);

            ctrl.ResumeLayout();
        }
    }
}