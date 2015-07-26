namespace PP_Presentation
{
    partial class FrmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.tbcStudent = new MetroFramework.Controls.MetroTabControl();
            this.tabMededelingen = new MetroFramework.Controls.MetroTabPage();
            this.dgrvMededelingen = new System.Windows.Forms.DataGridView();
            this.lblMededelingen = new MetroFramework.Controls.MetroLabel();
            this.lstMededelingen = new System.Windows.Forms.ListBox();
            this.tabVakken = new MetroFramework.Controls.MetroTabPage();
            this.cmdMemoOpslagen = new MetroFramework.Controls.MetroButton();
            this.lblEmailInhoud = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblAchternaamInhoud = new MetroFramework.Controls.MetroLabel();
            this.lblAchternaam = new MetroFramework.Controls.MetroLabel();
            this.lblNaamInhoud = new MetroFramework.Controls.MetroLabel();
            this.lblNaam = new MetroFramework.Controls.MetroLabel();
            this.lblLeerkracht = new MetroFramework.Controls.MetroLabel();
            this.lblMemo = new MetroFramework.Controls.MetroLabel();
            this.rtxtMemo = new System.Windows.Forms.RichTextBox();
            this.languageControl1 = new PP_Presentation.LanguageControl();
            this.lstVakken = new System.Windows.Forms.ListBox();
            this.lblVakken = new MetroFramework.Controls.MetroLabel();
            this.tabTaken = new MetroFramework.Controls.MetroTabPage();
            this.dgrvTaken = new System.Windows.Forms.DataGridView();
            this.lblTaken = new MetroFramework.Controls.MetroLabel();
            this.tabTesten = new MetroFramework.Controls.MetroTabPage();
            this.dgrvTesten = new System.Windows.Forms.DataGridView();
            this.lblTesten = new MetroFramework.Controls.MetroLabel();
            this.dgrvMemo = new System.Windows.Forms.DataGridView();
            this.languageControl2 = new PP_Presentation.LanguageControl();
            this.tbcStudent.SuspendLayout();
            this.tabMededelingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMededelingen)).BeginInit();
            this.tabVakken.SuspendLayout();
            this.tabTaken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTaken)).BeginInit();
            this.tabTesten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTesten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMemo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbcStudent
            // 
            this.tbcStudent.Controls.Add(this.tabMededelingen);
            this.tbcStudent.Controls.Add(this.tabVakken);
            this.tbcStudent.Controls.Add(this.tabTaken);
            this.tbcStudent.Controls.Add(this.tabTesten);
            this.tbcStudent.CustomBackground = false;
            this.tbcStudent.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.tbcStudent.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            resources.ApplyResources(this.tbcStudent, "tbcStudent");
            this.tbcStudent.Name = "tbcStudent";
            this.tbcStudent.SelectedIndex = 1;
            this.tbcStudent.Style = MetroFramework.MetroColorStyle.Black;
            this.tbcStudent.StyleManager = this.metroStyleManager1;
            this.tbcStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbcStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbcStudent.UseStyleColors = false;
            // 
            // tabMededelingen
            // 
            this.tabMededelingen.Controls.Add(this.dgrvMededelingen);
            this.tabMededelingen.Controls.Add(this.lblMededelingen);
            this.tabMededelingen.Controls.Add(this.lstMededelingen);
            this.tabMededelingen.CustomBackground = false;
            this.tabMededelingen.HorizontalScrollbar = false;
            this.tabMededelingen.HorizontalScrollbarBarColor = true;
            this.tabMededelingen.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMededelingen.HorizontalScrollbarSize = 8;
            resources.ApplyResources(this.tabMededelingen, "tabMededelingen");
            this.tabMededelingen.Name = "tabMededelingen";
            this.tabMededelingen.Style = MetroFramework.MetroColorStyle.Black;
            this.tabMededelingen.StyleManager = this.metroStyleManager1;
            this.tabMededelingen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabMededelingen.VerticalScrollbar = false;
            this.tabMededelingen.VerticalScrollbarBarColor = true;
            this.tabMededelingen.VerticalScrollbarHighlightOnWheel = false;
            this.tabMededelingen.VerticalScrollbarSize = 8;
            // 
            // dgrvMededelingen
            // 
            this.dgrvMededelingen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvMededelingen.BackgroundColor = System.Drawing.Color.White;
            this.dgrvMededelingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrvMededelingen, "dgrvMededelingen");
            this.dgrvMededelingen.Name = "dgrvMededelingen";
            // 
            // lblMededelingen
            // 
            resources.ApplyResources(this.lblMededelingen, "lblMededelingen");
            this.lblMededelingen.CustomBackground = false;
            this.lblMededelingen.CustomForeColor = false;
            this.lblMededelingen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMededelingen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMededelingen.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblMededelingen.Name = "lblMededelingen";
            this.lblMededelingen.Style = MetroFramework.MetroColorStyle.Black;
            this.lblMededelingen.StyleManager = this.metroStyleManager1;
            this.lblMededelingen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMededelingen.UseStyleColors = false;
            // 
            // lstMededelingen
            // 
            this.lstMededelingen.FormattingEnabled = true;
            resources.ApplyResources(this.lstMededelingen, "lstMededelingen");
            this.lstMededelingen.Name = "lstMededelingen";
            // 
            // tabVakken
            // 
            this.tabVakken.Controls.Add(this.cmdMemoOpslagen);
            this.tabVakken.Controls.Add(this.lblEmailInhoud);
            this.tabVakken.Controls.Add(this.lblEmail);
            this.tabVakken.Controls.Add(this.lblAchternaamInhoud);
            this.tabVakken.Controls.Add(this.lblAchternaam);
            this.tabVakken.Controls.Add(this.lblNaamInhoud);
            this.tabVakken.Controls.Add(this.lblNaam);
            this.tabVakken.Controls.Add(this.lblLeerkracht);
            this.tabVakken.Controls.Add(this.lblMemo);
            this.tabVakken.Controls.Add(this.rtxtMemo);
            this.tabVakken.Controls.Add(this.languageControl1);
            this.tabVakken.Controls.Add(this.lstVakken);
            this.tabVakken.Controls.Add(this.lblVakken);
            this.tabVakken.CustomBackground = false;
            this.tabVakken.HorizontalScrollbar = false;
            this.tabVakken.HorizontalScrollbarBarColor = true;
            this.tabVakken.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVakken.HorizontalScrollbarSize = 8;
            resources.ApplyResources(this.tabVakken, "tabVakken");
            this.tabVakken.Name = "tabVakken";
            this.tabVakken.Style = MetroFramework.MetroColorStyle.Black;
            this.tabVakken.StyleManager = this.metroStyleManager1;
            this.tabVakken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabVakken.VerticalScrollbar = false;
            this.tabVakken.VerticalScrollbarBarColor = true;
            this.tabVakken.VerticalScrollbarHighlightOnWheel = false;
            this.tabVakken.VerticalScrollbarSize = 8;
            // 
            // cmdMemoOpslagen
            // 
            this.cmdMemoOpslagen.Highlight = false;
            resources.ApplyResources(this.cmdMemoOpslagen, "cmdMemoOpslagen");
            this.cmdMemoOpslagen.Name = "cmdMemoOpslagen";
            this.cmdMemoOpslagen.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdMemoOpslagen.StyleManager = this.metroStyleManager1;
            this.cmdMemoOpslagen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdMemoOpslagen.Click += new System.EventHandler(this.cmdMemoOpslagen_Click);
            // 
            // lblEmailInhoud
            // 
            resources.ApplyResources(this.lblEmailInhoud, "lblEmailInhoud");
            this.lblEmailInhoud.CustomBackground = false;
            this.lblEmailInhoud.CustomForeColor = false;
            this.lblEmailInhoud.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblEmailInhoud.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblEmailInhoud.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblEmailInhoud.Name = "lblEmailInhoud";
            this.lblEmailInhoud.Style = MetroFramework.MetroColorStyle.Black;
            this.lblEmailInhoud.StyleManager = this.metroStyleManager1;
            this.lblEmailInhoud.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmailInhoud.UseStyleColors = false;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.CustomBackground = false;
            this.lblEmail.CustomForeColor = false;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblEmail.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Style = MetroFramework.MetroColorStyle.Black;
            this.lblEmail.StyleManager = this.metroStyleManager1;
            this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmail.UseStyleColors = false;
            // 
            // lblAchternaamInhoud
            // 
            resources.ApplyResources(this.lblAchternaamInhoud, "lblAchternaamInhoud");
            this.lblAchternaamInhoud.CustomBackground = false;
            this.lblAchternaamInhoud.CustomForeColor = false;
            this.lblAchternaamInhoud.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblAchternaamInhoud.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblAchternaamInhoud.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblAchternaamInhoud.Name = "lblAchternaamInhoud";
            this.lblAchternaamInhoud.Style = MetroFramework.MetroColorStyle.Black;
            this.lblAchternaamInhoud.StyleManager = this.metroStyleManager1;
            this.lblAchternaamInhoud.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblAchternaamInhoud.UseStyleColors = false;
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
            // lblNaamInhoud
            // 
            resources.ApplyResources(this.lblNaamInhoud, "lblNaamInhoud");
            this.lblNaamInhoud.CustomBackground = false;
            this.lblNaamInhoud.CustomForeColor = false;
            this.lblNaamInhoud.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblNaamInhoud.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblNaamInhoud.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblNaamInhoud.Name = "lblNaamInhoud";
            this.lblNaamInhoud.Style = MetroFramework.MetroColorStyle.Black;
            this.lblNaamInhoud.StyleManager = this.metroStyleManager1;
            this.lblNaamInhoud.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblNaamInhoud.UseStyleColors = false;
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
            // lblLeerkracht
            // 
            resources.ApplyResources(this.lblLeerkracht, "lblLeerkracht");
            this.lblLeerkracht.CustomBackground = false;
            this.lblLeerkracht.CustomForeColor = false;
            this.lblLeerkracht.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLeerkracht.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLeerkracht.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblLeerkracht.Name = "lblLeerkracht";
            this.lblLeerkracht.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLeerkracht.StyleManager = this.metroStyleManager1;
            this.lblLeerkracht.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblLeerkracht.UseStyleColors = false;
            // 
            // lblMemo
            // 
            resources.ApplyResources(this.lblMemo, "lblMemo");
            this.lblMemo.CustomBackground = false;
            this.lblMemo.CustomForeColor = false;
            this.lblMemo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMemo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMemo.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Style = MetroFramework.MetroColorStyle.Black;
            this.lblMemo.StyleManager = this.metroStyleManager1;
            this.lblMemo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMemo.UseStyleColors = false;
            // 
            // rtxtMemo
            // 
            resources.ApplyResources(this.rtxtMemo, "rtxtMemo");
            this.rtxtMemo.Name = "rtxtMemo";
            // 
            // languageControl1
            // 
            resources.ApplyResources(this.languageControl1, "languageControl1");
            this.languageControl1.Name = "languageControl1";
            // 
            // lstVakken
            // 
            this.lstVakken.FormattingEnabled = true;
            resources.ApplyResources(this.lstVakken, "lstVakken");
            this.lstVakken.Name = "lstVakken";
            this.lstVakken.SelectedIndexChanged += new System.EventHandler(this.lstVakken_SelectedIndexChanged);
            // 
            // lblVakken
            // 
            resources.ApplyResources(this.lblVakken, "lblVakken");
            this.lblVakken.CustomBackground = false;
            this.lblVakken.CustomForeColor = false;
            this.lblVakken.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVakken.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVakken.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVakken.Name = "lblVakken";
            this.lblVakken.Style = MetroFramework.MetroColorStyle.Black;
            this.lblVakken.StyleManager = this.metroStyleManager1;
            this.lblVakken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVakken.UseStyleColors = false;
            // 
            // tabTaken
            // 
            this.tabTaken.Controls.Add(this.dgrvTaken);
            this.tabTaken.Controls.Add(this.lblTaken);
            this.tabTaken.CustomBackground = false;
            this.tabTaken.HorizontalScrollbar = false;
            this.tabTaken.HorizontalScrollbarBarColor = true;
            this.tabTaken.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTaken.HorizontalScrollbarSize = 8;
            resources.ApplyResources(this.tabTaken, "tabTaken");
            this.tabTaken.Name = "tabTaken";
            this.tabTaken.Style = MetroFramework.MetroColorStyle.Black;
            this.tabTaken.StyleManager = this.metroStyleManager1;
            this.tabTaken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabTaken.VerticalScrollbar = false;
            this.tabTaken.VerticalScrollbarBarColor = true;
            this.tabTaken.VerticalScrollbarHighlightOnWheel = false;
            this.tabTaken.VerticalScrollbarSize = 8;
            // 
            // dgrvTaken
            // 
            this.dgrvTaken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvTaken.BackgroundColor = System.Drawing.Color.White;
            this.dgrvTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrvTaken, "dgrvTaken");
            this.dgrvTaken.Name = "dgrvTaken";
            // 
            // lblTaken
            // 
            resources.ApplyResources(this.lblTaken, "lblTaken");
            this.lblTaken.CustomBackground = false;
            this.lblTaken.CustomForeColor = false;
            this.lblTaken.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTaken.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTaken.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTaken.Name = "lblTaken";
            this.lblTaken.Style = MetroFramework.MetroColorStyle.Black;
            this.lblTaken.StyleManager = this.metroStyleManager1;
            this.lblTaken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTaken.UseStyleColors = false;
            // 
            // tabTesten
            // 
            this.tabTesten.Controls.Add(this.dgrvTesten);
            this.tabTesten.Controls.Add(this.lblTesten);
            this.tabTesten.CustomBackground = false;
            this.tabTesten.HorizontalScrollbar = false;
            this.tabTesten.HorizontalScrollbarBarColor = true;
            this.tabTesten.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTesten.HorizontalScrollbarSize = 8;
            resources.ApplyResources(this.tabTesten, "tabTesten");
            this.tabTesten.Name = "tabTesten";
            this.tabTesten.Style = MetroFramework.MetroColorStyle.Black;
            this.tabTesten.StyleManager = this.metroStyleManager1;
            this.tabTesten.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabTesten.VerticalScrollbar = false;
            this.tabTesten.VerticalScrollbarBarColor = true;
            this.tabTesten.VerticalScrollbarHighlightOnWheel = false;
            this.tabTesten.VerticalScrollbarSize = 8;
            // 
            // dgrvTesten
            // 
            this.dgrvTesten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvTesten.BackgroundColor = System.Drawing.Color.White;
            this.dgrvTesten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrvTesten, "dgrvTesten");
            this.dgrvTesten.Name = "dgrvTesten";
            // 
            // lblTesten
            // 
            resources.ApplyResources(this.lblTesten, "lblTesten");
            this.lblTesten.CustomBackground = false;
            this.lblTesten.CustomForeColor = false;
            this.lblTesten.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTesten.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTesten.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTesten.Name = "lblTesten";
            this.lblTesten.Style = MetroFramework.MetroColorStyle.Black;
            this.lblTesten.StyleManager = this.metroStyleManager1;
            this.lblTesten.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTesten.UseStyleColors = false;
            // 
            // dgrvMemo
            // 
            this.dgrvMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrvMemo, "dgrvMemo");
            this.dgrvMemo.Name = "dgrvMemo";
            // 
            // languageControl2
            // 
            resources.ApplyResources(this.languageControl2, "languageControl2");
            this.languageControl2.Name = "languageControl2";
            // 
            // FrmStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgrvMemo);
            this.Controls.Add(this.languageControl2);
            this.Controls.Add(this.tbcStudent);
            this.MaximizeBox = false;
            this.Name = "FrmStudent";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStudent_FormClosed);
            this.tbcStudent.ResumeLayout(false);
            this.tabMededelingen.ResumeLayout(false);
            this.tabMededelingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMededelingen)).EndInit();
            this.tabVakken.ResumeLayout(false);
            this.tabVakken.PerformLayout();
            this.tabTaken.ResumeLayout(false);
            this.tabTaken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTaken)).EndInit();
            this.tabTesten.ResumeLayout(false);
            this.tabTesten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTesten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl tbcStudent;
        private MetroFramework.Controls.MetroTabPage tabMededelingen;
        private MetroFramework.Controls.MetroTabPage tabVakken;
        private MetroFramework.Controls.MetroTabPage tabTaken;
        private MetroFramework.Controls.MetroTabPage tabTesten;
        private System.Windows.Forms.ListBox lstMededelingen;
        private MetroFramework.Controls.MetroLabel lblMededelingen;
        private System.Windows.Forms.ListBox lstVakken;
        private MetroFramework.Controls.MetroLabel lblVakken;
        private MetroFramework.Controls.MetroLabel lblTaken;
        private MetroFramework.Controls.MetroLabel lblTesten;
        private LanguageControl languageControl1;
        private LanguageControl languageControl2;
        private System.Windows.Forms.DataGridView dgrvMededelingen;
        private MetroFramework.Controls.MetroLabel lblLeerkracht;
        private MetroFramework.Controls.MetroLabel lblMemo;
        private System.Windows.Forms.RichTextBox rtxtMemo;
        private MetroFramework.Controls.MetroLabel lblEmailInhoud;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblAchternaamInhoud;
        private MetroFramework.Controls.MetroLabel lblAchternaam;
        private MetroFramework.Controls.MetroLabel lblNaamInhoud;
        private MetroFramework.Controls.MetroLabel lblNaam;
        private System.Windows.Forms.DataGridView dgrvTaken;
        private System.Windows.Forms.DataGridView dgrvTesten;
        private MetroFramework.Controls.MetroButton cmdMemoOpslagen;
        private System.Windows.Forms.DataGridView dgrvMemo;
    }
}