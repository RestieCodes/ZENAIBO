using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    internal class TempStorage
    {
        public static List<Tuple<string, string, string, string, string, string>> TaskStorage = new List<Tuple<string, string, string, string, string, string>>();

        public static void AddTask(string title, string description, string taskType, string month, string day, string year) 
        {
            bool exist = TaskStorage.Any(t =>
            t.Item1 == title &&
            t.Item2 == description &&
            t.Item3 == taskType &&
            t.Item4 == month &&
            t.Item5 == day &&
            t.Item6 == year);

            if (!exist) 
            {
                TaskStorage.Add(new Tuple<string, string, string, string, string, string>(title,description,taskType,month,day,year));
            }else {
                MessageBox.Show("Task Already Exist","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
