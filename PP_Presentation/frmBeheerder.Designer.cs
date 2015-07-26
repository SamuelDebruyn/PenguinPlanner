namespace PP_Presentation
{
    partial class FrmBeheerder
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
            MetroFramework.Controls.MetroButton cmdGebruikerToevoegen;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBeheerder));
            MetroFramework.Controls.MetroButton cmdVakToevoegen;
            MetroFramework.Controls.MetroButton cmdVakVerwijderen;
            MetroFramework.Controls.MetroButton cmdGebruikerAanpassen;
            MetroFramework.Controls.MetroButton cmdGebruikersToevoegenUitCSV;
            MetroFramework.Controls.MetroButton cmdGebruikerInschrijven;
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.lstVakken = new System.Windows.Forms.ListBox();
            this.lstDocentenVakGeven = new System.Windows.Forms.ListBox();
            this.lstStudentenVakVolgen = new System.Windows.Forms.ListBox();
            this.lblTussenTitelChk = new MetroFramework.Controls.MetroLabel();
            this.lblLijstGebruikers = new MetroFramework.Controls.MetroLabel();
            this.lblLijstRollen = new MetroFramework.Controls.MetroLabel();
            this.lblLijstVakken = new MetroFramework.Controls.MetroLabel();
            this.lblLijstDocentenVakGeven = new MetroFramework.Controls.MetroLabel();
            this.lblLijstStudentenVakVolgen = new MetroFramework.Controls.MetroLabel();
            this.tbctrlBeheerder = new MetroFramework.Controls.MetroTabControl();
            this.tabBeheerder = new MetroFramework.Controls.MetroTabPage();
            this.lstRollen = new System.Windows.Forms.ListBox();
            this.radAlleGebruikers = new MetroFramework.Controls.MetroRadioButton();
            this.dgrvGebruikers = new System.Windows.Forms.DataGridView();
            this.radStudenten = new MetroFramework.Controls.MetroRadioButton();
            this.radDocenten = new MetroFramework.Controls.MetroRadioButton();
            this.radBeheerders = new MetroFramework.Controls.MetroRadioButton();
            this.cmdGebruikerVerwijderen = new MetroFramework.Controls.MetroButton();
            this.tabVak = new MetroFramework.Controls.MetroTabPage();
            this.cmdVakAanpassen = new MetroFramework.Controls.MetroButton();
            this.dgrvStudentenBijVak = new System.Windows.Forms.DataGridView();
            this.dgrvDocentenBijVakken = new System.Windows.Forms.DataGridView();
            this.languageControl1 = new PP_Presentation.LanguageControl();
            cmdGebruikerToevoegen = new MetroFramework.Controls.MetroButton();
            cmdVakToevoegen = new MetroFramework.Controls.MetroButton();
            cmdVakVerwijderen = new MetroFramework.Controls.MetroButton();
            cmdGebruikerAanpassen = new MetroFramework.Controls.MetroButton();
            cmdGebruikersToevoegenUitCSV = new MetroFramework.Controls.MetroButton();
            cmdGebruikerInschrijven = new MetroFramework.Controls.MetroButton();
            this.tbctrlBeheerder.SuspendLayout();
            this.tabBeheerder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvGebruikers)).BeginInit();
            this.tabVak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStudentenBijVak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDocentenBijVakken)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGebruikerToevoegen
            // 
            cmdGebruikerToevoegen.Highlight = true;
            resources.ApplyResources(cmdGebruikerToevoegen, "cmdGebruikerToevoegen");
            cmdGebruikerToevoegen.Name = "cmdGebruikerToevoegen";
            cmdGebruikerToevoegen.Style = MetroFramework.MetroColorStyle.Black;
            cmdGebruikerToevoegen.StyleManager = this.metroStyleManager1;
            cmdGebruikerToevoegen.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdGebruikerToevoegen.Click += new System.EventHandler(this.cmdGebruikerToevoegen_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmdVakToevoegen
            // 
            cmdVakToevoegen.Highlight = true;
            resources.ApplyResources(cmdVakToevoegen, "cmdVakToevoegen");
            cmdVakToevoegen.Name = "cmdVakToevoegen";
            cmdVakToevoegen.Style = MetroFramework.MetroColorStyle.Black;
            cmdVakToevoegen.StyleManager = this.metroStyleManager1;
            cmdVakToevoegen.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdVakToevoegen.Click += new System.EventHandler(this.cmdVakToevoegen_Click);
            // 
            // cmdVakVerwijderen
            // 
            cmdVakVerwijderen.Highlight = true;
            resources.ApplyResources(cmdVakVerwijderen, "cmdVakVerwijderen");
            cmdVakVerwijderen.Name = "cmdVakVerwijderen";
            cmdVakVerwijderen.Style = MetroFramework.MetroColorStyle.Black;
            cmdVakVerwijderen.StyleManager = this.metroStyleManager1;
            cmdVakVerwijderen.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdVakVerwijderen.Click += new System.EventHandler(this.cmdVakVerwijderen_Click);
            // 
            // cmdGebruikerAanpassen
            // 
            cmdGebruikerAanpassen.Highlight = true;
            resources.ApplyResources(cmdGebruikerAanpassen, "cmdGebruikerAanpassen");
            cmdGebruikerAanpassen.Name = "cmdGebruikerAanpassen";
            cmdGebruikerAanpassen.Style = MetroFramework.MetroColorStyle.Black;
            cmdGebruikerAanpassen.StyleManager = this.metroStyleManager1;
            cmdGebruikerAanpassen.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdGebruikerAanpassen.Click += new System.EventHandler(this.cmdGebruikerAanpassen_Click);
            // 
            // cmdGebruikersToevoegenUitCSV
            // 
            cmdGebruikersToevoegenUitCSV.Highlight = true;
            resources.ApplyResources(cmdGebruikersToevoegenUitCSV, "cmdGebruikersToevoegenUitCSV");
            cmdGebruikersToevoegenUitCSV.Name = "cmdGebruikersToevoegenUitCSV";
            cmdGebruikersToevoegenUitCSV.Style = MetroFramework.MetroColorStyle.Black;
            cmdGebruikersToevoegenUitCSV.StyleManager = this.metroStyleManager1;
            cmdGebruikersToevoegenUitCSV.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdGebruikersToevoegenUitCSV.Click += new System.EventHandler(this.cmdGebruikersToevoegenUitCSV_Click);
            // 
            // cmdGebruikerInschrijven
            // 
            cmdGebruikerInschrijven.Highlight = true;
            resources.ApplyResources(cmdGebruikerInschrijven, "cmdGebruikerInschrijven");
            cmdGebruikerInschrijven.Name = "cmdGebruikerInschrijven";
            cmdGebruikerInschrijven.Style = MetroFramework.MetroColorStyle.Black;
            cmdGebruikerInschrijven.StyleManager = this.metroStyleManager1;
            cmdGebruikerInschrijven.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdGebruikerInschrijven.Click += new System.EventHandler(this.cmdGebruikerInschrijven_Click);
            // 
            // lstVakken
            // 
            resources.ApplyResources(this.lstVakken, "lstVakken");
            this.lstVakken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVakken.FormattingEnabled = true;
            this.lstVakken.Name = "lstVakken";
            this.lstVakken.SelectedIndexChanged += new System.EventHandler(this.lstVakken_SelectedIndexChanged);
            // 
            // lstDocentenVakGeven
            // 
            resources.ApplyResources(this.lstDocentenVakGeven, "lstDocentenVakGeven");
            this.lstDocentenVakGeven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDocentenVakGeven.FormattingEnabled = true;
            this.lstDocentenVakGeven.Name = "lstDocentenVakGeven";
            // 
            // lstStudentenVakVolgen
            // 
            resources.ApplyResources(this.lstStudentenVakVolgen, "lstStudentenVakVolgen");
            this.lstStudentenVakVolgen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstStudentenVakVolgen.FormattingEnabled = true;
            this.lstStudentenVakVolgen.Name = "lstStudentenVakVolgen";
            // 
            // lblTussenTitelChk
            // 
            resources.ApplyResources(this.lblTussenTitelChk, "lblTussenTitelChk");
            this.lblTussenTitelChk.CustomBackground = false;
            this.lblTussenTitelChk.CustomForeColor = false;
            this.lblTussenTitelChk.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTussenTitelChk.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTussenTitelChk.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTussenTitelChk.Name = "lblTussenTitelChk";
            this.lblTussenTitelChk.Style = MetroFramework.MetroColorStyle.Black;
            this.lblTussenTitelChk.StyleManager = this.metroStyleManager1;
            this.lblTussenTitelChk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTussenTitelChk.UseStyleColors = false;
            // 
            // lblLijstGebruikers
            // 
            resources.ApplyResources(this.lblLijstGebruikers, "lblLijstGebruikers");
            this.lblLijstGebruikers.CustomBackground = false;
            this.lblLijstGebruikers.CustomForeColor = false;
            this.lblLijstGebruikers.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLijstGebruikers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLijstGebruikers.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblLijstGebruikers.Name = "lblLijstGebruikers";
            this.lblLijstGebruikers.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLijstGebruikers.StyleManager = this.metroStyleManager1;
            this.lblLijstGebruikers.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblLijstGebruikers.UseStyleColors = false;
            // 
            // lblLijstRollen
            // 
            resources.ApplyResources(this.lblLijstRollen, "lblLijstRollen");
            this.lblLijstRollen.CustomBackground = false;
            this.lblLijstRollen.CustomForeColor = false;
            this.lblLijstRollen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLijstRollen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLijstRollen.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblLijstRollen.Name = "lblLijstRollen";
            this.lblLijstRollen.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLijstRollen.StyleManager = this.metroStyleManager1;
            this.lblLijstRollen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblLijstRollen.UseStyleColors = false;
            // 
            // lblLijstVakken
            // 
            resources.ApplyResources(this.lblLijstVakken, "lblLijstVakken");
            this.lblLijstVakken.CustomBackground = false;
            this.lblLijstVakken.CustomForeColor = false;
            this.lblLijstVakken.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLijstVakken.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLijstVakken.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblLijstVakken.Name = "lblLijstVakken";
            this.lblLijstVakken.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLijstVakken.StyleManager = this.metroStyleManager1;
            this.lblLijstVakken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblLijstVakken.UseStyleColors = false;
            // 
            // lblLijstDocentenVakGeven
            // 
            resources.ApplyResources(this.lblLijstDocentenVakGeven, "lblLijstDocentenVakGeven");
            this.lblLijstDocentenVakGeven.CustomBackground = false;
            this.lblLijstDocentenVakGeven.CustomForeColor = false;
            this.lblLijstDocentenVakGeven.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLijstDocentenVakGeven.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLijstDocentenVakGeven.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblLijstDocentenVakGeven.Name = "lblLijstDocentenVakGeven";
            this.lblLijstDocentenVakGeven.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLijstDocentenVakGeven.StyleManager = this.metroStyleManager1;
            this.lblLijstDocentenVakGeven.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblLijstDocentenVakGeven.UseStyleColors = false;
            // 
            // lblLijstStudentenVakVolgen
            // 
            resources.ApplyResources(this.lblLijstStudentenVakVolgen, "lblLijstStudentenVakVolgen");
            this.lblLijstStudentenVakVolgen.CustomBackground = false;
            this.lblLijstStudentenVakVolgen.CustomForeColor = false;
            this.lblLijstStudentenVakVolgen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLijstStudentenVakVolgen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLijstStudentenVakVolgen.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblLijstStudentenVakVolgen.Name = "lblLijstStudentenVakVolgen";
            this.lblLijstStudentenVakVolgen.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLijstStudentenVakVolgen.StyleManager = this.metroStyleManager1;
            this.lblLijstStudentenVakVolgen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblLijstStudentenVakVolgen.UseStyleColors = false;
            // 
            // tbctrlBeheerder
            // 
            this.tbctrlBeheerder.Controls.Add(this.tabBeheerder);
            this.tbctrlBeheerder.Controls.Add(this.tabVak);
            this.tbctrlBeheerder.CustomBackground = false;
            this.tbctrlBeheerder.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.tbctrlBeheerder.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            resources.ApplyResources(this.tbctrlBeheerder, "tbctrlBeheerder");
            this.tbctrlBeheerder.Name = "tbctrlBeheerder";
            this.tbctrlBeheerder.SelectedIndex = 1;
            this.tbctrlBeheerder.Style = MetroFramework.MetroColorStyle.Black;
            this.tbctrlBeheerder.StyleManager = this.metroStyleManager1;
            this.tbctrlBeheerder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbctrlBeheerder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbctrlBeheerder.UseStyleColors = false;
            // 
            // tabBeheerder
            // 
            this.tabBeheerder.BackColor = System.Drawing.SystemColors.Control;
            this.tabBeheerder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBeheerder.Controls.Add(this.lstRollen);
            this.tabBeheerder.Controls.Add(cmdGebruikerInschrijven);
            this.tabBeheerder.Controls.Add(this.radAlleGebruikers);
            this.tabBeheerder.Controls.Add(cmdGebruikersToevoegenUitCSV);
            this.tabBeheerder.Controls.Add(this.dgrvGebruikers);
            this.tabBeheerder.Controls.Add(this.radStudenten);
            this.tabBeheerder.Controls.Add(this.radDocenten);
            this.tabBeheerder.Controls.Add(this.radBeheerders);
            this.tabBeheerder.Controls.Add(cmdGebruikerAanpassen);
            this.tabBeheerder.Controls.Add(this.cmdGebruikerVerwijderen);
            this.tabBeheerder.Controls.Add(cmdGebruikerToevoegen);
            this.tabBeheerder.Controls.Add(this.lblLijstRollen);
            this.tabBeheerder.Controls.Add(this.lblLijstGebruikers);
            this.tabBeheerder.Controls.Add(this.lblTussenTitelChk);
            this.tabBeheerder.CustomBackground = false;
            this.tabBeheerder.ForeColor = System.Drawing.Color.Black;
            this.tabBeheerder.HorizontalScrollbar = false;
            this.tabBeheerder.HorizontalScrollbarBarColor = true;
            this.tabBeheerder.HorizontalScrollbarHighlightOnWheel = false;
            this.tabBeheerder.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tabBeheerder, "tabBeheerder");
            this.tabBeheerder.Name = "tabBeheerder";
            this.tabBeheerder.Style = MetroFramework.MetroColorStyle.Black;
            this.tabBeheerder.StyleManager = this.metroStyleManager1;
            this.tabBeheerder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabBeheerder.VerticalScrollbar = false;
            this.tabBeheerder.VerticalScrollbarBarColor = true;
            this.tabBeheerder.VerticalScrollbarHighlightOnWheel = false;
            this.tabBeheerder.VerticalScrollbarSize = 11;
            // 
            // lstRollen
            // 
            this.lstRollen.FormattingEnabled = true;
            resources.ApplyResources(this.lstRollen, "lstRollen");
            this.lstRollen.Name = "lstRollen";
            // 
            // radAlleGebruikers
            // 
            resources.ApplyResources(this.radAlleGebruikers, "radAlleGebruikers");
            this.radAlleGebruikers.CustomBackground = false;
            this.radAlleGebruikers.CustomForeColor = false;
            this.radAlleGebruikers.FontSize = MetroFramework.MetroLinkSize.Small;
            this.radAlleGebruikers.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.radAlleGebruikers.Name = "radAlleGebruikers";
            this.radAlleGebruikers.Style = MetroFramework.MetroColorStyle.Blue;
            this.radAlleGebruikers.StyleManager = null;
            this.radAlleGebruikers.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radAlleGebruikers.UseStyleColors = false;
            this.radAlleGebruikers.UseVisualStyleBackColor = true;
            this.radAlleGebruikers.CheckedChanged += new System.EventHandler(this.radAlleGebruikers_CheckedChanged);
            // 
            // dgrvGebruikers
            // 
            this.dgrvGebruikers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvGebruikers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrvGebruikers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            resources.ApplyResources(this.dgrvGebruikers, "dgrvGebruikers");
            this.dgrvGebruikers.Name = "dgrvGebruikers";
            this.dgrvGebruikers.ReadOnly = true;
            this.dgrvGebruikers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvGebruikers.SelectionChanged += new System.EventHandler(this.dgrvGebruikers_SelectionChanged);
            // 
            // radStudenten
            // 
            resources.ApplyResources(this.radStudenten, "radStudenten");
            this.radStudenten.CustomBackground = false;
            this.radStudenten.CustomForeColor = false;
            this.radStudenten.FontSize = MetroFramework.MetroLinkSize.Small;
            this.radStudenten.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.radStudenten.Name = "radStudenten";
            this.radStudenten.Style = MetroFramework.MetroColorStyle.Blue;
            this.radStudenten.StyleManager = null;
            this.radStudenten.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radStudenten.UseStyleColors = false;
            this.radStudenten.UseVisualStyleBackColor = true;
            this.radStudenten.CheckedChanged += new System.EventHandler(this.radStudenten_CheckedChanged);
            // 
            // radDocenten
            // 
            resources.ApplyResources(this.radDocenten, "radDocenten");
            this.radDocenten.CustomBackground = false;
            this.radDocenten.CustomForeColor = false;
            this.radDocenten.FontSize = MetroFramework.MetroLinkSize.Small;
            this.radDocenten.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.radDocenten.Name = "radDocenten";
            this.radDocenten.Style = MetroFramework.MetroColorStyle.Blue;
            this.radDocenten.StyleManager = null;
            this.radDocenten.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radDocenten.UseStyleColors = false;
            this.radDocenten.UseVisualStyleBackColor = true;
            this.radDocenten.CheckedChanged += new System.EventHandler(this.radDocenten_CheckedChanged);
            // 
            // radBeheerders
            // 
            resources.ApplyResources(this.radBeheerders, "radBeheerders");
            this.radBeheerders.CustomBackground = false;
            this.radBeheerders.CustomForeColor = false;
            this.radBeheerders.FontSize = MetroFramework.MetroLinkSize.Small;
            this.radBeheerders.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.radBeheerders.Name = "radBeheerders";
            this.radBeheerders.Style = MetroFramework.MetroColorStyle.Blue;
            this.radBeheerders.StyleManager = null;
            this.radBeheerders.Theme = MetroFramework.MetroThemeStyle.Light;
            this.radBeheerders.UseStyleColors = false;
            this.radBeheerders.UseVisualStyleBackColor = true;
            this.radBeheerders.CheckedChanged += new System.EventHandler(this.radBeheerders_CheckedChanged);
            // 
            // cmdGebruikerVerwijderen
            // 
            this.cmdGebruikerVerwijderen.Highlight = true;
            resources.ApplyResources(this.cmdGebruikerVerwijderen, "cmdGebruikerVerwijderen");
            this.cmdGebruikerVerwijderen.Name = "cmdGebruikerVerwijderen";
            this.cmdGebruikerVerwijderen.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdGebruikerVerwijderen.StyleManager = this.metroStyleManager1;
            this.cmdGebruikerVerwijderen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdGebruikerVerwijderen.Click += new System.EventHandler(this.cmdGebruikerVerwijderen_Click);
            // 
            // tabVak
            // 
            this.tabVak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabVak.Controls.Add(this.cmdVakAanpassen);
            this.tabVak.Controls.Add(this.dgrvStudentenBijVak);
            this.tabVak.Controls.Add(this.dgrvDocentenBijVakken);
            this.tabVak.Controls.Add(cmdVakVerwijderen);
            this.tabVak.Controls.Add(cmdVakToevoegen);
            this.tabVak.Controls.Add(this.lblLijstStudentenVakVolgen);
            this.tabVak.Controls.Add(this.lblLijstDocentenVakGeven);
            this.tabVak.Controls.Add(this.lstDocentenVakGeven);
            this.tabVak.Controls.Add(this.lblLijstVakken);
            this.tabVak.Controls.Add(this.lstVakken);
            this.tabVak.Controls.Add(this.lstStudentenVakVolgen);
            this.tabVak.CustomBackground = false;
            this.tabVak.HorizontalScrollbar = false;
            this.tabVak.HorizontalScrollbarBarColor = true;
            this.tabVak.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVak.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tabVak, "tabVak");
            this.tabVak.Name = "tabVak";
            this.tabVak.Style = MetroFramework.MetroColorStyle.Black;
            this.tabVak.StyleManager = this.metroStyleManager1;
            this.tabVak.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabVak.VerticalScrollbar = false;
            this.tabVak.VerticalScrollbarBarColor = false;
            this.tabVak.VerticalScrollbarHighlightOnWheel = false;
            this.tabVak.VerticalScrollbarSize = 11;
            // 
            // cmdVakAanpassen
            // 
            this.cmdVakAanpassen.Highlight = true;
            resources.ApplyResources(this.cmdVakAanpassen, "cmdVakAanpassen");
            this.cmdVakAanpassen.Name = "cmdVakAanpassen";
            this.cmdVakAanpassen.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdVakAanpassen.StyleManager = null;
            this.cmdVakAanpassen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdVakAanpassen.Click += new System.EventHandler(this.cmdVakAanpassen_Click);
            // 
            // dgrvStudentenBijVak
            // 
            this.dgrvStudentenBijVak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvStudentenBijVak.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrvStudentenBijVak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            resources.ApplyResources(this.dgrvStudentenBijVak, "dgrvStudentenBijVak");
            this.dgrvStudentenBijVak.Name = "dgrvStudentenBijVak";
            this.dgrvStudentenBijVak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgrvDocentenBijVakken
            // 
            this.dgrvDocentenBijVakken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvDocentenBijVakken.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrvDocentenBijVakken.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            resources.ApplyResources(this.dgrvDocentenBijVakken, "dgrvDocentenBijVakken");
            this.dgrvDocentenBijVakken.Name = "dgrvDocentenBijVakken";
            this.dgrvDocentenBijVakken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // languageControl1
            // 
            resources.ApplyResources(this.languageControl1, "languageControl1");
            this.languageControl1.Name = "languageControl1";
            // 
            // FrmBeheerder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageControl1);
            this.Controls.Add(this.tbctrlBeheerder);
            this.MaximizeBox = false;
            this.Name = "FrmBeheerder";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBeheerder_FormClosed);
            this.Enter += new System.EventHandler(this.frmBeheerder_Enter);
            this.tbctrlBeheerder.ResumeLayout(false);
            this.tabBeheerder.ResumeLayout(false);
            this.tabBeheerder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvGebruikers)).EndInit();
            this.tabVak.ResumeLayout(false);
            this.tabVak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStudentenBijVak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDocentenBijVakken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVakken;
        private System.Windows.Forms.ListBox lstDocentenVakGeven;
        private System.Windows.Forms.ListBox lstStudentenVakVolgen;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel lblLijstRollen;
        private MetroFramework.Controls.MetroLabel lblLijstGebruikers;
        private MetroFramework.Controls.MetroLabel lblTussenTitelChk;
        private MetroFramework.Controls.MetroLabel lblLijstStudentenVakVolgen;
        private MetroFramework.Controls.MetroLabel lblLijstDocentenVakGeven;
        private MetroFramework.Controls.MetroLabel lblLijstVakken;
        private MetroFramework.Controls.MetroTabControl tbctrlBeheerder;
        private MetroFramework.Controls.MetroTabPage tabBeheerder;
        private MetroFramework.Controls.MetroTabPage tabVak;
        private MetroFramework.Controls.MetroButton cmdGebruikerVerwijderen;
        private LanguageControl languageControl1;
        private System.Windows.Forms.DataGridView dgrvDocentenBijVakken;
        private System.Windows.Forms.DataGridView dgrvStudentenBijVak;
        private MetroFramework.Controls.MetroButton cmdVakAanpassen;
        private MetroFramework.Controls.MetroRadioButton radStudenten;
        private MetroFramework.Controls.MetroRadioButton radDocenten;
        private MetroFramework.Controls.MetroRadioButton radBeheerders;
        private System.Windows.Forms.DataGridView dgrvGebruikers;
        private MetroFramework.Controls.MetroRadioButton radAlleGebruikers;
        private System.Windows.Forms.ListBox lstRollen;
    }
}