namespace PP_Presentation
{
    partial class FrmInloggen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInloggen));
            this.cmdInloggen = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.lblGebruikersnaam = new MetroFramework.Controls.MetroLabel();
            this.lblWachtwoord = new MetroFramework.Controls.MetroLabel();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.cmdOfficieelInloggen = new MetroFramework.Controls.MetroButton();
            this.pbPenguin = new System.Windows.Forms.PictureBox();
            this.languageControl1 = new PP_Presentation.LanguageControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenguin)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdInloggen
            // 
            this.cmdInloggen.Highlight = true;
            resources.ApplyResources(this.cmdInloggen, "cmdInloggen");
            this.cmdInloggen.Name = "cmdInloggen";
            this.cmdInloggen.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdInloggen.StyleManager = this.metroStyleManager1;
            this.cmdInloggen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdInloggen.Click += new System.EventHandler(this.cmdInloggen_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblGebruikersnaam
            // 
            resources.ApplyResources(this.lblGebruikersnaam, "lblGebruikersnaam");
            this.lblGebruikersnaam.CustomBackground = false;
            this.lblGebruikersnaam.CustomForeColor = false;
            this.lblGebruikersnaam.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGebruikersnaam.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblGebruikersnaam.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Style = MetroFramework.MetroColorStyle.Black;
            this.lblGebruikersnaam.StyleManager = this.metroStyleManager1;
            this.lblGebruikersnaam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblGebruikersnaam.UseStyleColors = false;
            // 
            // lblWachtwoord
            // 
            resources.ApplyResources(this.lblWachtwoord, "lblWachtwoord");
            this.lblWachtwoord.CustomBackground = false;
            this.lblWachtwoord.CustomForeColor = false;
            this.lblWachtwoord.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWachtwoord.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblWachtwoord.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Style = MetroFramework.MetroColorStyle.Black;
            this.lblWachtwoord.StyleManager = this.metroStyleManager1;
            this.lblWachtwoord.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblWachtwoord.UseStyleColors = false;
            // 
            // txtGebruikersnaam
            // 
            resources.ApplyResources(this.txtGebruikersnaam, "txtGebruikersnaam");
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            // 
            // txtWachtwoord
            // 
            resources.ApplyResources(this.txtWachtwoord, "txtWachtwoord");
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWachtwoord_KeyUp);
            // 
            // cmdOfficieelInloggen
            // 
            resources.ApplyResources(this.cmdOfficieelInloggen, "cmdOfficieelInloggen");
            this.cmdOfficieelInloggen.Highlight = true;
            this.cmdOfficieelInloggen.Name = "cmdOfficieelInloggen";
            this.cmdOfficieelInloggen.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdOfficieelInloggen.StyleManager = this.metroStyleManager1;
            this.cmdOfficieelInloggen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdOfficieelInloggen.Click += new System.EventHandler(this.cmdOfficieelInloggen_Click);
            // 
            // pbPenguin
            // 
            this.pbPenguin.Image = global::PP_Presentation.Properties.Resources.rsz_penguin;
            resources.ApplyResources(this.pbPenguin, "pbPenguin");
            this.pbPenguin.Name = "pbPenguin";
            this.pbPenguin.TabStop = false;
            // 
            // languageControl1
            // 
            resources.ApplyResources(this.languageControl1, "languageControl1");
            this.languageControl1.Name = "languageControl1";
            // 
            // FrmInloggen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageControl1);
            this.Controls.Add(this.cmdOfficieelInloggen);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.cmdInloggen);
            this.Controls.Add(this.pbPenguin);
            this.MaximizeBox = false;
            this.Name = "FrmInloggen";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            ((System.ComponentModel.ISupportInitialize)(this.pbPenguin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdInloggen;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel lblGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private MetroFramework.Controls.MetroLabel lblWachtwoord;
        private MetroFramework.Controls.MetroButton cmdOfficieelInloggen;
        private System.Windows.Forms.PictureBox pbPenguin;
        private LanguageControl languageControl1;





    }
}