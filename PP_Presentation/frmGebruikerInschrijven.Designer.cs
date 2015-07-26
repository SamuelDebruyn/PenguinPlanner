namespace PP_Presentation
{
    partial class FrmGebruikerInschrijven
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGebruikerInschrijven));
            this.lblVoornaam = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.lblAchternaam = new MetroFramework.Controls.MetroLabel();
            this.radAdmin = new MetroFramework.Controls.MetroRadioButton();
            this.radDocent = new MetroFramework.Controls.MetroRadioButton();
            this.radStudent = new MetroFramework.Controls.MetroRadioButton();
            this.cmboVakken = new MetroFramework.Controls.MetroComboBox();
            this.cmdInschrijven = new MetroFramework.Controls.MetroButton();
            this.cmdAnnuleren = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblVoornaam
            // 
            resources.ApplyResources(this.lblVoornaam, "lblVoornaam");
            this.lblVoornaam.CustomBackground = false;
            this.lblVoornaam.CustomForeColor = false;
            this.lblVoornaam.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblVoornaam.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblVoornaam.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Style = MetroFramework.MetroColorStyle.Black;
            this.lblVoornaam.StyleManager = this.metroStyleManager1;
            this.lblVoornaam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVoornaam.UseStyleColors = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblAchternaam
            // 
            resources.ApplyResources(this.lblAchternaam, "lblAchternaam");
            this.lblAchternaam.CustomBackground = false;
            this.lblAchternaam.CustomForeColor = false;
            this.lblAchternaam.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblAchternaam.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAchternaam.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Style = MetroFramework.MetroColorStyle.Black;
            this.lblAchternaam.StyleManager = this.metroStyleManager1;
            this.lblAchternaam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblAchternaam.UseStyleColors = false;
            // 
            // radAdmin
            // 
            resources.ApplyResources(this.radAdmin, "radAdmin");
            this.radAdmin.CustomBackground = false;
            this.radAdmin.CustomForeColor = false;
            this.radAdmin.FontSize = MetroFramework.MetroLinkSize.Small;
            this.radAdmin.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Style = MetroFramework.MetroColorStyle.Black;
            this.radAdmin.StyleManager = this.metroStyleManager1;
            this.radAdmin.TabStop = true;
            this.radAdmin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radAdmin.UseStyleColors = false;
            this.radAdmin.UseVisualStyleBackColor = true;
            this.radAdmin.CheckedChanged += new System.EventHandler(this.radAdmin_CheckedChanged);
            // 
            // radDocent
            // 
            resources.ApplyResources(this.radDocent, "radDocent");
            this.radDocent.CustomBackground = false;
            this.radDocent.CustomForeColor = false;
            this.radDocent.FontSize = MetroFramework.MetroLinkSize.Small;
            this.radDocent.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.radDocent.Name = "radDocent";
            this.radDocent.Style = MetroFramework.MetroColorStyle.Black;
            this.radDocent.StyleManager = this.metroStyleManager1;
            this.radDocent.TabStop = true;
            this.radDocent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radDocent.UseStyleColors = false;
            this.radDocent.UseVisualStyleBackColor = true;
            this.radDocent.CheckedChanged += new System.EventHandler(this.radDocent_CheckedChanged);
            // 
            // radStudent
            // 
            resources.ApplyResources(this.radStudent, "radStudent");
            this.radStudent.CustomBackground = false;
            this.radStudent.CustomForeColor = false;
            this.radStudent.FontSize = MetroFramework.MetroLinkSize.Small;
            this.radStudent.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.radStudent.Name = "radStudent";
            this.radStudent.Style = MetroFramework.MetroColorStyle.Black;
            this.radStudent.StyleManager = this.metroStyleManager1;
            this.radStudent.TabStop = true;
            this.radStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radStudent.UseStyleColors = false;
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // cmboVakken
            // 
            this.cmboVakken.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboVakken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboVakken.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cmboVakken.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cmboVakken.FormattingEnabled = true;
            resources.ApplyResources(this.cmboVakken, "cmboVakken");
            this.cmboVakken.Name = "cmboVakken";
            this.cmboVakken.Style = MetroFramework.MetroColorStyle.Black;
            this.cmboVakken.StyleManager = this.metroStyleManager1;
            this.cmboVakken.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmdInschrijven
            // 
            this.cmdInschrijven.Highlight = false;
            resources.ApplyResources(this.cmdInschrijven, "cmdInschrijven");
            this.cmdInschrijven.Name = "cmdInschrijven";
            this.cmdInschrijven.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdInschrijven.StyleManager = this.metroStyleManager1;
            this.cmdInschrijven.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdInschrijven.Click += new System.EventHandler(this.cmdInschrijven_Click);
            // 
            // cmdAnnuleren
            // 
            this.cmdAnnuleren.Highlight = false;
            resources.ApplyResources(this.cmdAnnuleren, "cmdAnnuleren");
            this.cmdAnnuleren.Name = "cmdAnnuleren";
            this.cmdAnnuleren.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdAnnuleren.StyleManager = this.metroStyleManager1;
            this.cmdAnnuleren.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdAnnuleren.Click += new System.EventHandler(this.cmdAnnuleren_Click);
            // 
            // frmGebruikerInschrijven
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdInschrijven);
            this.Controls.Add(this.cmdAnnuleren);
            this.Controls.Add(this.cmboVakken);
            this.Controls.Add(this.radStudent);
            this.Controls.Add(this.radDocent);
            this.Controls.Add(this.radAdmin);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGebruikerInschrijven";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblVoornaam;
        private MetroFramework.Controls.MetroLabel lblAchternaam;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroRadioButton radAdmin;
        private MetroFramework.Controls.MetroRadioButton radDocent;
        private MetroFramework.Controls.MetroRadioButton radStudent;
        private MetroFramework.Controls.MetroComboBox cmboVakken;
        private MetroFramework.Controls.MetroButton cmdInschrijven;
        private MetroFramework.Controls.MetroButton cmdAnnuleren;
    }
}