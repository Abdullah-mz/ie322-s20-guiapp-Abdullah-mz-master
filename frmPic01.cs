using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;            //for stream object
using System.Reflection;    // for assembly

namespace Project_2
{
    public partial class frmPic01 : Form
    {

        Assembly _assembly;   //creating an assembly object
        Stream _imageStream;   // create an image stream object


        


        public frmPic01()
        {
            InitializeComponent();


            //controls the clipping and positioning of the image in the display area.
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
            picTry2.SizeMode = PictureBoxSizeMode.StretchImage;

            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

                 try
            {
                

                picTry.Image = Image.FromFile("C:\\Users\\sang\\Downloads\\alzamil kau.jpg"); // relative path
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile("C:\\Users\\sang\\Downloads\\alzamil kau.jpg"); // relative path

                picTry2.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void picTry_Click(object sender, EventArgs e)
        {


            //MessageBox.Show("Coordinates are: " + coordinates);

        } 

        private void frmPic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object
            _imageStream = _assembly.GetManifestResourceStream("Project_2.AA.kau.jpg");
            
        }

        private void picTry2_Click(object sender, EventArgs e)
        {

        }
    }
}
