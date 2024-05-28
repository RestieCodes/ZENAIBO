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

        public static List<Tuple<string, string, string, string, string, string, int>> SortTaskStorage()
        {
            var sortedTaskStorage = TaskStorage.OrderBy(p => p.Item4)
                                               .ThenBy(p => p.Item5)
                                               .ToList();

            for (int i = 0; i < sortedTaskStorage.Count; i++)
            {
                sortedTaskStorage[i] = new Tuple<string, string, string, string, string, string, int>(sortedTaskStorage[i].Item1, sortedTaskStorage[i].Item2, sortedTaskStorage[i].Item3, sortedTaskStorage[i].Item4, sortedTaskStorage[i].Item5, sortedTaskStorage[i].Item6, sortedTaskStorage[i].Item7);
            }
            return sortedTaskStorage;
        }

        public static void SaveChangesTaskDaily(string title, string descript, int taskType, int timeStart, int timeEnd, string date, string key1, string key2)
        {

            var userIndex = TaskDaily.FindIndex(p => p.Item1.Equals(key1) && p.Item2.Equals(key2));

            bool valid = true;
            bool exist = false;

            for (int i = 0; i < TaskDaily.Count; i++)
            {
                if (TaskDaily[i] == TaskDaily[userIndex])
                {
                    continue;
                }
                else
                {
                    if (TaskDaily[i].Item6 == date)
                    {
                        for (int j = TaskDaily[i].Item4; j < TaskDaily[i].Item5; j++)
                        {
                            for (int k = timeStart; k < timeEnd; k++)
                            {
                                if (j == k)
                                {
                                    valid = false;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < TaskDaily.Count; i++)
            {
                if (TaskDaily[i] == TaskDaily[userIndex])
                {
                    continue;
                }
                else
                {
                    if ((TaskDaily[i].Item1 == title && TaskDaily[i].Item2 == descript) && (TaskDaily[i].Item3 == taskType && TaskDaily[i].Item6 == date))
                    {
                        exist = true;
                    }
                }
            }


            if (valid && !exist)
            {
                TaskDaily[userIndex] = new Tuple<string, string, int, int, int, string>(title, descript, taskType, timeStart, timeEnd, date);
            }
            else if (exist)
            {
                MessageBox.Show("Task Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!valid)
            {
                MessageBox.Show("Overlapping Schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        public static void RemoveDailyTask(string title, string descript, int taskType, string date)
        {
            var userIndex = TaskDaily.FindIndex(p => p.Item1.Equals(title) && p.Item2.Equals(descript) && p.Item3.Equals(taskType) && p.Item6.Equals(date));
            TaskDaily.Remove(TaskDaily[userIndex]);
        }
    }
}
