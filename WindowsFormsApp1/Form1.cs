using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = imgInput;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que deseas salir?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyCanny();
        }

        public void ApplyCanny(double thresh = 50.0, double threshLink = 20.0)
        {
            if (imgInput == null)
            {
                return;
            }

            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgCanny = imgInput.Canny(thresh, threshLink);
            imageBox1.Image = imgCanny;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplySobel();
        }

        public void ApplySobel(int xOrder = 29, int YOrder = 27, int aperture = 31)
        {
            if (imgInput == null)
            {
                return;
            }

            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgSobel = imgGray.Sobel(xOrder, YOrder, aperture);
            imageBox1.Image = imgSobel;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyLaplacian();
        }

        public void ApplyLaplacian( int aperture = 7)
        {
            if(imgInput == null){
                return;
            }

            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgLaplace = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgLaplace = imgGray.Laplace(aperture);
            imageBox1.Image = imgLaplace;
        }

        private void cannyParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CannyParameters cp = new WindowsFormsApp1.CannyParameters(this);
            cp.StartPosition = FormStartPosition.CenterParent;
            cp.Show();
        }

        private void sobelParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelParameters sp = new WindowsFormsApp1.SobelParameters(this);
            sp.StartPosition = FormStartPosition.CenterParent;
            sp.Show();
        }

        private void laplacianParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaplacianParameters lp = new WindowsFormsApp1.LaplacianParameters(this);
            lp.StartPosition = FormStartPosition.CenterParent;
            lp.Show();
        }
    }
}
