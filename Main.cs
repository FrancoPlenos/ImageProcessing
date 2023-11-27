using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Main : Form
    {

        Bitmap loaded;
        Bitmap proccesed;

        public Main()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private bool CheckLoaded()
        {
            return loaded != null;
        }

        private bool CheckProcessed()
        {
            return proccesed != null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            loaded = (Bitmap)Image.FromFile(fileDialog.FileName);
            pbOriginal.Image = loaded;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckProcessed()) return;

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            proccesed.Save(dialog.FileName);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckLoaded()) return;
            Filter.Copy(ref loaded, ref proccesed);
            pbProcessed.Image = proccesed;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckLoaded()) return;
            Filter.Invert(ref loaded, ref proccesed);
            pbProcessed.Image = proccesed;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckLoaded()) return;
            Filter.Greyscale(ref loaded, ref proccesed);
            pbProcessed.Image = proccesed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckLoaded()) return;
            Filter.Sepia(ref loaded, ref proccesed);
            pbProcessed.Image = proccesed;
        }

        private void pbProcessed_Paint(object sender, PaintEventArgs e)
        {
            pnlHistogram.Invalidate();
        }

        private void pnlHistogram_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (!CheckProcessed()) return;

            int[] data = Histogram.Grey(proccesed);
            Histogram.Draw(g, pnlHistogram.Size, data);
        }
    }
}
