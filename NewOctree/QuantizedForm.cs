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
    public partial class QuantizedForm : Form
    {
        public QuantizedForm(Bitmap quantizedBmp, List<Color> palette)
        {
            InitializeComponent();
            picBoxQuantized.Image = quantizedBmp;
            foreach (Color c in palette)
            {
                Panel panel = new Panel();
                panel.Width = 15;
                panel.Height = 15;
                panel.BackColor = c;
                flowLayoutPanel.Controls.Add(panel);
            }
        }
    }
}
