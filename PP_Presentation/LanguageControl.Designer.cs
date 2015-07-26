namespace PP_Presentation
{
    partial class LanguageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageControl));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroComboBox1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.metroComboBox1, "metroComboBox1");
            this.metroComboBox1.Items.AddRange(new object[] {
            resources.GetString("metroComboBox1.Items"),
            resources.GetString("metroComboBox1.Items1")});
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox1.StyleManager = null;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // LanguageControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroComboBox1);
            this.Name = "LanguageControl";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}
