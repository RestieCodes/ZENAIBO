using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class CalendarDay : Form
    {
        public CalendarDay()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int location = TempStorage.ReturnLoc(Convert.ToInt32(txtBoxTimeStart.Text));
            int size = Convert.ToInt32(txtBoxTimeEnd.Text) - (Convert.ToInt32(txtBoxTimeStart.Text) + 1);
            if (location != -1)
            {
                AddPanel(location, size);
            }
            else {
                return;
            }
        }

        private void AddPanel(int loc, int size) 
        {
            int height = 31 + (32 * size);
            System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel
            {
                Size = new Size(404, height),
                Location = new Point(147, loc),
                BackColor = Color.LightBlue,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Margin = new System.Windows.Forms.Padding(0,0,0,2)
            };

            System.Windows.Forms.Label label = new System.Windows.Forms.Label
            {
                Text = height.ToString(),
                Location = new Point(20,6)
            };

            panel.Controls.Add(label);
            /*panelSchedule.Controls.Add(panel);*/
        }

    }
}
