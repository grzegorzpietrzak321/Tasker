using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tasker
{
    public class TaskService : ITaskService
    {

        SqlConnection connection;
        SqlCommand command;
        SqlConnectionStringBuilder connectionStringBuilder;

        public TaskService()
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
    }
}