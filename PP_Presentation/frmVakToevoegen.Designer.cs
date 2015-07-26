namespace PP_Presentation
{
    partial class FrmVakToevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVakToevoegen));
            this.tbVakNaam = new System.Windows.Forms.TextBox();
            this.tbVakBeschrijving = new System.Windows.Forms.TextBox();
            this.tbVakStudiePunten = new System.Windows.Forms.TextBox();
            this.btnVakToevoegen = new System.Windows.Forms.Button();
            this.btnVakAnnuleren = new System.Windows.Forms.Button();
            this.lbMelding = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tbVakNaam
            // 
            resources.ApplyResources(this.tbVakNaam, "tbVakNaam");
            this.tbVakNaam.Name = "tbVakNaam";
            // 
            // tbVakBeschrijving
            // 
            resources.ApplyResources(this.tbVakBeschrijving, "tbVakBeschrijving");
            this.tbVakBeschrijving.Name = "tbVakBeschrijving";
            // 
            // tbVakStudiePunten
            // 
            resources.ApplyResources(this.tbVakStudiePunten, "tbVakStudiePunten");
            this.tbVakStudiePunten.Name = "tbVakStudiePunten";
            this.tbVakStudiePunten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVakStudiePunten_KeyPress);
            // 
            // btnVakToevoegen
            // 
            resources.ApplyResources(this.btnVakToevoegen, "btnVakToevoegen");
            this.btnVakToevoegen.Name = "btnVakToevoegen";
            this.btnVakToevoegen.UseVisualStyleBackColor = true;
            this.btnVakToevoegen.Click += new System.EventHandler(this.btnVakToevoegen_Click);
            // 
            // btnVakAnnuleren
            // 
            resources.ApplyResources(this.btnVakAnnuleren, "btnVakAnnuleren");
            this.btnVakAnnuleren.Name = "btnVakAnnuleren";
            this.btnVakAnnuleren.UseVisualStyleBackColor = true;
            this.btnVakAnnuleren.Click += new System.EventHandler(this.btnVakAnnuleren_Click);
            // 
            // lbMelding
            // 
            resources.ApplyResources(this.lbMelding, "lbMelding");
            this.lbMelding.Name = "lbMelding";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.StyleManager = this.metroStyleManager1;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.StyleManager = this.metroStyleManager1;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.StyleManager = this.metroStyleManager1;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // FrmVakToevoegen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbMelding);
            this.Controls.Add(this.btnVakAnnuleren);
            this.Controls.Add(this.btnVakToevoegen);
            this.Controls.Add(this.tbVakStudiePunten);
            this.Controls.Add(this.tbVakBeschrijving);
            this.Controls.Add(this.tbVakNaam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVakToevoegen";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVakNaam;
        private System.Windows.Forms.TextBox tbVakBeschrijving;
        private System.Windows.Forms.TextBox tbVakStudiePunten;
        private System.Windows.Forms.Button btnVakToevoegen;
        private System.Windows.Forms.Button btnVakAnnuleren;
        private System.Windows.Forms.Label lbMelding;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;

    }
}