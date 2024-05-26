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
    public partial class TaskDaily : UserControl
    {
        int width = 406;
        int BaseHeightOdd = 47;
        int BaseHeightEven = 98;
        
        public TaskDaily()
        {
            InitializeComponent();
        }

        public void DisplayTask(Tuple<string, string, int, int, int, string> data) 
        { 
            lblTitle.Text = data.Item1;
            lblDescript.Text = data.Item2;

            switch (data.Item3)
            {

                case 0:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023405_591;
                    break;

                case 1:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022644_520;
                    break;

                case 2:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023254_961;
                    break;

                case 3:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T021726_290;
                    break;

                case 4:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022707_602;
                    break;

                case 5:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T022658_810;
                    break;

                case 6:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023527_334;
                    break;

                case 7:
                    pictureBoxIcon.Image = Properties.Resources.Untitled_design___2024_04_29T023639_486;
                    break;
            }

            PanelSize(data.Item5 - data.Item4);
            PanelPos(data.Item4);
        }

        public void PanelSize(int num) 
        {
            if (num % 2 == 0)
            {
                this.Size = new System.Drawing.Size(width, BaseHeightEven + 50 * (num - 2));
            }
            else {
                this.Size = new System.Drawing.Size(width, BaseHeightOdd + 50 * (num - 1));
            }
            
        }

        public void PanelPos(int start)
        {
           int baseLoc = 3;

            this.Location = new System.Drawing.Point(3, baseLoc + 51 * (start - 8) - 1);

        }
    }
}
