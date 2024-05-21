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
        public static List<Tuple<string, string, string, string, string, string, int>> TaskStorage = new List<Tuple<string, string, string, string, string, string,int>>();

        public static void AddTask(string title, string description, string taskType, string month, string day, string year, int index) 
        {
            bool exist = TaskStorage.Any(t =>
            t.Item1 == title &&
            t.Item2 == description &&
            t.Item3 == taskType &&
            t.Item4 == month &&
            t.Item5 == day &&
            t.Item6 == year && 
            t.Item7 == index);

            if (!exist) 
            {
                TaskStorage.Add(new Tuple<string, string, string, string, string, string, int>(title,description,taskType,month,day,year,index));
            }else {
                MessageBox.Show("Task Already Exist","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveChanges(string title, string description, string taskType, string month, string day, string year, int index, string key)
        {
           
            var userIndex = TaskStorage.FindIndex(p => p.Item2.Equals(key));
            if (TaskBar.doneTask == true)
            {
                TaskStorage.Remove(TaskStorage[userIndex]);
            }
            else
            {
                TaskStorage[userIndex] = new Tuple<string, string, string, string, string, string, int>(title, description, taskType, month, day, year, index);
            }
        }

        public static void RemoveTask(string key)
        {
            var userIndex = TaskStorage.FindIndex(p => p.Item2.Equals(key));
            TaskStorage.Remove(TaskStorage[userIndex]);
        }
    }
}
