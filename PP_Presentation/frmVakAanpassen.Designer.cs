namespace PP_Presentation
{
    partial class FrmVakAanpassen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVakAanpassen));
            this.cmdAnnuleren = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.cmdOpslagen = new MetroFramework.Controls.MetroButton();
            this.lblNaam = new MetroFramework.Controls.MetroLabel();
            this.tbNaam = new MetroFramework.Controls.MetroTextBox();
            this.lbBeschrijving = new MetroFramework.Controls.MetroLabel();
            this.tbBeschrijving = new MetroFramework.Controls.MetroTextBox();
            this.lbStudiepunten = new MetroFramework.Controls.MetroLabel();
            this.tbStudiepunten = new MetroFramework.Controls.MetroTextBox();
            this.lbMelding = new MetroFramework.Controls.MetroLabel();
            this.cmdAdvanced = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
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
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmdOpslagen
            // 
            this.cmdOpslagen.Highlight = false;
            resources.ApplyResources(this.cmdOpslagen, "cmdOpslagen");
            this.cmdOpslagen.Name = "cmdOpslagen";
            this.cmdOpslagen.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdOpslagen.StyleManager = this.metroStyleManager1;
            this.cmdOpslagen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdOpslagen.Click += new System.EventHandler(this.cmdOpslagen_Click);
            // 
            // lblNaam
            // 
            resources.ApplyResources(this.lblNaam, "lblNaam");
            this.lblNaam.CustomBackground = false;
            this.lblNaam.CustomForeColor = false;
            this.lblNaam.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNaam.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNaam.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Style = MetroFramework.MetroColorStyle.Black;
            this.lblNaam.StyleManager = this.metroStyleManager1;
            this.lblNaam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNaam.UseStyleColors = false;
            // 
            // tbNaam
            // 
            this.tbNaam.CustomBackground = false;
            this.tbNaam.CustomForeColor = false;
            this.tbNaam.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbNaam.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            resources.ApplyResources(this.tbNaam, "tbNaam");
            this.tbNaam.Multiline = false;
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.SelectedText = "";
            this.tbNaam.Style = MetroFramework.MetroColorStyle.Black;
            this.tbNaam.StyleManager = this.metroStyleManager1;
            this.tbNaam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNaam.UseStyleColors = false;
            // 
            // lbBeschrijving
            // 
            resources.ApplyResources(this.lbBeschrijving, "lbBeschrijving");
            this.lbBeschrijving.CustomBackground = false;
            this.lbBeschrijving.CustomForeColor = false;
            this.lbBeschrijving.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lbBeschrijving.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lbBeschrijving.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lbBeschrijving.Name = "lbBeschrijving";
            this.lbBeschrijving.Style = MetroFramework.MetroColorStyle.Black;
            this.lbBeschrijving.StyleManager = this.metroStyleManager1;
            this.lbBeschrijving.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbBeschrijving.UseStyleColors = false;
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.CustomBackground = false;
            this.tbBeschrijving.CustomForeColor = false;
            this.tbBeschrijving.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbBeschrijving.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            resources.ApplyResources(this.tbBeschrijving, "tbBeschrijving");
            this.tbBeschrijving.Multiline = true;
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.SelectedText = "";
            this.tbBeschrijving.Style = MetroFramework.MetroColorStyle.Black;
            this.tbBeschrijving.StyleManager = this.metroStyleManager1;
            this.tbBeschrijving.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBeschrijving.UseStyleColors = false;
            // 
            // lbStudiepunten
            // 
            resources.ApplyResources(this.lbStudiepunten, "lbStudiepunten");
            this.lbStudiepunten.CustomBackground = false;
            this.lbStudiepunten.CustomForeColor = false;
            this.lbStudiepunten.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lbStudiepunten.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lbStudiepunten.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lbStudiepunten.Name = "lbStudiepunten";
            this.lbStudiepunten.Style = MetroFramework.MetroColorStyle.Black;
            this.lbStudiepunten.StyleManager = this.metroStyleManager1;
            this.lbStudiepunten.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbStudiepunten.UseStyleColors = false;
            // 
            // tbStudiepunten
            // 
            this.tbStudiepunten.CustomBackground = false;
            this.tbStudiepunten.CustomForeColor = false;
            this.tbStudiepunten.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.tbStudiepunten.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            resources.ApplyResources(this.tbStudiepunten, "tbStudiepunten");
            this.tbStudiepunten.Multiline = false;
            this.tbStudiepunten.Name = "tbStudiepunten";
            this.tbStudiepunten.SelectedText = "";
            this.tbStudiepunten.Style = MetroFramework.MetroColorStyle.Black;
            this.tbStudiepunten.StyleManager = this.metroStyleManager1;
            this.tbStudiepunten.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStudiepunten.UseStyleColors = false;
            // 
            // lbMelding
            // 
            resources.ApplyResources(this.lbMelding, "lbMelding");
            this.lbMelding.CustomBackground = false;
            this.lbMelding.CustomForeColor = false;
            this.lbMelding.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lbMelding.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lbMelding.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lbMelding.Name = "lbMelding";
            this.lbMelding.Style = MetroFramework.MetroColorStyle.Black;
            this.lbMelding.StyleManager = this.metroStyleManager1;
            this.lbMelding.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbMelding.UseStyleColors = false;
            // 
            // cmdAdvanced
            // 
            this.cmdAdvanced.Highlight = false;
            resources.ApplyResources(this.cmdAdvanced, "cmdAdvanced");
            this.cmdAdvanced.Name = "cmdAdvanced";
            this.cmdAdvanced.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdAdvanced.StyleManager = this.metroStyleManager1;
            this.cmdAdvanced.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdAdvanced.Click += new System.EventHandler(this.cmdAdvanced_Click);
            // 
            // FrmVakAanpassen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdAdvanced);
            this.Controls.Add(this.lbMelding);
            this.Controls.Add(this.tbStudiepunten);
            this.Controls.Add(this.lbStudiepunten);
            this.Controls.Add(this.tbBeschrijving);
            this.Controls.Add(this.lbBeschrijving);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.cmdOpslagen);
            this.Controls.Add(this.cmdAnnuleren);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVakAanpassen";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.Load += new System.EventHandler(this.frmVakAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdAnnuleren;
        private MetroFramework.Controls.MetroButton cmdOpslagen;
        private MetroFramework.Controls.MetroLabel lblNaam;
        private MetroFramework.Controls.MetroTextBox tbNaam;
        private MetroFramework.Controls.MetroLabel lbBeschrijving;
        private MetroFramework.Controls.MetroTextBox tbBeschrijving;
        private MetroFramework.Controls.MetroLabel lbStudiepunten;
        private MetroFramework.Controls.MetroTextBox tbStudiepunten;
        private MetroFramework.Controls.MetroLabel lbMelding;
        private MetroFramework.Controls.MetroButton cmdAdvanced;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}