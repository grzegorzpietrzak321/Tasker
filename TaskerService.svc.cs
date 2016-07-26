using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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

        public bool CreateTask(Task t)
        {
            throw new NotImplementedException();
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

        public string GetTask(int priorityId)
        {
            throw new NotImplementedException();
        }
        
        public void DoWork()
        {
        }
    }
}
