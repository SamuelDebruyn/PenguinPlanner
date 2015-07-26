namespace PP_Presentation
{
    partial class FrmVakAanpassenAdvanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVakAanpassenAdvanced));
            this.dgrvLessen = new System.Windows.Forms.DataGridView();
            this.cmdLesVerwijderen = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager();
            this.cmdLesAanmaken = new MetroFramework.Controls.MetroButton();
            this.cbLokalen = new MetroFramework.Controls.MetroComboBox();
            this.tpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.tpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.bsLokalenLijst = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLessen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLokalenLijst)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvLessen
            // 
            resources.ApplyResources(this.dgrvLessen, "dgrvLessen");
            this.dgrvLessen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLessen.Name = "dgrvLessen";
            // 
            // cmdLesVerwijderen
            // 
            resources.ApplyResources(this.cmdLesVerwijderen, "cmdLesVerwijderen");
            this.cmdLesVerwijderen.Highlight = false;
            this.cmdLesVerwijderen.Name = "cmdLesVerwijderen";
            this.cmdLesVerwijderen.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdLesVerwijderen.StyleManager = this.metroStyleManager1;
            this.cmdLesVerwijderen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdLesVerwijderen.Click += new System.EventHandler(this.cmdLesVerwijderen_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.OwnerForm = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cmdLesAanmaken
            // 
            resources.ApplyResources(this.cmdLesAanmaken, "cmdLesAanmaken");
            this.cmdLesAanmaken.Highlight = false;
            this.cmdLesAanmaken.Name = "cmdLesAanmaken";
            this.cmdLesAanmaken.Style = MetroFramework.MetroColorStyle.Black;
            this.cmdLesAanmaken.StyleManager = this.metroStyleManager1;
            this.cmdLesAanmaken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmdLesAanmaken.Click += new System.EventHandler(this.cmdLesAanmaken_Click);
            // 
            // cbLokalen
            // 
            resources.ApplyResources(this.cbLokalen, "cbLokalen");
            this.cbLokalen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLokalen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLokalen.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cbLokalen.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cbLokalen.FormattingEnabled = true;
            this.cbLokalen.Name = "cbLokalen";
            this.cbLokalen.Style = MetroFramework.MetroColorStyle.Black;
            this.cbLokalen.StyleManager = this.metroStyleManager1;
            this.cbLokalen.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tpBeginDatum
            // 
            resources.ApplyResources(this.tpBeginDatum, "tpBeginDatum");
            this.tpBeginDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpBeginDatum.Name = "tpBeginDatum";
            this.tpBeginDatum.ValueChanged += new System.EventHandler(this.tpBeginDatum_ValueChanged);
            // 
            // tpEindDatum
            // 
            resources.ApplyResources(this.tpEindDatum, "tpEindDatum");
            this.tpEindDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpEindDatum.Name = "tpEindDatum";
            // 
            // FrmVakAanpassenAdvanced
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpEindDatum);
            this.Controls.Add(this.tpBeginDatum);
            this.Controls.Add(this.cbLokalen);
            this.Controls.Add(this.cmdLesAanmaken);
            this.Controls.Add(this.cmdLesVerwijderen);
            this.Controls.Add(this.dgrvLessen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVakAanpassenAdvanced";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.StyleManager = this.metroStyleManager1;
            this.Load += new System.EventHandler(this.frmVakAanpassenAdvanced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLessen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLokalenLijst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvLessen;
        private MetroFramework.Controls.MetroButton cmdLesVerwijderen;
        private MetroFramework.Controls.MetroButton cmdLesAanmaken;
        private MetroFramework.Controls.MetroComboBox cbLokalen;
        private System.Windows.Forms.DateTimePicker tpBeginDatum;
        private System.Windows.Forms.DateTimePicker tpEindDatum;
        private System.Windows.Forms.BindingSource bsLokalenLijst;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}