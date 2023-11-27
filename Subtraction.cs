using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Subtraction : Form
    {
        private Bitmap imageA; // background image
        private Bitmap imageB; // greenscreen-ed image
        private Bitmap resultImage; // subtracted image

        public Subtraction()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += Subtraction_FormClosing;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Main mainForm = new Main();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void btnLoadGreen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;
                    pbGreen.Image = Image.FromFile(selectedFileName);

                    imageB = new Bitmap(selectedFileName);
                }
            }
        }

        private void btnLoadBG_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;
                    pbBackground.Image = Image.FromFile(selectedFileName);

                    imageA = new Bitmap(selectedFileName);
                }
            }
        }

        private void Subtraction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

private void btnSubtract_Click(object sender, EventArgs e)
{
    if (resultImage == null)
    {
        resultImage = new Bitmap(imageB.Width, imageB.Height);
    }

    Color mygreen = Color.FromArgb(0, 0, 255);
    int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
    int threshold = 5;

    for (int x = 0; x < imageB.Width; x++)
    {
        for (int y = 0; y < imageB.Height; y++)
        {
            Color pixelB = imageB.GetPixel(x, y);
            Color pixelA = imageA.GetPixel(x, y);
            int greyB = (pixelB.R + pixelB.G + pixelB.B) / 3;
            int subtractValue = Math.Abs(greyB - greygreen);

            if (subtractValue < threshold)
            {
                resultImage.SetPixel(x, y, pixelA);
            }
            else
            {
                resultImage.SetPixel(x, y, pixelB);
            }
        }
    }

    pbSubtracted.Image = resultImage;
}

    }
}
