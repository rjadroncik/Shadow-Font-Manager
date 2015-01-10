using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Xml;
using System.Globalization;

namespace ShadowFontManager
{
    public partial class MainWindow : Form
    {
        private void EnumerateInstalledFonts()
        {
            InstalledFontCollection InstalledFonts = new InstalledFontCollection();

            for( int i = 0; i < InstalledFonts.Families.Length; i++ )
            {
                TreeNode TreeNode = new TreeNode(InstalledFonts.Families[i].Name);

                TreeNode.Tag = InstalledFonts.Families[i];

                fontBorwser.Nodes.Add(TreeNode);

                if (InstalledFonts.Families[i].Name == "Tahoma")
                {
                    fontBorwser.SelectedNode = TreeNode;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            EnumerateInstalledFonts();

            fontSize.Value = 15;
            UpdateStyleOptions((FontFamily)fontBorwser.SelectedNode.Tag);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateStyleOptions(FontFamily aFontFamily)
        {
            FontStyle SelectedStyle = FontStyle.Regular;

            if (fontStyle.SelectedItem != null) { SelectedStyle = (FontStyle)fontStyle.SelectedItem; }

            fontStyle.Items.Clear();

            if (aFontFamily.IsStyleAvailable(FontStyle.Regular)) { fontStyle.Items.Add(FontStyle.Regular); }
            if (aFontFamily.IsStyleAvailable(FontStyle.Regular)) { fontStyle.Items.Add(FontStyle.Italic); }
            if (aFontFamily.IsStyleAvailable(FontStyle.Regular)) { fontStyle.Items.Add(FontStyle.Bold); }
            if (aFontFamily.IsStyleAvailable(FontStyle.Regular)) { fontStyle.Items.Add(FontStyle.Bold | FontStyle.Italic); }

            if (fontStyle.Items.Contains(SelectedStyle)) { fontStyle.SelectedItem = SelectedStyle; }
        }

        private void OnFontChange(object sender, TreeViewEventArgs e)
        {
            if (fontBorwser.SelectedNode.Tag == null) { return; }

            UpdateStyleOptions((FontFamily)fontBorwser.SelectedNode.Tag);
            if (fontStyle.SelectedItem == null) { return; }

            fontEditor.InputFont = new Font((FontFamily)fontBorwser.SelectedNode.Tag, (float)fontSize.Value, (FontStyle)fontStyle.SelectedItem, GraphicsUnit.Pixel);
            fontEditor.RebuildImage();
        }

        private void OnFontChange(object sender, EventArgs e)
        {
            if (fontBorwser.SelectedNode.Tag == null) { return; }
            if (fontStyle.SelectedItem == null) { return; }

            fontEditor.InputFont = new Font((FontFamily)fontBorwser.SelectedNode.Tag, (float)fontSize.Value, (FontStyle)fontStyle.SelectedItem, GraphicsUnit.Pixel);
            fontEditor.RebuildImage();
        }

        private void OnImageSave(object sender, EventArgs e)
        {
            saveTextureDialog.Title = "Image: Save as Texture";
            saveTextureDialog.ShowDialog();

            if (!saveTextureDialog.FileName.Equals(""))
            {
                float TempZoom = fontEditor.ImageZoom;

                string[] FileNameParts = saveTextureDialog.FileName.Split('.');
                Stream FileStream = saveTextureDialog.OpenFile();

                switch (FileNameParts[FileNameParts.Length - 1].ToLower())
                {
                    case "bmp":
                        {
                            fontEditor.Image.Save(FileStream, ImageFormat.Bmp);
                            break;
                        }
                    case "jpg":
                        {
                            fontEditor.Image.Save(FileStream, ImageFormat.Jpeg);
                            break;
                        }
                }

                FileStream.Close();
            }
        }

        private void OnImageToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(fontEditor.Image, true);
        }

        private void OnAbout(object sender, EventArgs e)
        {
            AboutDialog About = new AboutDialog();
            //About.Parent = this;
            About.ShowDialog();
        }

        private void OnExportToXML(object sender, EventArgs e)
        {
            saveXMLDocument.Title = "Export to XML: Bounding Boxes";
            saveXMLDocument.ShowDialog();

            if (!saveXMLDocument.FileName.Equals(""))
            {
                XmlWriter Writer = XmlWriter.Create(saveXMLDocument.OpenFile());
                
                List<Rectangle> BoundingBoxes = fontEditor.BoundingBoxes;
                List<int>       GlyphWidths   = fontEditor.GlyphWidths;
                String          CharacterSet  = fontEditor.CharacterSet;
         
                XmlDocument Document = new XmlDocument();
                XmlElement Root = Document.CreateElement("font");
         
                //Glyph count
                {
                    XmlAttribute AnAttribute = Document.CreateAttribute("glyphCount");
                    AnAttribute.Value = (BoundingBoxes.Count).ToString();
                    Root.Attributes.Append(AnAttribute);
                }

                //Glyph insets
                {
                    XmlAttribute AnAttribute = Document.CreateAttribute("glyphInsets");
                    AnAttribute.Value = (fontEditor.GlyphInsets.X).ToString() + " " +
                                        (fontEditor.GlyphInsets.Y).ToString() + " " +
                                        (fontEditor.GlyphInsets.Width).ToString() + " " +
                                        (fontEditor.GlyphInsets.Height).ToString() + " ";
                    Root.Attributes.Append(AnAttribute);
                }

                //Image size
                {
                    XmlAttribute AnAttribute = Document.CreateAttribute("imageSize");
                    AnAttribute.Value = (fontEditor.ImageResolution).ToString();
                    Root.Attributes.Append(AnAttribute);
                }

                //Character max
                {
                    int max = 0;
                    for (int i = 0; i < CharacterSet.Length; i++)
                    {
                        if (max < (int)CharacterSet[i]) { max = (int)CharacterSet[i]; }
                    }

                    XmlAttribute AnAttribute = Document.CreateAttribute("characterMax");
                    AnAttribute.Value = max.ToString();
                    Root.Attributes.Append(AnAttribute);
                }

                //font height
                {
                    int max = 0;
                    for (int i = 0; i < CharacterSet.Length; i++)
                    {
                        if (max < (int)CharacterSet[i]) { max = (int)CharacterSet[i]; }
                    }

                    XmlAttribute AnAttribute = Document.CreateAttribute("height");
                    AnAttribute.Value = ((int)fontEditor.InputFont.Size).ToString();
                    Root.Attributes.Append(AnAttribute);
                }

                for( int i = 0; i < BoundingBoxes.Count; i++)
                {
                    XmlElement CurrentElement = Document.CreateElement("glyph");

                    //Character
                    {

                        XmlAttribute AnAttribute = Document.CreateAttribute("character");
                        AnAttribute.Value = ((int)CharacterSet[i]).ToString();
                        CurrentElement.Attributes.Append(AnAttribute);
                    }

                    //Width
                    {
                        XmlAttribute AnAttribute = Document.CreateAttribute("width");
                        AnAttribute.Value = (GlyphWidths[i]).ToString();
                        CurrentElement.Attributes.Append(AnAttribute);
                    }

                    //Bounding box
                    {
                        XmlAttribute AnAttribute = Document.CreateAttribute("x");
                        AnAttribute.Value = (BoundingBoxes[i].X).ToString() + " " + (BoundingBoxes[i].Y).ToString() + " " + (BoundingBoxes[i].Width).ToString() + " " + (BoundingBoxes[i].Height).ToString();
                        CurrentElement.Attributes.Append(AnAttribute);
                    }

                    Root.AppendChild(CurrentElement);
                }

                Document.AppendChild(Root);

                Document.WriteTo(Writer);
                Writer.Close();
            }
        }

        private void OnProjectSaveAs(object sender, EventArgs e)
        {
            saveXMLDocument.Title = "Save Project As";
            saveXMLDocument.ShowDialog();
           
            if (!saveXMLDocument.FileName.Equals(""))
            {
                projectFile = saveXMLDocument.FileName;
                OnProjectSave(sender, e);
            }
        }

        private void OnProjectSave(object sender, EventArgs e)
        {
            if (projectFile == null)
            {
                OnProjectSaveAs(sender, e);
                return;
            }

            XmlWriter Writer = XmlWriter.Create(saveXMLDocument.OpenFile());

            XmlDocument Document = new XmlDocument();
            XmlElement Root = Document.CreateElement("ShadowFontManagerProject");

            //Font attributes
            XmlElement CurrentElement = Document.CreateElement("Font");

            XmlAttribute CurrentAttribute = Document.CreateAttribute("Name");
            CurrentAttribute.Value = fontBorwser.SelectedNode.Text;
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("Size");
            CurrentAttribute.Value = fontSize.Value.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("Style");
            CurrentAttribute.Value = fontStyle.SelectedItem.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            Root.AppendChild(CurrentElement);

            //Image attributes
            CurrentElement = Document.CreateElement("Image");

            CurrentAttribute = Document.CreateAttribute("Size");
            CurrentAttribute.Value = fontEditor.ImageResolution.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("Zoom");
            CurrentAttribute.Value = ((int)(fontEditor.ImageZoom * 100)).ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("BoundingBoxes");
            CurrentAttribute.Value = fontEditor.DrawBoundingBoxes.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("GlyphBoxes");
            CurrentAttribute.Value = fontEditor.DrawGlyphBoxes.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            Root.AppendChild(CurrentElement);

            //Character set
            CurrentElement = Document.CreateElement("CharacterSet");

            CurrentElement.AppendChild(Document.CreateTextNode(fontEditor.CharacterSet));

            Root.AppendChild(CurrentElement);

            //Image attributes
            CurrentElement = Document.CreateElement("GlyphInsets");

            CurrentAttribute = Document.CreateAttribute("Left");
            CurrentAttribute.Value = fontEditor.GlyphInsets.Left.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("Top");
            CurrentAttribute.Value = fontEditor.GlyphInsets.Top.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("Right");
            CurrentAttribute.Value = fontEditor.GlyphInsets.Width.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            CurrentAttribute = Document.CreateAttribute("Bottom");
            CurrentAttribute.Value = fontEditor.GlyphInsets.Height.ToString();
            CurrentElement.Attributes.Append(CurrentAttribute);

            Root.AppendChild(CurrentElement);

            //Add root to document
            Document.AppendChild(Root);

            //Write document & close file
            Document.WriteTo(Writer);
            Writer.Close();
        }

        private String projectFile;

        private void OnProjectOpen(object sender, EventArgs e)
        {
            openXMLDocument.Title = "Open Project";
            openXMLDocument.ShowDialog();

            if (!openXMLDocument.FileName.Equals(""))
            {
                projectFile = openXMLDocument.FileName;


            }
        }

        private OpenFileDialog openXMLDocument;
    }
}