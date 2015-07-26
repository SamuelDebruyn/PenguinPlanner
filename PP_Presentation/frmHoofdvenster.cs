#region

using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using PP_Business;
using PP_Entity;
using PP_Presentation.Properties;

#endregion

namespace PP_Presentation
{
    public partial class FrmHoofdvenster : MetroForm
    {
        private FrmBeheerder _frmBeheerder;
        private FrmDocent _frmDocent;
        private FrmStudent _frmStudent;

        public FrmHoofdvenster()
        {
            InitializeComponent();
        }

        public Form Referer { get; set; }

        private void frmHoofdvenster_Load(object sender, EventArgs e)
        {
            cmdVerderAlsBeheerder.Hide();
            cmdVerderAlsDocent.Hide();
            cmdVerderAlsStudent.Hide();
            if (Database.Gebruikers.InlogGebruiker.Rollen.Contains(Rol.Beheerder))
                cmdVerderAlsBeheerder.Show();
            if (Database.Gebruikers.InlogGebruiker.Rollen.Contains(Rol.Docent))
                cmdVerderAlsDocent.Show();
            if (Database.Gebruikers.InlogGebruiker.Rollen.Contains(Rol.Student))
                cmdVerderAlsStudent.Show();

            lblGebruiker.Text = Database.Gebruikers.InlogGebruiker.Voornaam + Resources.space +
                                Database.Gebruikers.InlogGebruiker.Achternaam;
        }

        private void cmdVerderAlsStudent_Click(object sender, EventArgs e)
        {
            Database.Gebruikers.InlogGebruiker.Rol = Rol.Student;
            try
            {
                _frmStudent = new FrmStudent {Referer = this};
                _frmStudent.Show();
                Hide();
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
        }

        private void cmdVerderAlsDocent_Click(object sender, EventArgs e)
        {
            Database.Gebruikers.InlogGebruiker.Rol = Rol.Docent;
            try
            {
                _frmDocent = new FrmDocent {Referer = this};
                _frmDocent.Show();
                Hide();
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
        }

        private void cmdVerderAlsBeheerder_Click(object sender, EventArgs e)
        {
            Database.Gebruikers.InlogGebruiker.Rol = Rol.Beheerder;
            try
            {
                _frmBeheerder = new FrmBeheerder {Referer = this};
                _frmBeheerder.Show();
                Hide();
            }
            catch (Exception)
            {
                Utilities.ConnectionLost();
            }
        }

        private void frmHoofdvenster_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referer.Close();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Database.Gebruikers.InlogGebruiker = null;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == typeof (FrmInloggen))
                {
                    openForm.Show();
                }
            }
            Hide();
        }
    }
}