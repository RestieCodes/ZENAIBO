using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class aboutUs : KryptonForm
    {
        private readonly Image[] images;
        private int currentIndex;

        public aboutUs()
        {
            InitializeComponent();
            pictureBox2.BackColor = Color.Transparent;
            contentContainer.BackColor = Color.Transparent;

            images = new Image[]
            {
                Properties.Resources.aboutUs_ZenAibo,
                Properties.Resources.aboutUS_ZenAibo2,
                Properties.Resources.aboutUs_ZenAibo3
            };
        }


        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Length;
            contentContainer.Image = images[currentIndex];
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + images.Length) % images.Length;
            contentContainer.Image = images[currentIndex];
        }

        private void aboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
