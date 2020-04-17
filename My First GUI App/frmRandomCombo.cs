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
    public partial class frmRandomCombo : Form
    {
        Random r = new Random();
        public frmRandomCombo()
        {
            
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CmbAAF.ResetText();
            CmbAAF.Items.Clear();
            for (int i = 0; i < r.Next(1,51); i++)
            {
                CmbAAF.Items.Add(r.Next(100, 999)); 
            }
        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CmbAAF.ResetText();
            CmbAAF.Items.Clear();
            RdoLess500.Checked = false;
            RdoGreater500.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
