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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void RdoGreen1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
            
                RdoRed.ForeColor = Color.FromArgb(255, 0, 0);
                else
                    RdoRed.ForeColor = Color.FromArgb(0, 0, 0);
            
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)

                RdoGreen.ForeColor = Color.FromName("green");
            else
                RdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)

                RdoBlue.ForeColor = Color.FromName("blue");
            else
                RdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)

                RdoYellow.ForeColor = Color.FromName("yellow");
            else
                RdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
            RdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
            RdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
            RdoRed.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
