using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Program that lets you view your local images
 */


namespace Csharp_app
{
    public partial class Form1 : Form
    {
        

        

        public Form1()
        {
            
            InitializeComponent();
        }

        // ImageSelector() selects your image file
        private void ImageSelector()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.jpg | *.jpg |*.png | *.png";
            ofd.FileName = "";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {

              pictureBox2.Image = Image.FromFile(ofd.FileName);

            }
            if (pictureBox2.Image != null)
            {
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Image.FromFile(ofd.FileName);
            }

        }
        // when you click the Open image... button it selects your jpg/png file through ImageSelector() list and shows it in the PictureBox while scaling with the form.
        private void randomImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            
            ImageSelector();
        }

        // Pressing this button changes form to maximized with basic if/else statements
        private void fullScreenF11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        // Sets the F11 key to be fullscreen allowing it to maximize and minimize with button press.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form1.ActiveForm.KeyPreview = true;

            if (e.KeyCode == Keys.F11)
            {
                if (WindowState == FormWindowState.Maximized) 
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized; 
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Basic image showing app");
        }
    }
    }
    

