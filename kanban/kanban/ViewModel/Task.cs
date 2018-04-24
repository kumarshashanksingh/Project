using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kanban.ViewModel
{
    public class Task
    {
        //public Guid taskId { get; set; }
        public string state { get; set; }

        public int taskId { get; set; }
        public string taskName { get; set; }
        public DateTime dueDate { get; set; }
        public string Description { get; set; }
        public taskType TaskType { get; set; }
        public string Attachements { get; set; }
        public string issueType { get; set; }
        //public string  priority { get; set; }
        public string Summary { get; set; }
        public string assignee { get; set; }

        public List<Task> a { get; set; }

        //public static List<Task> taskg(List<string> s, List<Task> vm)
        //{

        //    List<Task> e = new List<Task>();
        //        for (int i = 1; i < vm.Count(); i++)
        //        {
        //        //e[i].taskId = vm[i].taskId;
        //        //e[i].taskName = vm[i].taskName;
        //        e[i].s = s[i];
        //    }
        //     return e;
        //}

        public string s { get; set; }

        //    internal static Task task(List<string> s,List<Task>d)
        //    {
        //        return new Task()
        //        {
        //            taskId=d.taskId,
        //            taskName=d.taskName,
        //            s=s,
        //        };

        //}

        public enum taskType
        {
            Task,
            Bug,
            RFE
        }

        public enum priority
        {
            Medium,
            Low,
            Lowest,
            Urgent,
            Immediate,

        }
    }
}