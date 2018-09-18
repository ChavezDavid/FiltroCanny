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
            if(imgInput == null)
            {
                return;
            }

            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgCanny = imgInput.Canny(50, 30);
            imageBox1.Image = imgCanny;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }

            Image<Gray, byte> imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            imgSobel = imgGray.Sobel(29, 29, 31);
            imageBox1.Image = imgSobel;
        }
    }
}
