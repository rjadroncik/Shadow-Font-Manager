namespace ShadowFontEditor
{
    partial class ShadowFontEditor
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.resolutionComboBoxLabel = new System.Windows.Forms.ToolStripLabel();
            this.resolutionComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.imageOptionsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.glyphBoxesButton = new System.Windows.Forms.ToolStripButton();
            this.boundingBoxesButton = new System.Windows.Forms.ToolStripButton();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.characterSetPanel = new System.Windows.Forms.Panel();
            this.characterSetTextBox = new System.Windows.Forms.RichTextBox();
            this.characterSetLabel = new System.Windows.Forms.Label();
            this.zoomGroupBox = new System.Windows.Forms.GroupBox();
            this.zoomDisplay = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.glyphInsetsGroupBox = new System.Windows.Forms.GroupBox();
            this.bottomInsetLabel = new System.Windows.Forms.Label();
            this.topInsetLabel = new System.Windows.Forms.Label();
            this.rightInsetLabel = new System.Windows.Forms.Label();
            this.leftInsetLabel = new System.Windows.Forms.Label();
            this.bottomInsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.topInsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.rightInsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.leftInsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.fontPictureBox = new System.Windows.Forms.PictureBox();
            this.imageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.characterSetPanel.SuspendLayout();
            this.zoomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.glyphInsetsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomInsetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topInsetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightInsetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftInsetUpDown)).BeginInit();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontPictureBox)).BeginInit();
            this.imageContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolutionComboBoxLabel,
            this.resolutionComboBox,
            this.imageOptionsSeparator,
            this.glyphBoxesButton,
            this.boundingBoxesButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(526, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // resolutionComboBoxLabel
            // 
            this.resolutionComboBoxLabel.Name = "resolutionComboBoxLabel";
            this.resolutionComboBoxLabel.Size = new System.Drawing.Size(62, 22);
            this.resolutionComboBoxLabel.Text = "Image size:";
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096"});
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(75, 25);
            this.resolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.onImageSizeChanged);
            // 
            // imageOptionsSeparator
            // 
            this.imageOptionsSeparator.Name = "imageOptionsSeparator";
            this.imageOptionsSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // glyphBoxesButton
            // 
            this.glyphBoxesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.glyphBoxesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.glyphBoxesButton.Name = "glyphBoxesButton";
            this.glyphBoxesButton.Size = new System.Drawing.Size(70, 22);
            this.glyphBoxesButton.Text = "Glyph Boxes";
            this.glyphBoxesButton.Click += new System.EventHandler(this.onGlyphBoxesVisibilityChange);
            // 
            // boundingBoxesButton
            // 
            this.boundingBoxesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boundingBoxesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boundingBoxesButton.Name = "boundingBoxesButton";
            this.boundingBoxesButton.Size = new System.Drawing.Size(87, 22);
            this.boundingBoxesButton.Text = "Bounding Boxes";
            this.boundingBoxesButton.Click += new System.EventHandler(this.onBoundingBoxesVisibilityChange);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.characterSetPanel);
            this.rightPanel.Controls.Add(this.zoomGroupBox);
            this.rightPanel.Controls.Add(this.glyphInsetsGroupBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(414, 25);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(2);
            this.rightPanel.Size = new System.Drawing.Size(112, 368);
            this.rightPanel.TabIndex = 5;
            // 
            // characterSetPanel
            // 
            this.characterSetPanel.Controls.Add(this.characterSetTextBox);
            this.characterSetPanel.Controls.Add(this.characterSetLabel);
            this.characterSetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterSetPanel.Location = new System.Drawing.Point(2, 62);
            this.characterSetPanel.Name = "characterSetPanel";
            this.characterSetPanel.Size = new System.Drawing.Size(108, 179);
            this.characterSetPanel.TabIndex = 4;
            // 
            // characterSetTextBox
            // 
            this.characterSetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterSetTextBox.Location = new System.Drawing.Point(0, 13);
            this.characterSetTextBox.Name = "characterSetTextBox";
            this.characterSetTextBox.Size = new System.Drawing.Size(108, 166);
            this.characterSetTextBox.TabIndex = 10;
            this.characterSetTextBox.Text = " !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnop" +
                "qrstuvwxyz{|}~";
            this.characterSetTextBox.TextChanged += new System.EventHandler(this.onCharacterSetChanged);
            // 
            // characterSetLabel
            // 
            this.characterSetLabel.AutoSize = true;
            this.characterSetLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.characterSetLabel.Location = new System.Drawing.Point(0, 0);
            this.characterSetLabel.Name = "characterSetLabel";
            this.characterSetLabel.Size = new System.Drawing.Size(73, 13);
            this.characterSetLabel.TabIndex = 9;
            this.characterSetLabel.Text = "Character set:";
            // 
            // zoomGroupBox
            // 
            this.zoomGroupBox.Controls.Add(this.zoomDisplay);
            this.zoomGroupBox.Controls.Add(this.zoomTrackBar);
            this.zoomGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.zoomGroupBox.Location = new System.Drawing.Point(2, 2);
            this.zoomGroupBox.Name = "zoomGroupBox";
            this.zoomGroupBox.Size = new System.Drawing.Size(108, 60);
            this.zoomGroupBox.TabIndex = 3;
            this.zoomGroupBox.TabStop = false;
            this.zoomGroupBox.Text = "Zoom:";
            // 
            // zoomDisplay
            // 
            this.zoomDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomDisplay.Location = new System.Drawing.Point(34, 38);
            this.zoomDisplay.Name = "zoomDisplay";
            this.zoomDisplay.Size = new System.Drawing.Size(46, 18);
            this.zoomDisplay.TabIndex = 100;
            this.zoomDisplay.Text = "1000%";
            this.zoomDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.AutoSize = false;
            this.zoomTrackBar.LargeChange = 1;
            this.zoomTrackBar.Location = new System.Drawing.Point(3, 19);
            this.zoomTrackBar.Maximum = 8;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(102, 20);
            this.zoomTrackBar.TabIndex = 0;
            this.zoomTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomTrackBar.Value = 4;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.onZoomChanged);
            // 
            // glyphInsetsGroupBox
            // 
            this.glyphInsetsGroupBox.Controls.Add(this.bottomInsetLabel);
            this.glyphInsetsGroupBox.Controls.Add(this.topInsetLabel);
            this.glyphInsetsGroupBox.Controls.Add(this.rightInsetLabel);
            this.glyphInsetsGroupBox.Controls.Add(this.leftInsetLabel);
            this.glyphInsetsGroupBox.Controls.Add(this.bottomInsetUpDown);
            this.glyphInsetsGroupBox.Controls.Add(this.topInsetUpDown);
            this.glyphInsetsGroupBox.Controls.Add(this.rightInsetUpDown);
            this.glyphInsetsGroupBox.Controls.Add(this.leftInsetUpDown);
            this.glyphInsetsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.glyphInsetsGroupBox.Location = new System.Drawing.Point(2, 241);
            this.glyphInsetsGroupBox.Name = "glyphInsetsGroupBox";
            this.glyphInsetsGroupBox.Size = new System.Drawing.Size(108, 125);
            this.glyphInsetsGroupBox.TabIndex = 3;
            this.glyphInsetsGroupBox.TabStop = false;
            this.glyphInsetsGroupBox.Text = "Glyph insets";
            // 
            // bottomInsetLabel
            // 
            this.bottomInsetLabel.AutoSize = true;
            this.bottomInsetLabel.Location = new System.Drawing.Point(2, 99);
            this.bottomInsetLabel.Name = "bottomInsetLabel";
            this.bottomInsetLabel.Size = new System.Drawing.Size(43, 13);
            this.bottomInsetLabel.TabIndex = 19;
            this.bottomInsetLabel.Text = "Bottom:";
            // 
            // topInsetLabel
            // 
            this.topInsetLabel.AutoSize = true;
            this.topInsetLabel.Location = new System.Drawing.Point(16, 73);
            this.topInsetLabel.Name = "topInsetLabel";
            this.topInsetLabel.Size = new System.Drawing.Size(29, 13);
            this.topInsetLabel.TabIndex = 18;
            this.topInsetLabel.Text = "Top:";
            // 
            // rightInsetLabel
            // 
            this.rightInsetLabel.AutoSize = true;
            this.rightInsetLabel.Location = new System.Drawing.Point(10, 47);
            this.rightInsetLabel.Name = "rightInsetLabel";
            this.rightInsetLabel.Size = new System.Drawing.Size(35, 13);
            this.rightInsetLabel.TabIndex = 17;
            this.rightInsetLabel.Text = "Right:";
            // 
            // leftInsetLabel
            // 
            this.leftInsetLabel.AutoSize = true;
            this.leftInsetLabel.Location = new System.Drawing.Point(17, 21);
            this.leftInsetLabel.Name = "leftInsetLabel";
            this.leftInsetLabel.Size = new System.Drawing.Size(28, 13);
            this.leftInsetLabel.TabIndex = 16;
            this.leftInsetLabel.Text = "Left:";
            // 
            // bottomInsetUpDown
            // 
            this.bottomInsetUpDown.Location = new System.Drawing.Point(45, 97);
            this.bottomInsetUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.bottomInsetUpDown.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.bottomInsetUpDown.Name = "bottomInsetUpDown";
            this.bottomInsetUpDown.Size = new System.Drawing.Size(57, 20);
            this.bottomInsetUpDown.TabIndex = 15;
            this.bottomInsetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bottomInsetUpDown.ValueChanged += new System.EventHandler(this.onInsetsChanged);
            // 
            // topInsetUpDown
            // 
            this.topInsetUpDown.Location = new System.Drawing.Point(45, 71);
            this.topInsetUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.topInsetUpDown.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.topInsetUpDown.Name = "topInsetUpDown";
            this.topInsetUpDown.Size = new System.Drawing.Size(57, 20);
            this.topInsetUpDown.TabIndex = 14;
            this.topInsetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.topInsetUpDown.ValueChanged += new System.EventHandler(this.onInsetsChanged);
            // 
            // rightInsetUpDown
            // 
            this.rightInsetUpDown.Location = new System.Drawing.Point(45, 45);
            this.rightInsetUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.rightInsetUpDown.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.rightInsetUpDown.Name = "rightInsetUpDown";
            this.rightInsetUpDown.Size = new System.Drawing.Size(57, 20);
            this.rightInsetUpDown.TabIndex = 13;
            this.rightInsetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rightInsetUpDown.ValueChanged += new System.EventHandler(this.onInsetsChanged);
            // 
            // leftInsetUpDown
            // 
            this.leftInsetUpDown.Location = new System.Drawing.Point(45, 19);
            this.leftInsetUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.leftInsetUpDown.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.leftInsetUpDown.Name = "leftInsetUpDown";
            this.leftInsetUpDown.Size = new System.Drawing.Size(57, 20);
            this.leftInsetUpDown.TabIndex = 12;
            this.leftInsetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.leftInsetUpDown.ValueChanged += new System.EventHandler(this.onInsetsChanged);
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.AutoScroll = true;
            this.pictureBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPanel.Controls.Add(this.fontPictureBox);
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPanel.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(414, 368);
            this.pictureBoxPanel.TabIndex = 7;
            // 
            // fontPictureBox
            // 
            this.fontPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fontPictureBox.InitialImage = null;
            this.fontPictureBox.Location = new System.Drawing.Point(0, 0);
            this.fontPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.fontPictureBox.MaximumSize = new System.Drawing.Size(4096, 4096);
            this.fontPictureBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.fontPictureBox.Name = "fontPictureBox";
            this.fontPictureBox.Size = new System.Drawing.Size(256, 256);
            this.fontPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fontPictureBox.TabIndex = 2;
            this.fontPictureBox.TabStop = false;
            this.fontPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onImageMouseClicked);
            // 
            // imageContextMenu
            // 
            this.imageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardMenuItem});
            this.imageContextMenu.Name = "contextMenuStrip1";
            this.imageContextMenu.Size = new System.Drawing.Size(200, 26);
            // 
            // copyToClipboardMenuItem
            // 
            this.copyToClipboardMenuItem.Name = "copyToClipboardMenuItem";
            this.copyToClipboardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToClipboardMenuItem.Size = new System.Drawing.Size(199, 22);
            this.copyToClipboardMenuItem.Text = "&Copy to Clipboard";
            this.copyToClipboardMenuItem.Click += new System.EventHandler(this.onImageCopyToClipboard);
            // 
            // ShadowFontEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.toolStrip);
            this.Name = "ShadowFontEditor";
            this.Size = new System.Drawing.Size(526, 393);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.characterSetPanel.ResumeLayout(false);
            this.characterSetPanel.PerformLayout();
            this.zoomGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.glyphInsetsGroupBox.ResumeLayout(false);
            this.glyphInsetsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomInsetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topInsetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightInsetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftInsetUpDown)).EndInit();
            this.pictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontPictureBox)).EndInit();
            this.imageContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox resolutionComboBox;
        private System.Windows.Forms.ToolStripSeparator imageOptionsSeparator;
        private System.Windows.Forms.ToolStripLabel resolutionComboBoxLabel;
        private System.Windows.Forms.ToolStripButton glyphBoxesButton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.PictureBox fontPictureBox;
        private System.Windows.Forms.GroupBox glyphInsetsGroupBox;
        private System.Windows.Forms.Label bottomInsetLabel;
        private System.Windows.Forms.Label topInsetLabel;
        private System.Windows.Forms.Label rightInsetLabel;
        private System.Windows.Forms.Label leftInsetLabel;
        private System.Windows.Forms.NumericUpDown bottomInsetUpDown;
        private System.Windows.Forms.NumericUpDown topInsetUpDown;
        private System.Windows.Forms.NumericUpDown rightInsetUpDown;
        private System.Windows.Forms.NumericUpDown leftInsetUpDown;
        private System.Windows.Forms.Panel characterSetPanel;
        private System.Windows.Forms.RichTextBox characterSetTextBox;
        private System.Windows.Forms.Label characterSetLabel;
        private System.Windows.Forms.GroupBox zoomGroupBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label zoomDisplay;
        private System.Windows.Forms.ContextMenuStrip imageContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardMenuItem;
        private System.Windows.Forms.ToolStripButton boundingBoxesButton;


    }
}
