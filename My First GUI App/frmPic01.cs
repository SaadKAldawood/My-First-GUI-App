using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;

namespace My_First_GUI_App
{
    public partial class frmPic01 : Form
    {
        Assembly _assembly;
        Stream _imageStrem;
        public frmPic01()
        {

            InitializeComponent();
        }

        private void btnFromF_Click(object sender, EventArgs e)
        {
            try
            {
                PicTry.Image = Image.FromFile("C:\\Users\\PCA\\Desktop\\Anas.jpeg");
            }
            catch 
            {
                MessageBox.Show("Image file not found"); 
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PicTry_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStrem = _assembly.GetManifestResourceStream("My_First_GUI_App.pictures.Anas.jpeg");
        }

        private void btnFromR_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = Image.FromStream(_imageStrem);
            }
            catch 
            {
                MessageBox.Show("Error creating image from resource!");
               
            }
        }
    }
}
