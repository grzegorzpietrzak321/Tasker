using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tasker
{
    [ServiceContract]
    public interface ITaskService
    {
        //TODO move to itaskerservice
        [OperationContract]
        bool CreateTask(Task t);

        [OperationContract]
        bool EditTask(Task t);

        [OperationContract]
        bool FinishTask(int taskId);

        [OperationContract]
        string ShowTask(int taskId);

        [OperationContract]
        string GetTask(int priorityId);
    }

    [DataContract]
    public class Task
    {
        [Key]
        [DataMember]
        int id { get; set; }

        [DataMember]
        string name { get; set; }

        [DataMember]
        string description { get; set; }

        [DataMember]
        int priority { get; set; }

        [DataMember]
        DateTime createDate { get; set; }

        [DataMember]
        DateTime deadlineDate { get; set; }
        
        bool isFinished = false;

        [DataMember]
        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }
    }
}