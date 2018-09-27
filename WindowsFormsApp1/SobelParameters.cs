using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SobelParameters : Form
    {
        Form1 form;

        public SobelParameters()
        {
            InitializeComponent();
        }

        public SobelParameters(Form1 fm)
        {
            InitializeComponent();
            form = fm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(form != null)
            {
                form.ApplySobel((int)nudXOrder.Value, (int)nudYOrder.Value, (int)nudAperture.Value);
            }
        }
    }
}
