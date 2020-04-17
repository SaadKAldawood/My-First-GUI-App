using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_GUI_App
{
    public partial class frmRandom : Form
    {
        Random y = new Random();

        public frmRandom()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        

        private void btnRandoC_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            btnRandoC.BackColor = Color.FromArgb(r, g, b);



        }

        private void btnRandomN_Click_1(object sender, EventArgs e)
        {
            btnRandomN.Text = Convert.ToString(y.Next(1, 100));
        }

        private void Random_Load(object sender, EventArgs e)
        {

        }
    }
}
