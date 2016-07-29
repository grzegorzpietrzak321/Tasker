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
        SqlConnection connection;
        SqlCommand command;
        SqlConnectionStringBuilder connectionStringBuilder;

        public TaskerService()
        {
            ConnectToDB();
        }

        private void ConnectToDB()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "PC";
            connectionStringBuilder.InitialCatalog = "TaskerDB";
            connectionStringBuilder.IntegratedSecurity = true;

            connection = new SqlConnection(connectionStringBuilder.ToString());
            command = connection.CreateCommand();
        }

        public bool CreateTask(Task task)
        {
            
            Task lastElement;
            //pobieramy ostatni element z tablicy
            
            try
            {
                using (var conn = new TaskerDataModel())
                {
                    lastElement = conn.Tasks.Last();

                    task.id = lastElement.id++;

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
            throw new NotImplementedException();
        }

        public bool FinishTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public string ShowTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public string GetTasks(int priorityId)
        {
            try
            {
                IEnumerable<Task> listTasks;
                using (var conn = new TaskerDataModel())
                {
                    listTasks = conn.Tasks.Where(i => i.priority == priorityId);
                }

                string result = JsonConvert.SerializeObject(listTasks);

                //TODO serializowac i przesłac do klienta
                return result;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
