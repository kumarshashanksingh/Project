using kanban.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kanban.DA
{
    public class TaskDa
    {
        public static List<ViewModel.Task> GetList()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();



            //var list = (from uh in db.TaskKanbans
            //        select new Task()
            //        {
            //            taskId=uh.TaskId ,
            //            taskName=uh.TaskName,
            //        }).ToList();
            var list = (from uh in db.testDBs 
                        select new Task()
                        {
                            taskId = (int)uh.id,
                            taskName = uh.name,
                        }).ToList();

            return list;
        }

        internal static Task get(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var l = (from uh in db.testDBs
                    where uh.id == id
                    select new Task()
                    {
                        taskId=(int)uh.id,
                        taskName=uh.name
                      
                    }).Single();

            return l;
        }

        public  static void update(Task id)
        {
            using (var db = new DataClasses1DataContext())
            {
               
                testDB vm;

                vm = db.testDBs.Single(x => x.id == id.taskId);

                vm.name = id.taskName;

                db.SubmitChanges();
            }
        }
    }
}