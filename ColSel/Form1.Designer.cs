namespace ColSel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ColorDisplay = new System.Windows.Forms.Panel();
            this.RGBGroup = new System.Windows.Forms.GroupBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.BValue = new System.Windows.Forms.NumericUpDown();
            this.GValue = new System.Windows.Forms.NumericUpDown();
            this.RValue = new System.Windows.Forms.NumericUpDown();
            this.HashValue = new System.Windows.Forms.TextBox();
            this.HSLGroup = new System.Windows.Forms.GroupBox();
            this.LLabel = new System.Windows.Forms.Label();
            this.SLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.LValue = new System.Windows.Forms.NumericUpDown();
            this.SValue = new System.Windows.Forms.NumericUpDown();
            this.HValue = new System.Windows.Forms.NumericUpDown();
            this.HashCodeGroup = new System.Windows.Forms.GroupBox();
            this.HexGroup = new System.Windows.Forms.GroupBox();
            this.HexValue = new System.Windows.Forms.TextBox();
            this.SelectColorButton = new System.Windows.Forms.Button();
            this.OLEGroup = new System.Windows.Forms.GroupBox();
            this.OLEValue = new System.Windows.Forms.TextBox();
            this.ArgbGroup = new System.Windows.Forms.GroupBox();
            this.ArgbValue = new System.Windows.Forms.TextBox();
            this.CMYGroup = new System.Windows.Forms.GroupBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.MLabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.YValue = new System.Windows.Forms.NumericUpDown();
            this.MValue = new System.Windows.Forms.NumericUpDown();
            this.CValue = new System.Windows.Forms.NumericUpDown();
            this.AboutButton = new System.Windows.Forms.Button();
            this.DoAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.RGBGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RValue)).BeginInit();
            this.HSLGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).BeginInit();
            this.HashCodeGroup.SuspendLayout();
            this.HexGroup.SuspendLayout();
            this.OLEGroup.SuspendLayout();
            this.ArgbGroup.SuspendLayout();
            this.CMYGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ColorDisplay, "ColorDisplay");
            this.ColorDisplay.Name = "ColorDisplay";
            // 
            // RGBGroup
            // 
            this.RGBGroup.Controls.Add(this.BLabel);
            this.RGBGroup.Controls.Add(this.GLabel);
            this.RGBGroup.Controls.Add(this.RLabel);
            this.RGBGroup.Controls.Add(this.BValue);
            this.RGBGroup.Controls.Add(this.GValue);
            this.RGBGroup.Controls.Add(this.RValue);
            resources.ApplyResources(this.RGBGroup, "RGBGroup");
            this.RGBGroup.Name = "RGBGroup";
            this.RGBGroup.TabStop = false;
            // 
            // BLabel
            // 
            resources.ApplyResources(this.BLabel, "BLabel");
            this.BLabel.Name = "BLabel";
            // 
            // GLabel
            // 
            resources.ApplyResources(this.GLabel, "GLabel");
            this.GLabel.Name = "GLabel";
            // 
            // RLabel
            // 
            resources.ApplyResources(this.RLabel, "RLabel");
            this.RLabel.Name = "RLabel";
            // 
            // BValue
            // 
            resources.ApplyResources(this.BValue, "BValue");
            this.BValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BValue.Name = "BValue";
            this.BValue.ValueChanged += new System.EventHandler(this.RGBValueChanged);
            // 
            // GValue
            // 
            resources.ApplyResources(this.GValue, "GValue");
            this.GValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GValue.Name = "GValue";
            this.GValue.ValueChanged += new System.EventHandler(this.RGBValueChanged);
            // 
            // RValue
            // 
            resources.ApplyResources(this.RValue, "RValue");
            this.RValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RValue.Name = "RValue";
            this.RValue.ValueChanged += new System.EventHandler(this.RGBValueChanged);
            // 
            // HashValue
            // 
            this.HashValue.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.HashValue, "HashValue");
            this.HashValue.Name = "HashValue";
            this.HashValue.ReadOnly = true;
            // 
            // HSLGroup
            // 
            this.HSLGroup.Controls.Add(this.LLabel);
            this.HSLGroup.Controls.Add(this.SLabel);
            this.HSLGroup.Controls.Add(this.HLabel);
            this.HSLGroup.Controls.Add(this.LValue);
            this.HSLGroup.Controls.Add(this.SValue);
            this.HSLGroup.Controls.Add(this.HValue);
            resources.ApplyResources(this.HSLGroup, "HSLGroup");
            this.HSLGroup.Name = "HSLGroup";
            this.HSLGroup.TabStop = false;
            // 
            // LLabel
            // 
            resources.ApplyResources(this.LLabel, "LLabel");
            this.LLabel.Name = "LLabel";
            // 
            // SLabel
            // 
            resources.ApplyResources(this.SLabel, "SLabel");
            this.SLabel.Name = "SLabel";
            // 
            // HLabel
            // 
            resources.ApplyResources(this.HLabel, "HLabel");
            this.HLabel.Name = "HLabel";
            // 
            // LValue
            // 
            this.LValue.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.LValue, "LValue");
            this.LValue.Name = "LValue";
            this.LValue.ReadOnly = true;
            this.LValue.ValueChanged += new System.EventHandler(this.HSLValueChanged);
            // 
            // SValue
            // 
            this.SValue.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.SValue, "SValue");
            this.SValue.Name = "SValue";
            this.SValue.ReadOnly = true;
            this.SValue.ValueChanged += new System.EventHandler(this.HSLValueChanged);
            // 
            // HValue
            // 
            this.HValue.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.HValue, "HValue");
            this.HValue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.HValue.Name = "HValue";
            this.HValue.ReadOnly = true;
            this.HValue.ValueChanged += new System.EventHandler(this.HSLValueChanged);
            // 
            // HashCodeGroup
            // 
            this.HashCodeGroup.Controls.Add(this.HashValue);
            resources.ApplyResources(this.HashCodeGroup, "HashCodeGroup");
            this.HashCodeGroup.Name = "HashCodeGroup";
            this.HashCodeGroup.TabStop = false;
            // 
            // HexGroup
            // 
            this.HexGroup.Controls.Add(this.HexValue);
            resources.ApplyResources(this.HexGroup, "HexGroup");
            this.HexGroup.Name = "HexGroup";
            this.HexGroup.TabStop = false;
            // 
            // HexValue
            // 
            resources.ApplyResources(this.HexValue, "HexValue");
            this.HexValue.Name = "HexValue";
            this.HexValue.TextChanged += new System.EventHandler(this.HexValueChanged);
            // 
            // SelectColorButton
            // 
            resources.ApplyResources(this.SelectColorButton, "SelectColorButton");
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // OLEGroup
            // 
            this.OLEGroup.Controls.Add(this.OLEValue);
            resources.ApplyResources(this.OLEGroup, "OLEGroup");
            this.OLEGroup.Name = "OLEGroup";
            this.OLEGroup.TabStop = false;
            // 
            // OLEValue
            // 
            resources.ApplyResources(this.OLEValue, "OLEValue");
            this.OLEValue.Name = "OLEValue";
            this.OLEValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OLEValueChanged);
            // 
            // ArgbGroup
            // 
            this.ArgbGroup.Controls.Add(this.ArgbValue);
            resources.ApplyResources(this.ArgbGroup, "ArgbGroup");
            this.ArgbGroup.Name = "ArgbGroup";
            this.ArgbGroup.TabStop = false;
            // 
            // ArgbValue
            // 
            this.ArgbValue.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.ArgbValue, "ArgbValue");
            this.ArgbValue.Name = "ArgbValue";
            this.ArgbValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArgbValueChanged);
            // 
            // CMYGroup
            // 
            this.CMYGroup.Controls.Add(this.YLabel);
            this.CMYGroup.Controls.Add(this.MLabel);
            this.CMYGroup.Controls.Add(this.CLabel);
            this.CMYGroup.Controls.Add(this.YValue);
            this.CMYGroup.Controls.Add(this.MValue);
            this.CMYGroup.Controls.Add(this.CValue);
            resources.ApplyResources(this.CMYGroup, "CMYGroup");
            this.CMYGroup.Name = "CMYGroup";
            this.CMYGroup.TabStop = false;
            // 
            // YLabel
            // 
            resources.ApplyResources(this.YLabel, "YLabel");
            this.YLabel.Name = "YLabel";
            // 
            // MLabel
            // 
            resources.ApplyResources(this.MLabel, "MLabel");
            this.MLabel.Name = "MLabel";
            // 
            // CLabel
            // 
            resources.ApplyResources(this.CLabel, "CLabel");
            this.CLabel.Name = "CLabel";
            // 
            // YValue
            // 
            resources.ApplyResources(this.YValue, "YValue");
            this.YValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YValue.Name = "YValue";
            this.YValue.ValueChanged += new System.EventHandler(this.CMYValueChanged);
            // 
            // MValue
            // 
            resources.ApplyResources(this.MValue, "MValue");
            this.MValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MValue.Name = "MValue";
            this.MValue.ValueChanged += new System.EventHandler(this.CMYValueChanged);
            // 
            // CValue
            // 
            resources.ApplyResources(this.CValue, "CValue");
            this.CValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CValue.Name = "CValue";
            this.CValue.ValueChanged += new System.EventHandler(this.CMYValueChanged);
            // 
            // AboutButton
            // 
            resources.ApplyResources(this.AboutButton, "AboutButton");
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // DoAlwaysOnTop
            // 
            resources.ApplyResources(this.DoAlwaysOnTop, "DoAlwaysOnTop");
            this.DoAlwaysOnTop.Name = "DoAlwaysOnTop";
            this.DoAlwaysOnTop.UseVisualStyleBackColor = true;
            this.DoAlwaysOnTop.CheckedChanged += new System.EventHandler(this.DoAlwaysOnTop_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::ColSel.Properties.Resources.colsel_logo;
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.DoAlwaysOnTop);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.CMYGroup);
            this.Controls.Add(this.OLEGroup);
            this.Controls.Add(this.ArgbGroup);
            this.Controls.Add(this.SelectColorButton);
            this.Controls.Add(this.HexGroup);
            this.Controls.Add(this.HashCodeGroup);
            this.Controls.Add(this.HSLGroup);
            this.Controls.Add(this.RGBGroup);
            this.Controls.Add(this.ColorDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ColSel.Properties.Resources.colsel;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RGBGroup.ResumeLayout(false);
            this.RGBGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RValue)).EndInit();
            this.HSLGroup.ResumeLayout(false);
            this.HSLGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HValue)).EndInit();
            this.HashCodeGroup.ResumeLayout(false);
            this.HashCodeGroup.PerformLayout();
            this.HexGroup.ResumeLayout(false);
            this.HexGroup.PerformLayout();
            this.OLEGroup.ResumeLayout(false);
            this.OLEGroup.PerformLayout();
            this.ArgbGroup.ResumeLayout(false);
            this.ArgbGroup.PerformLayout();
            this.CMYGroup.ResumeLayout(false);
            this.CMYGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel ColorDisplay;
        private GroupBox RGBGroup;
        private Label BLabel;
        private Label GLabel;
        private Label RLabel;
        private NumericUpDown BValue;
        private NumericUpDown GValue;
        private NumericUpDown RValue;
        private TextBox HashValue;
        private GroupBox HSLGroup;
        private Label LLabel;
        private Label SLabel;
        private Label HLabel;
        private NumericUpDown LValue;
        private NumericUpDown SValue;
        private NumericUpDown HValue;
        private GroupBox HashCodeGroup;
        private GroupBox HexGroup;
        private TextBox HexValue;
        private Button SelectColorButton;
        private GroupBox OLEGroup;
        private TextBox OLEValue;
        private GroupBox ArgbGroup;
        private TextBox ArgbValue;
        private GroupBox CMYGroup;
        private Label YLabel;
        private Label MLabel;
        private Label CLabel;
        private NumericUpDown YValue;
        private NumericUpDown MValue;
        private NumericUpDown CValue;
        private Button AboutButton;
        private CheckBox DoAlwaysOnTop;
        private PictureBox LogoPictureBox;
    }
}