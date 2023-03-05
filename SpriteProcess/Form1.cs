using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All Images|*.JPG;*.BMP;*.PNG;*.GIF|Bitmaps|*.BMP|JPG Files|*.JPG|PNG Files|*.PNG";
                ofd.CheckFileExists = true;
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in ofd.FileNames)
                    {
                        if (!lstSourceFiles.Items.Contains(f))
                        {
                            lstSourceFiles.Items.Add(f);
                        }
                    }
                }
            }
        }

        private void cmdAlpha_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdlg = new ColorDialog())
            {
                if (cdlg.ShowDialog() == DialogResult.OK)
                {
                    pbAlpha.BackColor = cdlg.Color;
                }
            }
        }

        private void cmdShadow_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdlg = new ColorDialog())
            {
                if (cdlg.ShowDialog() == DialogResult.OK)
                {
                    pbShadow.BackColor = cdlg.Color;
                }
            }
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            prgProgress.Value = 0;
            prgProgress.Maximum = lstSourceFiles.Items.Count;

            int errCount = 0;
            foreach (var f in lstSourceFiles.Items)
            {
                prgProgress.Value++;
                Application.DoEvents();
                if (!System.IO.File.Exists(f.ToString()))
                {
                    errCount++;
                    continue;
                }
                string spriteOutfile = null;
                string shadowOutfie = null;
                if (!string.IsNullOrWhiteSpace(txtSpriteDir.Text))
                {
                    spriteOutfile = MapPath(f.ToString(), txtSpriteDir.Text, "png");
                    if (System.IO.File.Exists(spriteOutfile))
                    {
                        errCount++;
                        continue;
                    }
                }
                if (!string.IsNullOrWhiteSpace(txtShadowDir.Text))
                {
                    shadowOutfie = MapPath(f.ToString(), txtShadowDir.Text, "png");
                    if (System.IO.File.Exists(shadowOutfie))
                    {
                        errCount++;
                        continue;
                    }
                }

                Bitmap source = null;
                try
                {
                    source = (Bitmap)Image.FromFile(f.ToString());
                }
                catch
                {
                    errCount++;
                    continue;
                }

                Color alphaPx = pbAlpha.BackColor;
                Color shadowPx = pbShadow.BackColor;
                
                Bitmap sprite = new Bitmap(source.Width, source.Height);
                Bitmap shadow = new Bitmap(source.Width, source.Height);
                using (Graphics g = Graphics.FromImage(sprite))
                {
                    g.Clear(Color.Transparent);
                }
                using (Graphics g = Graphics.FromImage(shadow))
                {
                    g.Clear(Color.Transparent);
                }

                for (int y = 0; y < source.Height; y++)
                {
                    for (int x = 0; x < source.Width; x++)
                    {
                        Color srcPx = source.GetPixel(x, y);
                        if (ColorEq(srcPx, shadowPx))
                        {
                            shadow.SetPixel(x, y, srcPx);
                        }
                        else if (!ColorEq(srcPx, alphaPx))
                        {
                            sprite.SetPixel(x, y, srcPx);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(spriteOutfile))
                {
                    sprite.Save(spriteOutfile, ImageFormat.Png);
                }
                if (!string.IsNullOrEmpty(shadowOutfie))
                {
                    shadow.Save(shadowOutfie, ImageFormat.Png);
                }

                sprite.Dispose();
                shadow.Dispose();
                source.Dispose();
            }
            if (errCount > 0)
            {
                MessageBox.Show($"Couldn't process {errCount} items.");
            }
            else
            {
                MessageBox.Show("Done");
            }
        }

        private string MapPath(string source, string destination, string ext)
        {
            string file = $"{Path.GetFileNameWithoutExtension(source)}.{ext}";
            return Path.Combine(destination, file);
        }

        private bool ColorEq(Color a, Color b)
        {
            return a.R == b.R && a.G == b.G && a.B == b.B;
            
        }

    }
}
