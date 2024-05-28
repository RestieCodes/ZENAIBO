using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    internal class TempStorage
    {
        //For Accounts
        public static List<string> EmailList = new List<string>();
        public static List<string> ChronoTypeList = new List<string>();
        public static List<string> UsernameList = new List<string>();
        public static List<string> PasswordList = new List<string>();




        public static List<Tuple<string, string, string, string, string, string, int>> TaskStorage = new List<Tuple<string, string, string, string, string, string, int>>();
        public static List<Tuple<string, string, string, string, string, string>> TaskDoneHistory = new List<Tuple<string, string, string, string, string, string>>();
        public static List<Tuple<string, string, int, int, int,string>> TaskDaily = new List<Tuple<string, string, int, int, int, string>>();
       
        
        
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

        public static void SaveTask(string title, string descipt, int taskType, int timeStart, int timeEnd, string date)
        {
            bool valid = true;
            bool exist = false;
            if (TaskDaily.Count > 0)
            {
                foreach (var a in TempStorage.TaskDaily)
                {
                    if (a.Item6 == date)
                    {
                        for (int i = a.Item4; i < a.Item5; i++)
                        {
                            for (int j = timeStart; j < timeEnd; j++)
                            {
                                if (i == j)
                                {
                                    valid = false;
                                }
                            }
                        }
                    }                   
                }

                exist = TaskDaily.Any(t =>
                t.Item1 == title &&
                t.Item2 == descipt &&
                t.Item3 == taskType &&
                t.Item6 == date);
   


                if (valid && !exist) 
                {
                    TaskDaily.Add(new Tuple<string, string, int, int, int, string>(title, descipt, taskType, timeStart, timeEnd, date));
                }
                else if(exist) 
                {
                    MessageBox.Show("Task Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!valid)
                {
                    MessageBox.Show("Overlapping Schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                TaskDaily.Add(new Tuple<string, string, int, int, int, string>(title,descipt,taskType,timeStart,timeEnd, date));
            }
        }

        public static List<Tuple<string, string, int, int, int, string>> SortDailyTask() 
        {
            var sortedDailyTask = TaskDaily.OrderBy(p => p.Item4).ToList();

            for (int i = 0; i < sortedDailyTask.Count; i++)
            {
                sortedDailyTask[i] = new Tuple<string, string, int, int, int, string>(sortedDailyTask[i].Item1, sortedDailyTask[i].Item2, sortedDailyTask[i].Item3, sortedDailyTask[i].Item4, sortedDailyTask[i].Item5 , sortedDailyTask[i].Item6);
            }
            return sortedDailyTask;
        }

     
    }
}
