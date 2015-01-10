using System.IO;
namespace ShadowFontManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projecToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.projectNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.projectSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.fontBorwser = new System.Windows.Forms.TreeView();
            this.availableFontsLabel = new System.Windows.Forms.Label();
            this.fontPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.fontStyle = new System.Windows.Forms.ComboBox();
            this.saveTextureDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveXMLDocument = new System.Windows.Forms.SaveFileDialog();
            this.openXMLDocument = new System.Windows.Forms.OpenFileDialog();
            this.fontEditor = new ShadowFontEditor.ShadowFontEditor();
            this.mainMenuStrip.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.fontPropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.projecToolStripMenu,
            this.helpToolStripMenuItem,
            this.imageToolStripMenu,
            this.dataToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenuStrip.Size = new System.Drawing.Size(642, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenu
            // 
            this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExitMenuItem});
            this.fileToolStripMenu.Name = "fileToolStripMenu";
            this.fileToolStripMenu.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenu.Text = "&File";
            // 
            // fileExitMenuItem
            // 
            this.fileExitMenuItem.Name = "fileExitMenuItem";
            this.fileExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileExitMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fileExitMenuItem.Text = "E&xit";
            this.fileExitMenuItem.Click += new System.EventHandler(this.OnApplicationExit);
            // 
            // projecToolStripMenu
            // 
            this.projecToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectNewMenuItem,
            this.projectOpenMenuItem,
            this.projectMenuItemSeparator,
            this.projectSaveMenuItem,
            this.projectSaveAsMenuItem});
            this.projecToolStripMenu.Name = "projecToolStripMenu";
            this.projecToolStripMenu.Size = new System.Drawing.Size(53, 20);
            this.projecToolStripMenu.Text = "&Project";
            // 
            // projectNewMenuItem
            // 
            this.projectNewMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projectNewMenuItem.Image")));
            this.projectNewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectNewMenuItem.Name = "projectNewMenuItem";
            this.projectNewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.projectNewMenuItem.Size = new System.Drawing.Size(163, 22);
            this.projectNewMenuItem.Text = "&New";
            // 
            // projectOpenMenuItem
            // 
            this.projectOpenMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projectOpenMenuItem.Image")));
            this.projectOpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectOpenMenuItem.Name = "projectOpenMenuItem";
            this.projectOpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.projectOpenMenuItem.Size = new System.Drawing.Size(163, 22);
            this.projectOpenMenuItem.Text = "&Open";
            this.projectOpenMenuItem.Click += new System.EventHandler(this.OnProjectOpen);
            // 
            // projectMenuItemSeparator
            // 
            this.projectMenuItemSeparator.Name = "projectMenuItemSeparator";
            this.projectMenuItemSeparator.Size = new System.Drawing.Size(160, 6);
            // 
            // projectSaveMenuItem
            // 
            this.projectSaveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projectSaveMenuItem.Image")));
            this.projectSaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectSaveMenuItem.Name = "projectSaveMenuItem";
            this.projectSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.projectSaveMenuItem.Size = new System.Drawing.Size(163, 22);
            this.projectSaveMenuItem.Text = "&Save";
            this.projectSaveMenuItem.Click += new System.EventHandler(this.OnProjectSave);
            // 
            // projectSaveAsMenuItem
            // 
            this.projectSaveAsMenuItem.Name = "projectSaveAsMenuItem";
            this.projectSaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.projectSaveAsMenuItem.Size = new System.Drawing.Size(163, 22);
            this.projectSaveAsMenuItem.Text = "Save &As";
            this.projectSaveAsMenuItem.Click += new System.EventHandler(this.OnProjectSaveAs);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAbout);
            // 
            // imageToolStripMenu
            // 
            this.imageToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageSaveMenuItem,
            this.imageToClipboardMenuItem});
            this.imageToolStripMenu.Name = "imageToolStripMenu";
            this.imageToolStripMenu.Size = new System.Drawing.Size(49, 20);
            this.imageToolStripMenu.Text = "&Image";
            // 
            // imageSaveMenuItem
            // 
            this.imageSaveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imageSaveMenuItem.Image")));
            this.imageSaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imageSaveMenuItem.Name = "imageSaveMenuItem";
            this.imageSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.imageSaveMenuItem.Size = new System.Drawing.Size(208, 22);
            this.imageSaveMenuItem.Text = "Save as &Texture";
            this.imageSaveMenuItem.Click += new System.EventHandler(this.OnImageSave);
            // 
            // imageToClipboardMenuItem
            // 
            this.imageToClipboardMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imageToClipboardMenuItem.Image")));
            this.imageToClipboardMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imageToClipboardMenuItem.Name = "imageToClipboardMenuItem";
            this.imageToClipboardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.imageToClipboardMenuItem.Size = new System.Drawing.Size(208, 22);
            this.imageToClipboardMenuItem.Text = "&Copy to clipboard";
            this.imageToClipboardMenuItem.Click += new System.EventHandler(this.OnImageToClipboard);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMLToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dataToolStripMenuItem.Text = "&Data";
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToXMLToolStripMenuItem.Text = "Export to XML";
            this.exportToXMLToolStripMenuItem.Click += new System.EventHandler(this.OnExportToXML);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panelLeftTop);
            this.leftPanel.Controls.Add(this.fontPropertiesGroupBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 24);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(2);
            this.leftPanel.Size = new System.Drawing.Size(190, 442);
            this.leftPanel.TabIndex = 10;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Controls.Add(this.fontBorwser);
            this.panelLeftTop.Controls.Add(this.availableFontsLabel);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftTop.Location = new System.Drawing.Point(2, 2);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(186, 379);
            this.panelLeftTop.TabIndex = 16;
            // 
            // fontBorwser
            // 
            this.fontBorwser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontBorwser.HideSelection = false;
            this.fontBorwser.Indent = 15;
            this.fontBorwser.Location = new System.Drawing.Point(0, 13);
            this.fontBorwser.Name = "fontBorwser";
            this.fontBorwser.ShowLines = false;
            this.fontBorwser.ShowPlusMinus = false;
            this.fontBorwser.ShowRootLines = false;
            this.fontBorwser.Size = new System.Drawing.Size(186, 366);
            this.fontBorwser.TabIndex = 4;
            this.fontBorwser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnFontChange);
            // 
            // availableFontsLabel
            // 
            this.availableFontsLabel.AutoSize = true;
            this.availableFontsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.availableFontsLabel.Location = new System.Drawing.Point(0, 0);
            this.availableFontsLabel.Name = "availableFontsLabel";
            this.availableFontsLabel.Size = new System.Drawing.Size(79, 13);
            this.availableFontsLabel.TabIndex = 3;
            this.availableFontsLabel.Text = "Available fonts:";
            // 
            // fontPropertiesGroupBox
            // 
            this.fontPropertiesGroupBox.Controls.Add(this.sizeLabel);
            this.fontPropertiesGroupBox.Controls.Add(this.fontSize);
            this.fontPropertiesGroupBox.Controls.Add(this.fontStyleLabel);
            this.fontPropertiesGroupBox.Controls.Add(this.fontStyle);
            this.fontPropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fontPropertiesGroupBox.Location = new System.Drawing.Point(2, 381);
            this.fontPropertiesGroupBox.Name = "fontPropertiesGroupBox";
            this.fontPropertiesGroupBox.Size = new System.Drawing.Size(186, 59);
            this.fontPropertiesGroupBox.TabIndex = 15;
            this.fontPropertiesGroupBox.TabStop = false;
            this.fontPropertiesGroupBox.Text = "Font properties";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(117, 16);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(50, 13);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "Size (px):";
            // 
            // fontSize
            // 
            this.fontSize.DecimalPlaces = 2;
            this.fontSize.Location = new System.Drawing.Point(120, 32);
            this.fontSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(60, 20);
            this.fontSize.TabIndex = 6;
            this.fontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fontSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.OnFontChange);
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Location = new System.Drawing.Point(3, 16);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(33, 13);
            this.fontStyleLabel.TabIndex = 5;
            this.fontStyleLabel.Text = "Style:";
            // 
            // fontStyle
            // 
            this.fontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontStyle.FormattingEnabled = true;
            this.fontStyle.Items.AddRange(new object[] {
            "Regular",
            "Bold",
            "Italic",
            "Bold italic"});
            this.fontStyle.Location = new System.Drawing.Point(6, 32);
            this.fontStyle.Name = "fontStyle";
            this.fontStyle.Size = new System.Drawing.Size(92, 21);
            this.fontStyle.TabIndex = 4;
            this.fontStyle.SelectedIndexChanged += new System.EventHandler(this.OnFontChange);
            // 
            // saveTextureDialog
            // 
            this.saveTextureDialog.DefaultExt = "bmp";
            this.saveTextureDialog.Filter = "Bitmap file (*.bmp)|*.bmp|JPEG file (*.jpg)|*.jpg";
            // 
            // saveXMLDocument
            // 
            this.saveXMLDocument.DefaultExt = "xml";
            this.saveXMLDocument.Filter = "XML file (*.xml)|*.xml";
            // 
            // openXMLDocument
            // 
            this.openXMLDocument.DefaultExt = "xml";
            this.openXMLDocument.Filter = "XML file (*.xml)|*.xml";
            // 
            // fontEditor
            // 
            this.fontEditor.CharacterSet = " !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnop" +
                "qrstuvwxyz{|}~";
            this.fontEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontEditor.DrawBoundingBoxes = false;
            this.fontEditor.DrawGlyphBoxes = false;
            this.fontEditor.ForeColor = System.Drawing.Color.Black;
            this.fontEditor.GlyphInsets = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.fontEditor.ImageResolution = 256;
            this.fontEditor.ImageZoom = 1F;
            this.fontEditor.InputFont = new System.Drawing.Font("Tahoma", 15F);
            this.fontEditor.Location = new System.Drawing.Point(190, 24);
            this.fontEditor.Name = "fontEditor";
            this.fontEditor.Size = new System.Drawing.Size(452, 442);
            this.fontEditor.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 466);
            this.Controls.Add(this.fontEditor);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "MainWindow";
            this.Text = "Shadow Font Manager";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.fontPropertiesGroupBox.ResumeLayout(false);
            this.fontPropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox fontPropertiesGroupBox;
        private System.Windows.Forms.Label fontStyleLabel;
        private System.Windows.Forms.ComboBox fontStyle;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem imageSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToClipboardMenuItem;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Label availableFontsLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fileExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projecToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem projectNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectOpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator projectMenuItemSeparator;
        private System.Windows.Forms.ToolStripMenuItem projectSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectSaveAsMenuItem;
        private System.Windows.Forms.SaveFileDialog saveTextureDialog;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveXMLDocument;
        private System.Windows.Forms.TreeView fontBorwser;
        private ShadowFontEditor.ShadowFontEditor fontEditor;
    }
}

