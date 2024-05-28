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
    public partial class GoaLIcon : UserControl
    {
        public GoaLIcon()
        {
            InitializeComponent();
        }

        public void Display(int selectedGoalType) 
        {
            switch (selectedGoalType)
            {
                case 0:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T023405_591;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 1:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T022644_520;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 2:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T023254_961;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 3:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T021726_290;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 4:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T022707_602;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 5:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T022658_810;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 6:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T023527_334;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 7:
                    this.BackgroundImage = Properties.Resources.Untitled_design___2024_04_29T023639_486;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
            }
        }
    }
}
