using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ShadowFontEditor
{
    public partial class ShadowFontEditor : UserControl
    {
        private int[] zoomValues = { 5, 10, 15, 20, 25, 30, 35, 40, 50, 60, 66, 75, 80, 90, 95, 100, 105, 110, 120, 130, 140, 150, 175, 200, 225, 250, 275, 300, 350, 400, 600 };

        private Font inputFont;
        private List<int> glyphWidths;
        private List<Rectangle> boundingBoxes;
    
        public ShadowFontEditor()
        {
            //Init private variables
            glyphWidths = new List<int>();
            boundingBoxes = new List<Rectangle>();

            //Int public properties
            InputFont = new Font("Tahoma", 15, FontStyle.Regular, GraphicsUnit.Pixel);
                                              
            //Initialize user interface
            InitializeComponent();

            resolutionComboBox.SelectedIndex = 1;

            zoomTrackBar.SetRange(0, zoomValues.Length - 1);
            zoomTrackBar.Value = (zoomValues.Length / 2);
            zoomDisplay.Text = zoomValues[zoomTrackBar.Value] + "%";

             //Init public properties   
            ImageResolution = 256;
            ImageZoom = 1.0f;

            String l_String = null;
            for (char i = (char)32; i < 127; i++) { l_String += new String(i, 1); }
            CharacterSet = l_String;
        }

        public int ImageResolution
        {
            get { return int.Parse(resolutionComboBox.SelectedItem.ToString()); }
            set 
            {
                for (int i = 0; i < resolutionComboBox.Items.Count; i++)
                {
                    if (((int.Parse(resolutionComboBox.Items[i].ToString()) - 1) <= value) && ((int.Parse(resolutionComboBox.Items[i].ToString()) + 1) >= value))
                    {
                        resolutionComboBox.SelectedIndex = i; return;
                    }
                }
            }
        }

        public Font InputFont
        {
            get { return inputFont; }
            set { inputFont = value; }
        }

        public string CharacterSet
        {
            get { return characterSetTextBox.Text; }
            set { characterSetTextBox.Text = value; }
        }

        public System.Drawing.Rectangle GlyphInsets
        {
            get 
            {
                return new Rectangle((int)leftInsetUpDown.Value, (int)topInsetUpDown.Value, (int)rightInsetUpDown.Value, (int)bottomInsetUpDown.Value); 
            }
            set 
            {
                leftInsetUpDown.Value   = (decimal)value.Left;
                topInsetUpDown.Value    = (decimal)value.Top;
                rightInsetUpDown.Value  = (decimal)value.Width;
                bottomInsetUpDown.Value = (decimal)value.Height;
            }
        }

        public float ImageZoom
        {
            get { return zoomValues[zoomTrackBar.Value] / 100.0f; }
            set 
            {
                for (int i = 0; i < zoomValues.Length; i++)
                {
                    if (((zoomValues[i] - 1) <= (value * 100)) && ((zoomValues[i] + 1) >= (value * 100)))
                    {
                        zoomTrackBar.Value = i;
                        zoomDisplay.Text = zoomValues[zoomTrackBar.Value] + "%";
                        return;
                    }
                }
            }
        }

        public Image Image
        {
            get { return fontPictureBox.Image; }
        }

        public System.Collections.Generic.List<int> GlyphWidths
        {
            get { return glyphWidths; }
        }

        public System.Collections.Generic.List<System.Drawing.Rectangle> BoundingBoxes
        {
            get { return boundingBoxes; }
        }

        public bool DrawBoundingBoxes
        {
            get { return boundingBoxesButton.Checked; }
            set { boundingBoxesButton.Checked = value; }
        }
        public bool DrawGlyphBoxes
        {
            get { return glyphBoxesButton.Checked; }
            set { glyphBoxesButton.Checked = value; }
        }

        private void onImageSizeChanged(object sender, EventArgs e)
        {
            pictureBoxPanel.AutoScrollPosition = new Point(0, 0);

            fontPictureBox.SetBounds(0, 0, (int)(ImageResolution * ImageZoom), (int)(ImageResolution * ImageZoom));

            RebuildImage();
        }

        public void RebuildImage()
        {
            fontPictureBox.Image = new Bitmap(ImageResolution, ImageResolution, PixelFormat.Format24bppRgb);
            if (CharacterSet.Length == 0) { return; }

            Graphics AGraphics = Graphics.FromImage(fontPictureBox.Image);

            char CurrentChar = (char)0;
            Size CurrentCharSize = new Size();
            if (CharacterSet[CurrentChar] == ' ')
            {
                CurrentCharSize.Width  = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericDefault).Width;
                CurrentCharSize.Height = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Height;
            }
            else
            {
                CurrentCharSize.Width  = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Width;
                CurrentCharSize.Height = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Height;
            }

            int   CurrentLineHeight = 0;
            Point CurrentPosition = new Point(0, 0);

            GlyphWidths.Clear();
            BoundingBoxes.Clear();

            while ((CurrentChar < CharacterSet.Length) && ((CurrentPosition.Y + GlyphInsets.Top + CurrentCharSize.Height + GlyphInsets.Bottom) < ImageResolution))
            {
                while ((CurrentChar < CharacterSet.Length) && ((CurrentPosition.X + GlyphInsets.Left + CurrentCharSize.Width + GlyphInsets.Right) < ImageResolution))
                {
                    GlyphWidths.Add((int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Width);
                    BoundingBoxes.Add(new Rectangle(CurrentPosition.X, CurrentPosition.Y, CurrentCharSize.Width + GlyphInsets.Right, CurrentCharSize.Height + GlyphInsets.Bottom));

                    if (glyphBoxesButton.Checked)
                    {
                        AGraphics.DrawRectangle(new Pen(Color.Green), CurrentPosition.X + GlyphInsets.Left, CurrentPosition.Y + GlyphInsets.Top, AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Width, CurrentCharSize.Height);
                    }
                    if (boundingBoxesButton.Checked)
                    {
                        AGraphics.DrawRectangle(new Pen(Color.Yellow), CurrentPosition.X, CurrentPosition.Y, CurrentCharSize.Width + GlyphInsets.Right, CurrentCharSize.Height + GlyphInsets.Bottom);
                    }

                    AGraphics.DrawString(CharacterSet[CurrentChar].ToString(), InputFont, new SolidBrush(Color.White), CurrentPosition.X + GlyphInsets.Left, CurrentPosition.Y + GlyphInsets.Top, StringFormat.GenericTypographic);

                    if ((CurrentCharSize.Height + GlyphInsets.Bottom) > CurrentLineHeight) { CurrentLineHeight = (CurrentCharSize.Height + GlyphInsets.Bottom); }

                    CurrentPosition.X += CurrentCharSize.Width + GlyphInsets.Right;

                    CurrentChar++;
                    if (CurrentChar == CharacterSet.Length) { return; }

                    if (CharacterSet[CurrentChar] == ' ')
                    {
                        CurrentCharSize.Width  = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericDefault).Width;
                        CurrentCharSize.Height = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Height;
                    }
                    else
                    {
                        CurrentCharSize.Width  = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Width;
                        CurrentCharSize.Height = (int)AGraphics.MeasureString(CharacterSet[CurrentChar].ToString(), InputFont, 2 ^ 32, StringFormat.GenericTypographic).Height;
                    }                                                                                                                                      
                }

                CurrentPosition.X = 0;
                CurrentPosition.Y += CurrentLineHeight;
                CurrentLineHeight = 0;
            }
        }

        private void onGlyphBoxesVisibilityChange(object sender, EventArgs e)
        {
            DrawGlyphBoxes = !DrawGlyphBoxes;
            RebuildImage();
        }

        private void onBoundingBoxesVisibilityChange(object sender, EventArgs e)
        {
            DrawBoundingBoxes = !DrawBoundingBoxes;
            RebuildImage();
        }

        private void onCharacterSetChanged(object sender, EventArgs e)
        {
            RebuildImage();
        }

        private void onInsetsChanged(object sender, EventArgs e)
        {
            RebuildImage();
        }

        private void onZoomChanged(object sender, EventArgs e)
        {
            zoomDisplay.Text = zoomValues[zoomTrackBar.Value] + "%";

            pictureBoxPanel.AutoScrollPosition = new Point(0, 0);

            fontPictureBox.SetBounds(0, 0, (int)(ImageResolution * ImageZoom), (int)(ImageResolution * ImageZoom));
        }

        private void onImageMouseClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                imageContextMenu.Show((Control)sender, e.Location);
            }
        }

        private void onImageCopyToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(fontPictureBox.Image, true);
        }
    }
}