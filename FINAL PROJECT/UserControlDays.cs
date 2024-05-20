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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }

        public void Days(int numday) 
        {
            lbDays.Text = numday+"";
        
        }

        public void IconTrigger(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                if (lbDays.Text == array[i].ToString())
                {
                    /*picBoxEmpty.Image = Properties.Resources.academicIcon;*/
                }
            }
            
        }

        private void picBoxEmpty_Click(object sender, EventArgs e)
        {
            PopUpCalendar popUpCalendar = new PopUpCalendar();
            popUpCalendar.label1.Text = lbDays.Text;
            popUpCalendar.Show();
        }
    }
}
