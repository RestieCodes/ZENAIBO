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
        public static List<Tuple<string, string, string, string, string, string>> TaskDoneHistory = new List<Tuple<string, string, string, string, string, string>>();
        public static List<Tuple<int, int>> wolfSchedLoc = new List<Tuple<int, int>> 
        {
           new Tuple<int, int>(8,56),
           new Tuple<int, int>(9,89),
           new Tuple<int, int>(10,118),
           new Tuple<int, int>(11,150),
           new Tuple<int, int>(12,182),
           new Tuple<int, int>(13,213),
           new Tuple<int, int>(14,244),
           new Tuple<int, int>(15,277),
           new Tuple<int, int>(16,307),
           new Tuple<int, int>(17,338),
           new Tuple<int, int>(18,370),
           new Tuple<int, int>(19,401),
           new Tuple<int, int>(20,431),
           new Tuple<int, int>(21,465),
           new Tuple<int, int>(22,492),
           new Tuple<int, int>(23,523)
        };
       
        
        
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
                TaskDoneHistory.Add(new Tuple<string, string, string, string, string, string>(title, description, taskType, month, day, year));
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

        public static void RemoveHistory(string title, string description)
        {
            var userIndex = TaskDoneHistory.FindIndex(p => p.Item1.Equals(title) && p.Item2.Equals(description));
            TaskDoneHistory.Remove(TaskDoneHistory[userIndex]);
        }

        public static int ReturnLoc(int key)
        {
            int loc = wolfSchedLoc.FindIndex(p => p.Item1.Equals(key));
            try { 
            return wolfSchedLoc[loc].Item2;
            }catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Can't set task in your sleeping sched", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
