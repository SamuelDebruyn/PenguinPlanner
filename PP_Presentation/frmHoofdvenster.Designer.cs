namespace PP_Presentation
{
    partial class FrmHoofdvenster
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoofdvenster));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.cmdVerderAlsStudent = new MetroFramework.Controls.MetroButton();
            this.cmdVerderAlsDocent = new MetroFramework.Controls.MetroButton();
            this.cmdVerderAlsBeheerder = new MetroFramework.Controls.MetroButton();
            this.lblGebruiker = new MetroFramework.Controls.MetroLabel();
            this.btLogOut = new MetroFramework.Controls.MetroButton();
            this.languageControl1 = new PP_Presentation.LanguageControl();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmdVerderAlsStudent
            // 
            resources.ApplyResources(this.cmdVerderAlsStudent, "cmdVerderAlsStudent");
            this.cmdVerderAlsStudent.Highlight = false;
            this.cmdVerderAlsStudent.Name = "cmdVerderAlsStudent";
            this.cmdVerderAlsStudent.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdVerderAlsStudent.StyleManager = this.metroStyleManager1;
            this.cmdVerderAlsStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdVerderAlsStudent.Click += new System.EventHandler(this.cmdVerderAlsStudent_Click);
            // 
            // cmdVerderAlsDocent
            // 
            resources.ApplyResources(this.cmdVerderAlsDocent, "cmdVerderAlsDocent");
            this.cmdVerderAlsDocent.Highlight = false;
            this.cmdVerderAlsDocent.Name = "cmdVerderAlsDocent";
            this.cmdVerderAlsDocent.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdVerderAlsDocent.StyleManager = this.metroStyleManager1;
            this.cmdVerderAlsDocent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdVerderAlsDocent.Click += new System.EventHandler(this.cmdVerderAlsDocent_Click);
            // 
            // cmdVerderAlsBeheerder
            // 
            resources.ApplyResources(this.cmdVerderAlsBeheerder, "cmdVerderAlsBeheerder");
            this.cmdVerderAlsBeheerder.Highlight = false;
            this.cmdVerderAlsBeheerder.Name = "cmdVerderAlsBeheerder";
            this.cmdVerderAlsBeheerder.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdVerderAlsBeheerder.StyleManager = this.metroStyleManager1;
            this.cmdVerderAlsBeheerder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdVerderAlsBeheerder.Click += new System.EventHandler(this.cmdVerderAlsBeheerder_Click);
            // 
            // lblGebruiker
            // 
            resources.ApplyResources(this.lblGebruiker, "lblGebruiker");
            this.lblGebruiker.CustomBackground = false;
            this.lblGebruiker.CustomForeColor = false;
            this.lblGebruiker.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblGebruiker.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblGebruiker.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Style = MetroFramework.MetroColorStyle.Black;
            this.lblGebruiker.StyleManager = this.metroStyleManager1;
            this.lblGebruiker.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblGebruiker.UseStyleColors = false;
            // 
            // btLogOut
            // 
            resources.ApplyResources(this.btLogOut, "btLogOut");
            this.btLogOut.Highlight = false;
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Style = MetroFramework.MetroColorStyle.Black;
            this.btLogOut.StyleManager = this.metroStyleManager1;
            this.btLogOut.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // languageControl1
            // 
            resources.ApplyResources(this.languageControl1, "languageControl1");
            this.languageControl1.Name = "languageControl1";
            // 
            // FrmHoofdvenster
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.languageControl1);
            this.Controls.Add(this.cmdVerderAlsBeheerder);
            this.Controls.Add(this.cmdVerderAlsDocent);
            this.Controls.Add(this.cmdVerderAlsStudent);
            this.MaximizeBox = false;
            this.Name = "FrmHoofdvenster";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHoofdvenster_FormClosed);
            this.Load += new System.EventHandler(this.frmHoofdvenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton cmdVerderAlsBeheerder;
        private MetroFramework.Controls.MetroButton cmdVerderAlsDocent;
        private MetroFramework.Controls.MetroButton cmdVerderAlsStudent;
        private LanguageControl languageControl1;
        private MetroFramework.Controls.MetroLabel lblGebruiker;
        private MetroFramework.Controls.MetroButton btLogOut;
    }
}