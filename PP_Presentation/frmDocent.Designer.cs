namespace PP_Presentation
{
    partial class FrmDocent
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
            this.components = new System.ComponentModel.Container();
            MetroFramework.Controls.MetroButton cmdMededelingToevoegen;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocent));
            MetroFramework.Controls.MetroButton cmdTakenToevoegen;
            MetroFramework.Controls.MetroButton bttnMededelingCancel;
            MetroFramework.Controls.MetroButton bttnTaakCancel;
            MetroFramework.Controls.MetroButton bttnTestCancel;
            MetroFramework.Controls.MetroButton cmdTestToevoegen;
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.tbctrlStudent = new MetroFramework.Controls.MetroTabControl();
            this.tabMededelingen = new MetroFramework.Controls.MetroTabPage();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.comboVakken = new System.Windows.Forms.ComboBox();
            this.bsVakkenLijst = new System.Windows.Forms.BindingSource(this.components);
            this.lblBeginDatum = new System.Windows.Forms.Label();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.dgrvMededelingen = new System.Windows.Forms.DataGridView();
            this.lblMededelingen = new MetroFramework.Controls.MetroLabel();
            this.tabVakken = new MetroFramework.Controls.MetroTabPage();
            this.lblFoutVakkenDocent = new System.Windows.Forms.Label();
            this.dgrvStudenten = new System.Windows.Forms.DataGridView();
            this.cmboVakkenDieStudentenVolgen = new System.Windows.Forms.ComboBox();
            this.lblStudentenDocent = new MetroFramework.Controls.MetroLabel();
            this.lblVakkenDocent = new MetroFramework.Controls.MetroLabel();
            this.tabTaken = new MetroFramework.Controls.MetroTabPage();
            this.dgrvTaken = new System.Windows.Forms.DataGridView();
            this.lblFoutTaak = new System.Windows.Forms.Label();
            this.dtpEindDatumTaak = new System.Windows.Forms.DateTimePicker();
            this.lblEindDatumTaak = new System.Windows.Forms.Label();
            this.dtpBeginDatumTaak = new System.Windows.Forms.DateTimePicker();
            this.cmboxVakkenTaken = new System.Windows.Forms.ComboBox();
            this.lblBeginDatumTaak = new System.Windows.Forms.Label();
            this.txtboxTaakOmschrijving = new System.Windows.Forms.TextBox();
            this.lblTakenDocent = new MetroFramework.Controls.MetroLabel();
            this.tabTesten = new MetroFramework.Controls.MetroTabPage();
            this.dgrvTesten = new System.Windows.Forms.DataGridView();
            this.lblFoutTest = new System.Windows.Forms.Label();
            this.dtpEindDatumTest = new System.Windows.Forms.DateTimePicker();
            this.lblEindDatumTest = new System.Windows.Forms.Label();
            this.dtpBeginDatumTest = new System.Windows.Forms.DateTimePicker();
            this.cmBoxVakkenTesten = new System.Windows.Forms.ComboBox();
            this.lblBeginDatumTest = new System.Windows.Forms.Label();
            this.txtboxTestOmschrijving = new System.Windows.Forms.TextBox();
            this.lblTestenDocent = new MetroFramework.Controls.MetroLabel();
            this.lstTaken = new System.Windows.Forms.ListBox();
            this.lblFoutMededeling = new System.Windows.Forms.Label();
            this.languageControl1 = new PP_Presentation.LanguageControl();
            cmdMededelingToevoegen = new MetroFramework.Controls.MetroButton();
            cmdTakenToevoegen = new MetroFramework.Controls.MetroButton();
            bttnMededelingCancel = new MetroFramework.Controls.MetroButton();
            bttnTaakCancel = new MetroFramework.Controls.MetroButton();
            bttnTestCancel = new MetroFramework.Controls.MetroButton();
            cmdTestToevoegen = new MetroFramework.Controls.MetroButton();
            this.tbctrlStudent.SuspendLayout();
            this.tabMededelingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVakkenLijst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMededelingen)).BeginInit();
            this.tabVakken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStudenten)).BeginInit();
            this.tabTaken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTaken)).BeginInit();
            this.tabTesten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTesten)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdMededelingToevoegen
            // 
            resources.ApplyResources(cmdMededelingToevoegen, "cmdMededelingToevoegen");
            cmdMededelingToevoegen.Highlight = true;
            cmdMededelingToevoegen.Name = "cmdMededelingToevoegen";
            cmdMededelingToevoegen.Style = MetroFramework.MetroColorStyle.Black;
            cmdMededelingToevoegen.StyleManager = this.metroStyleManager1;
            cmdMededelingToevoegen.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdMededelingToevoegen.Click += new System.EventHandler(this.cmdMededelingToevoegen_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmdTakenToevoegen
            // 
            resources.ApplyResources(cmdTakenToevoegen, "cmdTakenToevoegen");
            cmdTakenToevoegen.Highlight = true;
            cmdTakenToevoegen.Name = "cmdTakenToevoegen";
            cmdTakenToevoegen.Style = MetroFramework.MetroColorStyle.Black;
            cmdTakenToevoegen.StyleManager = this.metroStyleManager1;
            cmdTakenToevoegen.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdTakenToevoegen.Click += new System.EventHandler(this.cmdTakenToevoegen_Click);
            // 
            // bttnMededelingCancel
            // 
            resources.ApplyResources(bttnMededelingCancel, "bttnMededelingCancel");
            bttnMededelingCancel.Highlight = true;
            bttnMededelingCancel.Name = "bttnMededelingCancel";
            bttnMededelingCancel.Style = MetroFramework.MetroColorStyle.Black;
            bttnMededelingCancel.StyleManager = this.metroStyleManager1;
            bttnMededelingCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            bttnMededelingCancel.Click += new System.EventHandler(this.bttnMededelingCancel_Click);
            // 
            // bttnTaakCancel
            // 
            resources.ApplyResources(bttnTaakCancel, "bttnTaakCancel");
            bttnTaakCancel.Highlight = true;
            bttnTaakCancel.Name = "bttnTaakCancel";
            bttnTaakCancel.Style = MetroFramework.MetroColorStyle.Black;
            bttnTaakCancel.StyleManager = this.metroStyleManager1;
            bttnTaakCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            bttnTaakCancel.Click += new System.EventHandler(this.cmdTaakCancel_Click);
            // 
            // bttnTestCancel
            // 
            resources.ApplyResources(bttnTestCancel, "bttnTestCancel");
            bttnTestCancel.Highlight = true;
            bttnTestCancel.Name = "bttnTestCancel";
            bttnTestCancel.Style = MetroFramework.MetroColorStyle.Black;
            bttnTestCancel.StyleManager = this.metroStyleManager1;
            bttnTestCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            bttnTestCancel.Click += new System.EventHandler(this.cmdTestCancel_Click);
            // 
            // cmdTestToevoegen
            // 
            resources.ApplyResources(cmdTestToevoegen, "cmdTestToevoegen");
            cmdTestToevoegen.Highlight = true;
            cmdTestToevoegen.Name = "cmdTestToevoegen";
            cmdTestToevoegen.Style = MetroFramework.MetroColorStyle.Black;
            cmdTestToevoegen.StyleManager = this.metroStyleManager1;
            cmdTestToevoegen.Theme = MetroFramework.MetroThemeStyle.Light;
            cmdTestToevoegen.Click += new System.EventHandler(this.cmdTestToevoegen_Click);
            // 
            // tbctrlStudent
            // 
            resources.ApplyResources(this.tbctrlStudent, "tbctrlStudent");
            this.tbctrlStudent.Controls.Add(this.tabMededelingen);
            this.tbctrlStudent.Controls.Add(this.tabVakken);
            this.tbctrlStudent.Controls.Add(this.tabTaken);
            this.tbctrlStudent.Controls.Add(this.tabTesten);
            this.tbctrlStudent.CustomBackground = false;
            this.tbctrlStudent.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.tbctrlStudent.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.tbctrlStudent.Name = "tbctrlStudent";
            this.tbctrlStudent.SelectedIndex = 0;
            this.tbctrlStudent.Style = MetroFramework.MetroColorStyle.Black;
            this.tbctrlStudent.StyleManager = this.metroStyleManager1;
            this.tbctrlStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbctrlStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbctrlStudent.UseStyleColors = false;
            // 
            // tabMededelingen
            // 
            resources.ApplyResources(this.tabMededelingen, "tabMededelingen");
            this.tabMededelingen.Controls.Add(this.dtpEindDatum);
            this.tabMededelingen.Controls.Add(bttnMededelingCancel);
            this.tabMededelingen.Controls.Add(this.lblEindDatum);
            this.tabMededelingen.Controls.Add(this.dtpBeginDatum);
            this.tabMededelingen.Controls.Add(this.comboVakken);
            this.tabMededelingen.Controls.Add(this.lblBeginDatum);
            this.tabMededelingen.Controls.Add(this.tbBeschrijving);
            this.tabMededelingen.Controls.Add(this.dgrvMededelingen);
            this.tabMededelingen.Controls.Add(cmdMededelingToevoegen);
            this.tabMededelingen.Controls.Add(this.lblMededelingen);
            this.tabMededelingen.CustomBackground = false;
            this.tabMededelingen.HorizontalScrollbar = false;
            this.tabMededelingen.HorizontalScrollbarBarColor = true;
            this.tabMededelingen.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMededelingen.HorizontalScrollbarSize = 8;
            this.tabMededelingen.Name = "tabMededelingen";
            this.tabMededelingen.Style = MetroFramework.MetroColorStyle.Black;
            this.tabMededelingen.StyleManager = this.metroStyleManager1;
            this.tabMededelingen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabMededelingen.VerticalScrollbar = false;
            this.tabMededelingen.VerticalScrollbarBarColor = true;
            this.tabMededelingen.VerticalScrollbarHighlightOnWheel = false;
            this.tabMededelingen.VerticalScrollbarSize = 8;
            // 
            // dtpEindDatum
            // 
            resources.ApplyResources(this.dtpEindDatum, "dtpEindDatum");
            this.dtpEindDatum.Name = "dtpEindDatum";
            // 
            // lblEindDatum
            // 
            resources.ApplyResources(this.lblEindDatum, "lblEindDatum");
            this.lblEindDatum.Name = "lblEindDatum";
            // 
            // dtpBeginDatum
            // 
            resources.ApplyResources(this.dtpBeginDatum, "dtpBeginDatum");
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            // 
            // comboVakken
            // 
            resources.ApplyResources(this.comboVakken, "comboVakken");
            this.comboVakken.DataSource = this.bsVakkenLijst;
            this.comboVakken.FormattingEnabled = true;
            this.comboVakken.Name = "comboVakken";
            // 
            // lblBeginDatum
            // 
            resources.ApplyResources(this.lblBeginDatum, "lblBeginDatum");
            this.lblBeginDatum.Name = "lblBeginDatum";
            // 
            // tbBeschrijving
            // 
            resources.ApplyResources(this.tbBeschrijving, "tbBeschrijving");
            this.tbBeschrijving.Name = "tbBeschrijving";
            // 
            // dgrvMededelingen
            // 
            resources.ApplyResources(this.dgrvMededelingen, "dgrvMededelingen");
            this.dgrvMededelingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // tabVakken
            // 
            resources.ApplyResources(this.tabVakken, "tabVakken");
            this.tabVakken.Controls.Add(this.lblFoutVakkenDocent);
            this.tabVakken.Controls.Add(this.dgrvStudenten);
            this.tabVakken.Controls.Add(this.cmboVakkenDieStudentenVolgen);
            this.tabVakken.Controls.Add(this.lblStudentenDocent);
            this.tabVakken.Controls.Add(this.lblVakkenDocent);
            this.tabVakken.CustomBackground = false;
            this.tabVakken.HorizontalScrollbar = false;
            this.tabVakken.HorizontalScrollbarBarColor = true;
            this.tabVakken.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVakken.HorizontalScrollbarSize = 8;
            this.tabVakken.Name = "tabVakken";
            this.tabVakken.Style = MetroFramework.MetroColorStyle.Black;
            this.tabVakken.StyleManager = this.metroStyleManager1;
            this.tabVakken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabVakken.VerticalScrollbar = false;
            this.tabVakken.VerticalScrollbarBarColor = true;
            this.tabVakken.VerticalScrollbarHighlightOnWheel = false;
            this.tabVakken.VerticalScrollbarSize = 8;
            // 
            // lblFoutVakkenDocent
            // 
            resources.ApplyResources(this.lblFoutVakkenDocent, "lblFoutVakkenDocent");
            this.lblFoutVakkenDocent.Name = "lblFoutVakkenDocent";
            // 
            // dgrvStudenten
            // 
            resources.ApplyResources(this.dgrvStudenten, "dgrvStudenten");
            this.dgrvStudenten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrvStudenten.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrvStudenten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrvStudenten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrvStudenten.Name = "dgrvStudenten";
            this.dgrvStudenten.RowTemplate.Height = 24;
            this.dgrvStudenten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // cmboVakkenDieStudentenVolgen
            // 
            resources.ApplyResources(this.cmboVakkenDieStudentenVolgen, "cmboVakkenDieStudentenVolgen");
            this.cmboVakkenDieStudentenVolgen.DataSource = this.bsVakkenLijst;
            this.cmboVakkenDieStudentenVolgen.FormattingEnabled = true;
            this.cmboVakkenDieStudentenVolgen.Name = "cmboVakkenDieStudentenVolgen";
            this.cmboVakkenDieStudentenVolgen.SelectedIndexChanged += new System.EventHandler(this.cmboVakkenDieStudentenVolgen_SelectedIndexChanged);
            // 
            // lblStudentenDocent
            // 
            resources.ApplyResources(this.lblStudentenDocent, "lblStudentenDocent");
            this.lblStudentenDocent.CustomBackground = false;
            this.lblStudentenDocent.CustomForeColor = false;
            this.lblStudentenDocent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStudentenDocent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStudentenDocent.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblStudentenDocent.Name = "lblStudentenDocent";
            this.lblStudentenDocent.Style = MetroFramework.MetroColorStyle.Black;
            this.lblStudentenDocent.StyleManager = this.metroStyleManager1;
            this.lblStudentenDocent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblStudentenDocent.UseStyleColors = false;
            // 
            // lblVakkenDocent
            // 
            resources.ApplyResources(this.lblVakkenDocent, "lblVakkenDocent");
            this.lblVakkenDocent.CustomBackground = false;
            this.lblVakkenDocent.CustomForeColor = false;
            this.lblVakkenDocent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVakkenDocent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVakkenDocent.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblVakkenDocent.Name = "lblVakkenDocent";
            this.lblVakkenDocent.Style = MetroFramework.MetroColorStyle.Black;
            this.lblVakkenDocent.StyleManager = this.metroStyleManager1;
            this.lblVakkenDocent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVakkenDocent.UseStyleColors = false;
            // 
            // tabTaken
            // 
            resources.ApplyResources(this.tabTaken, "tabTaken");
            this.tabTaken.Controls.Add(this.dgrvTaken);
            this.tabTaken.Controls.Add(this.lblFoutTaak);
            this.tabTaken.Controls.Add(this.dtpEindDatumTaak);
            this.tabTaken.Controls.Add(bttnTaakCancel);
            this.tabTaken.Controls.Add(this.lblEindDatumTaak);
            this.tabTaken.Controls.Add(this.dtpBeginDatumTaak);
            this.tabTaken.Controls.Add(this.cmboxVakkenTaken);
            this.tabTaken.Controls.Add(this.lblBeginDatumTaak);
            this.tabTaken.Controls.Add(this.txtboxTaakOmschrijving);
            this.tabTaken.Controls.Add(cmdTakenToevoegen);
            this.tabTaken.Controls.Add(this.lblTakenDocent);
            this.tabTaken.CustomBackground = false;
            this.tabTaken.HorizontalScrollbar = false;
            this.tabTaken.HorizontalScrollbarBarColor = true;
            this.tabTaken.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTaken.HorizontalScrollbarSize = 8;
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
            resources.ApplyResources(this.dgrvTaken, "dgrvTaken");
            this.dgrvTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTaken.Name = "dgrvTaken";
            // 
            // lblFoutTaak
            // 
            resources.ApplyResources(this.lblFoutTaak, "lblFoutTaak");
            this.lblFoutTaak.Name = "lblFoutTaak";
            // 
            // dtpEindDatumTaak
            // 
            resources.ApplyResources(this.dtpEindDatumTaak, "dtpEindDatumTaak");
            this.dtpEindDatumTaak.Name = "dtpEindDatumTaak";
            // 
            // lblEindDatumTaak
            // 
            resources.ApplyResources(this.lblEindDatumTaak, "lblEindDatumTaak");
            this.lblEindDatumTaak.Name = "lblEindDatumTaak";
            // 
            // dtpBeginDatumTaak
            // 
            resources.ApplyResources(this.dtpBeginDatumTaak, "dtpBeginDatumTaak");
            this.dtpBeginDatumTaak.Name = "dtpBeginDatumTaak";
            // 
            // cmboxVakkenTaken
            // 
            resources.ApplyResources(this.cmboxVakkenTaken, "cmboxVakkenTaken");
            this.cmboxVakkenTaken.DataSource = this.bsVakkenLijst;
            this.cmboxVakkenTaken.FormattingEnabled = true;
            this.cmboxVakkenTaken.Name = "cmboxVakkenTaken";
            // 
            // lblBeginDatumTaak
            // 
            resources.ApplyResources(this.lblBeginDatumTaak, "lblBeginDatumTaak");
            this.lblBeginDatumTaak.Name = "lblBeginDatumTaak";
            // 
            // txtboxTaakOmschrijving
            // 
            resources.ApplyResources(this.txtboxTaakOmschrijving, "txtboxTaakOmschrijving");
            this.txtboxTaakOmschrijving.Name = "txtboxTaakOmschrijving";
            // 
            // lblTakenDocent
            // 
            resources.ApplyResources(this.lblTakenDocent, "lblTakenDocent");
            this.lblTakenDocent.CustomBackground = false;
            this.lblTakenDocent.CustomForeColor = false;
            this.lblTakenDocent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTakenDocent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTakenDocent.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTakenDocent.Name = "lblTakenDocent";
            this.lblTakenDocent.Style = MetroFramework.MetroColorStyle.Black;
            this.lblTakenDocent.StyleManager = this.metroStyleManager1;
            this.lblTakenDocent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTakenDocent.UseStyleColors = false;
            // 
            // tabTesten
            // 
            resources.ApplyResources(this.tabTesten, "tabTesten");
            this.tabTesten.Controls.Add(this.dgrvTesten);
            this.tabTesten.Controls.Add(this.lblFoutTest);
            this.tabTesten.Controls.Add(this.dtpEindDatumTest);
            this.tabTesten.Controls.Add(bttnTestCancel);
            this.tabTesten.Controls.Add(this.lblEindDatumTest);
            this.tabTesten.Controls.Add(this.dtpBeginDatumTest);
            this.tabTesten.Controls.Add(this.cmBoxVakkenTesten);
            this.tabTesten.Controls.Add(this.lblBeginDatumTest);
            this.tabTesten.Controls.Add(this.txtboxTestOmschrijving);
            this.tabTesten.Controls.Add(cmdTestToevoegen);
            this.tabTesten.Controls.Add(this.lblTestenDocent);
            this.tabTesten.CustomBackground = false;
            this.tabTesten.HorizontalScrollbar = false;
            this.tabTesten.HorizontalScrollbarBarColor = true;
            this.tabTesten.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTesten.HorizontalScrollbarSize = 8;
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
            resources.ApplyResources(this.dgrvTesten, "dgrvTesten");
            this.dgrvTesten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTesten.Name = "dgrvTesten";
            // 
            // lblFoutTest
            // 
            resources.ApplyResources(this.lblFoutTest, "lblFoutTest");
            this.lblFoutTest.Name = "lblFoutTest";
            // 
            // dtpEindDatumTest
            // 
            resources.ApplyResources(this.dtpEindDatumTest, "dtpEindDatumTest");
            this.dtpEindDatumTest.Name = "dtpEindDatumTest";
            // 
            // lblEindDatumTest
            // 
            resources.ApplyResources(this.lblEindDatumTest, "lblEindDatumTest");
            this.lblEindDatumTest.Name = "lblEindDatumTest";
            // 
            // dtpBeginDatumTest
            // 
            resources.ApplyResources(this.dtpBeginDatumTest, "dtpBeginDatumTest");
            this.dtpBeginDatumTest.Name = "dtpBeginDatumTest";
            // 
            // cmBoxVakkenTesten
            // 
            resources.ApplyResources(this.cmBoxVakkenTesten, "cmBoxVakkenTesten");
            this.cmBoxVakkenTesten.DataSource = this.bsVakkenLijst;
            this.cmBoxVakkenTesten.FormattingEnabled = true;
            this.cmBoxVakkenTesten.Name = "cmBoxVakkenTesten";
            // 
            // lblBeginDatumTest
            // 
            resources.ApplyResources(this.lblBeginDatumTest, "lblBeginDatumTest");
            this.lblBeginDatumTest.Name = "lblBeginDatumTest";
            // 
            // txtboxTestOmschrijving
            // 
            resources.ApplyResources(this.txtboxTestOmschrijving, "txtboxTestOmschrijving");
            this.txtboxTestOmschrijving.Name = "txtboxTestOmschrijving";
            // 
            // lblTestenDocent
            // 
            resources.ApplyResources(this.lblTestenDocent, "lblTestenDocent");
            this.lblTestenDocent.CustomBackground = false;
            this.lblTestenDocent.CustomForeColor = false;
            this.lblTestenDocent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTestenDocent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTestenDocent.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblTestenDocent.Name = "lblTestenDocent";
            this.lblTestenDocent.Style = MetroFramework.MetroColorStyle.Black;
            this.lblTestenDocent.StyleManager = this.metroStyleManager1;
            this.lblTestenDocent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTestenDocent.UseStyleColors = false;
            // 
            // lstTaken
            // 
            resources.ApplyResources(this.lstTaken, "lstTaken");
            this.lstTaken.Name = "lstTaken";
            // 
            // lblFoutMededeling
            // 
            resources.ApplyResources(this.lblFoutMededeling, "lblFoutMededeling");
            this.lblFoutMededeling.Name = "lblFoutMededeling";
            // 
            // languageControl1
            // 
            resources.ApplyResources(this.languageControl1, "languageControl1");
            this.languageControl1.Name = "languageControl1";
            // 
            // FrmDocent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageControl1);
            this.Controls.Add(this.lblFoutMededeling);
            this.Controls.Add(this.tbctrlStudent);
            this.MaximizeBox = false;
            this.Name = "FrmDocent";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDocent_FormClosed);
            this.tbctrlStudent.ResumeLayout(false);
            this.tabMededelingen.ResumeLayout(false);
            this.tabMededelingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVakkenLijst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMededelingen)).EndInit();
            this.tabVakken.ResumeLayout(false);
            this.tabVakken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvStudenten)).EndInit();
            this.tabTaken.ResumeLayout(false);
            this.tabTaken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTaken)).EndInit();
            this.tabTesten.ResumeLayout(false);
            this.tabTesten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTesten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl tbctrlStudent;
        private MetroFramework.Controls.MetroTabPage tabMededelingen;
        private MetroFramework.Controls.MetroLabel lblMededelingen;
        private MetroFramework.Controls.MetroTabPage tabVakken;
        private MetroFramework.Controls.MetroTabPage tabTaken;
        private System.Windows.Forms.ListBox lstTaken;
        private MetroFramework.Controls.MetroLabel lblTakenDocent;
        private MetroFramework.Controls.MetroTabPage tabTesten;
        private MetroFramework.Controls.MetroLabel lblStudentenDocent;
        private MetroFramework.Controls.MetroLabel lblVakkenDocent;
        private MetroFramework.Controls.MetroLabel lblTestenDocent;
        private System.Windows.Forms.ComboBox cmboVakkenDieStudentenVolgen;
        private System.Windows.Forms.DataGridView dgrvStudenten;
        private System.Windows.Forms.DataGridView dgrvMededelingen;
        private System.Windows.Forms.DateTimePicker dtpEindDatum;
        private System.Windows.Forms.Label lblEindDatum;
        private System.Windows.Forms.Label lblBeginDatum;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.DateTimePicker dtpBeginDatum;
        private System.Windows.Forms.ComboBox comboVakken;
        private System.Windows.Forms.BindingSource bsVakkenLijst;
        private System.Windows.Forms.Label lblFoutMededeling;
        private System.Windows.Forms.DateTimePicker dtpEindDatumTaak;
        private System.Windows.Forms.Label lblEindDatumTaak;
        private System.Windows.Forms.DateTimePicker dtpBeginDatumTaak;
        private System.Windows.Forms.ComboBox cmboxVakkenTaken;
        private System.Windows.Forms.Label lblBeginDatumTaak;
        private System.Windows.Forms.TextBox txtboxTaakOmschrijving;
        private System.Windows.Forms.DateTimePicker dtpEindDatumTest;
        private System.Windows.Forms.Label lblEindDatumTest;
        private System.Windows.Forms.DateTimePicker dtpBeginDatumTest;
        private System.Windows.Forms.ComboBox cmBoxVakkenTesten;
        private System.Windows.Forms.Label lblBeginDatumTest;
        private System.Windows.Forms.TextBox txtboxTestOmschrijving;
        private System.Windows.Forms.Label lblFoutTaak;
        private System.Windows.Forms.Label lblFoutTest;
        private System.Windows.Forms.DataGridView dgrvTesten;
        private System.Windows.Forms.DataGridView dgrvTaken;
        private System.Windows.Forms.Label lblFoutVakkenDocent;
        private LanguageControl languageControl1;
    }
}