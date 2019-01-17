using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGallery
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();

        int MAX_COUNT = 5;
        int MIN_COUNT = 1;
        int CurrentImage = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void rbPictureOne_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = MyGallery.Properties.Resources.pepper1;
        }

        private void rbPictureTwo_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = MyGallery.Properties.Resources.photo_1497395122351_5d3554bbdb17;
        }

        private void rbPictureThree_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = MyGallery.Properties.Resources.photo_1505725513549_477dfcbe55c2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int number = rnd.Next(1, 6);
            RenderImage(number);
            
        }

        private void btnStartShow_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStopShow_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            pbGallery.Width += 20;
            pbGallery.Height += 20;
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            pbGallery.Width -= 20;
            pbGallery.Height -= 20;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(CurrentImage > MIN_COUNT)
            {
                CurrentImage--;
                btnRight.Enabled = true;
                RenderImage(CurrentImage);
            }

            if(CurrentImage == MIN_COUNT)
            {
                btnLeft.Enabled = false;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(CurrentImage < MAX_COUNT)
            {
                CurrentImage++;
                btnLeft.Enabled = true;
                RenderImage(CurrentImage);
            }

            if(CurrentImage == MAX_COUNT)
            {
                btnRight.Enabled = false;
            }
        }

        private void RenderImage(int number)
        {
            switch (number)
            {
                case 1:
                    pbGallery.Image = MyGallery.Properties.Resources.pepper1;
                    break;
                case 2:
                    pbGallery.Image = MyGallery.Properties.Resources.photo_1497395122351_5d3554bbdb17;
                    break;
                case 3:
                    pbGallery.Image = MyGallery.Properties.Resources.photo_1505725513549_477dfcbe55c2;
                    break;
                case 4:
                    pbGallery.Image = MyGallery.Properties.Resources.photo_1526346698789_22fd84314424;
                    break;
                case 5:
                    pbGallery.Image = MyGallery.Properties.Resources.photo_1533841175647_39fea57b86ba;
                    break;
            }
        }
    }
}
