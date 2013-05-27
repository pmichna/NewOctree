using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOctree
{
    public partial class MainWindow : Form
    {
        private OctreeQuantizer quantizer = new OctreeQuantizer();
        private List<Color> limitedPalette = new List<Color>();
        private List<Color> originalPalette = new List<Color>();
        private Bitmap originalBmp;
        private Form quantizedForm;
        private int width, height;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //quantizer.Init();
            using (openFileDialog)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picBoxOriginal.Image = new Bitmap(openFileDialog.FileName);
                    btnQuantize.Enabled = true;
                    originalBmp = new Bitmap(picBoxOriginal.Image);
                    height = originalBmp.Height;
                    width = originalBmp.Width;
                    for (int y = 0; y < height; y++)
                        for (int x = 0; x < width; x++)
                        {
                            Color c = originalBmp.GetPixel(x, y);
                            quantizer.AddColor(c);
                        }
                }
            }
        }

        private void btnQuantize_Click(object sender, EventArgs e)
        {
            if (quantizedForm != null)
            {
                quantizedForm.Dispose();
                quantizedForm.Close();
                quantizer.Clear();
                for (int y = 0; y < height; y++)
                    for (int x = 0; x < width; x++)
                    {
                        Color c = originalBmp.GetPixel(x, y);
                        quantizer.AddColor(c);
                    }
            }
            int limit = Decimal.ToInt32(numericUpDown.Value);
            limitedPalette = quantizer.GetPalette(limit);
            Bitmap quantizedBmp = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    quantizedBmp.SetPixel(x, y, limitedPalette[quantizer.GetPaletteIndex(originalBmp.GetPixel(x,y))]);
                }
            
            quantizedForm = new QuantizedForm(quantizedBmp, limitedPalette);
            quantizedForm.Show(); //poprawić wyświetlanie ponowne
            
        }
    }
}
