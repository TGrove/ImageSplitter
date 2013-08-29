namespace ImageSplitter
{
    partial class Form1
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
            this.ShowGridCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SettingUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.SettingsUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.SplitWidthLabel = new System.Windows.Forms.Label();
            this.SplitHeightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SplitImageBox = new System.Windows.Forms.PictureBox();
            this.SourceImageBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaddingUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SplitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SettingUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaddingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowGridCheckBox
            // 
            this.ShowGridCheckBox.AutoSize = true;
            this.ShowGridCheckBox.Checked = true;
            this.ShowGridCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowGridCheckBox.Location = new System.Drawing.Point(10, 31);
            this.ShowGridCheckBox.Name = "ShowGridCheckBox";
            this.ShowGridCheckBox.Size = new System.Drawing.Size(75, 17);
            this.ShowGridCheckBox.TabIndex = 0;
            this.ShowGridCheckBox.Text = "Show Grid";
            this.ShowGridCheckBox.UseVisualStyleBackColor = true;
            this.ShowGridCheckBox.CheckStateChanged += new System.EventHandler(this.ShowGridCheckBox_CheckStateChanged);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(713, 18);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(133, 38);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SettingUpDownWidth
            // 
            this.SettingUpDownWidth.Location = new System.Drawing.Point(13, 77);
            this.SettingUpDownWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SettingUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingUpDownWidth.Name = "SettingUpDownWidth";
            this.SettingUpDownWidth.Size = new System.Drawing.Size(120, 20);
            this.SettingUpDownWidth.TabIndex = 4;
            this.SettingUpDownWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.SettingUpDownWidth.ValueChanged += new System.EventHandler(this.SettingUpDownWidth_ValueChanged);
            // 
            // SettingsUpDownHeight
            // 
            this.SettingsUpDownHeight.Location = new System.Drawing.Point(13, 137);
            this.SettingsUpDownHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SettingsUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SettingsUpDownHeight.Name = "SettingsUpDownHeight";
            this.SettingsUpDownHeight.Size = new System.Drawing.Size(120, 20);
            this.SettingsUpDownHeight.TabIndex = 5;
            this.SettingsUpDownHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.SettingsUpDownHeight.ValueChanged += new System.EventHandler(this.SettingsUpDownHeight_ValueChanged);
            // 
            // SplitWidthLabel
            // 
            this.SplitWidthLabel.AutoSize = true;
            this.SplitWidthLabel.Location = new System.Drawing.Point(10, 61);
            this.SplitWidthLabel.Name = "SplitWidthLabel";
            this.SplitWidthLabel.Size = new System.Drawing.Size(56, 13);
            this.SplitWidthLabel.TabIndex = 6;
            this.SplitWidthLabel.Text = "Width (Px)";
            // 
            // SplitHeightLabel
            // 
            this.SplitHeightLabel.AutoSize = true;
            this.SplitHeightLabel.Location = new System.Drawing.Point(10, 121);
            this.SplitHeightLabel.Name = "SplitHeightLabel";
            this.SplitHeightLabel.Size = new System.Drawing.Size(59, 13);
            this.SplitHeightLabel.TabIndex = 7;
            this.SplitHeightLabel.Text = "Height (Px)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Split";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // SplitImageBox
            // 
            this.SplitImageBox.BackColor = System.Drawing.SystemColors.Window;
            this.SplitImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitImageBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SplitImageBox.Location = new System.Drawing.Point(12, 401);
            this.SplitImageBox.Name = "SplitImageBox";
            this.SplitImageBox.Size = new System.Drawing.Size(677, 345);
            this.SplitImageBox.TabIndex = 1;
            this.SplitImageBox.TabStop = false;
            this.SplitImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitImageBox_Paint);
            // 
            // SourceImageBox
            // 
            this.SourceImageBox.BackColor = System.Drawing.SystemColors.Window;
            this.SourceImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceImageBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SourceImageBox.Location = new System.Drawing.Point(12, 20);
            this.SourceImageBox.Name = "SourceImageBox";
            this.SourceImageBox.Size = new System.Drawing.Size(677, 345);
            this.SourceImageBox.TabIndex = 0;
            this.SourceImageBox.TabStop = false;
            this.SourceImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SourceImageBox_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaddingUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SettingsUpDownHeight);
            this.groupBox1.Controls.Add(this.SettingUpDownWidth);
            this.groupBox1.Controls.Add(this.SplitHeightLabel);
            this.groupBox1.Controls.Add(this.SplitWidthLabel);
            this.groupBox1.Controls.Add(this.ShowGridCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(713, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 270);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Split Properties";
            // 
            // PaddingUpDown
            // 
            this.PaddingUpDown.Location = new System.Drawing.Point(13, 192);
            this.PaddingUpDown.Name = "PaddingUpDown";
            this.PaddingUpDown.Size = new System.Drawing.Size(120, 20);
            this.PaddingUpDown.TabIndex = 9;
            this.PaddingUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaddingUpDown.ValueChanged += new System.EventHandler(this.PaddingUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Padding";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(713, 134);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(133, 38);
            this.ExportButton.TabIndex = 9;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // SplitButton
            // 
            this.SplitButton.Location = new System.Drawing.Point(713, 74);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(133, 38);
            this.SplitButton.TabIndex = 8;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AutoUpgradeEnabled = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select a folder to save peices into.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 813);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.SplitImageBox);
            this.Controls.Add(this.SourceImageBox);
            this.Controls.Add(this.SplitButton);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.SettingUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaddingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowGridCheckBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.NumericUpDown SettingUpDownWidth;
        private System.Windows.Forms.NumericUpDown SettingsUpDownHeight;
        private System.Windows.Forms.Label SplitWidthLabel;
        private System.Windows.Forms.Label SplitHeightLabel;
        private System.Windows.Forms.PictureBox SourceImageBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.PictureBox SplitImageBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown PaddingUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

