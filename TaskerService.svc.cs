using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Text;
using Newtonsoft.Json;


namespace Tasker
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaskerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TaskerService.svc or TaskerService.svc.cs at the Solution Explorer and start debugging.
    public class TaskerService : ITaskerService
    { 
        //SqlConnection connection;
        //SqlCommand command;
        //SqlConnectionStringBuilder connectionStringBuilder;

       // public TaskerService()
        //{
       //     ConnectToDB();
      //  }

       // private void ConnectToDB()
        //{
        //    connectionStringBuilder = new SqlConnectionStringBuilder();
        //    connectionStringBuilder.DataSource = "PC";
        //    connectionStringBuilder.InitialCatalog = "TaskerDB";
       //     connectionStringBuilder.IntegratedSecurity = true;

       //     connection = new SqlConnection(connectionStringBuilder.ToString());
       //     command = connection.CreateCommand();
       // }

        public bool CreateTask(Task task)
        {
            try
            {
                using (var conn = new TaskerDataModel())
                {
                    //task.isFinished = false;
                    conn.Tasks.Add(task);
                    conn.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditTask(Task t)
        {
            try
            {
                using (var conn = new TaskerDataModel())
                {
                    var listTasks = conn.Tasks.Where(i => i.id == t.id);
                    listTasks.SingleOrDefault().name = t.name;
                    listTasks.SingleOrDefault().description = t.description;
                    listTasks.SingleOrDefault().deadlineDate= t.deadlineDate;
                    listTasks.SingleOrDefault().priority = t.priority;
                    conn.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool FinishTask(int taskId)
        {
            try
            {
                using (var conn = new TaskerDataModel())
                {
                    var listTasks = conn.Tasks.Where(i => i.id == taskId);
                    listTasks.FirstOrDefault().isFinished = true;
                    conn.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string ShowTask(int taskId)
        {
            string result = null;

            try
            {
                IEnumerable<Task> listTasks;
                using (var conn = new TaskerDataModel())
                {
                    listTasks = conn.Tasks.Where(i => i.id == taskId);
                    result = JsonConvert.SerializeObject(listTasks);
                }
                return result;
            }
            catch (Exception e)
            {
                    
                return e.ToString();
            }
        }

        public string GetTasks(int priorityId)
        {
            try
            {
            IEnumerable<Task> listTasks;
            string result;
                using (var conn = new TaskerDataModel())
                {
                    listTasks = conn.Tasks.Where(i => (i.priority == priorityId));
                    result = JsonConvert.SerializeObject(listTasks);
                }
                
                return result;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
