using kanban.DA;
using kanban.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kanban.Services
{
    public class KanbanServices
    {

        public static List<Task> GetList()
        {
           return  TaskDa.GetList();
            
        }
    }
}