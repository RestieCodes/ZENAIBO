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
    public partial class ChronotypeExplanation : Form
    {
        public ChronotypeExplanation()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://zapier.com/blog/chronotype-productivity-schedule/");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
